using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementForms
{
    public class CollaboratorsEqualityComparer : IEqualityComparer<Collaborators>
    {
        public bool Equals(Collaborators x, Collaborators y)
        {
            return x.UserA == y.UserA &&
                x.UserB == y.UserB;
        }

        public int GetHashCode(Collaborators obj)
        {
            return obj.GetHashCode();
        }
    }

    public class CollaboratorsUtility
    {
        /// <summary>
        /// Create collaborations amongst the selected users. Currently this can only generate 2 collaborations
        /// for 1/3 of the users selected. The users must be selected contiguosly.
        /// </summary>
        /// <param name="_context">The dbcontext where the database will be persisted.</param>
        /// <param name="bindingUsers">All the users on the data grid.</param>
        /// <param name="UsersDataGrid">The data grid.</param>
        public static void CreateCollaboratorsFromSelected(IdeallyConnectedTestDbEntities _context, 
            IList<Users> bindingUsers, DataGridView UsersDataGrid)
        {
            // Store the indexes representing the rows selected
            int totalRowsSelected = UsersDataGrid.SelectedRows.Count;

            // Storing all the existing Collaborators into a dictionary to prevent adding existing data.
            _context.Collaborators.Load();
            Dictionary<string, Dictionary<string, bool>> collabChecker = 
                new Dictionary<string, Dictionary<string, bool>>(_context.Collaborators.Count());
            foreach (Collaborators co in _context.Collaborators.Local)
            {
                if (!collabChecker.ContainsKey(co.UserA))
                    collabChecker.Add(co.UserA, new Dictionary<string, bool>() { { co.UserB, true } });
                else
                    collabChecker[co.UserA].Add(co.UserB, true);
            }

            _context.Configuration.AutoDetectChangesEnabled = false; // improves performance

            // Create a collaboration between a user and the two (rows) after.
            for (int i = 0; i < totalRowsSelected; ++i)
            {
                int j = i + 1;
                int userdataGridi = UsersDataGrid["userNameDataGridViewTextBoxColumn", i].ColumnIndex;

                // Make the next two users as collaborators with the user, i.
                for (; j < totalRowsSelected && j < i + 3 && j < UsersDataGrid.RowCount - 2; ++j)
                {
                    // Check if the collaberators are already stored in the database; save changes periodically. No change checking.
                    if (!collabChecker.ContainsKey(bindingUsers[i].Id) ||
                        !collabChecker[bindingUsers[i].Id].ContainsKey(bindingUsers[j].Id))
                    {
                        // Create and add a new collaborating user
                        _context.Collaborators.Add(new Collaborators()
                        {
                            UserA = bindingUsers[i].Id,
                            UserB = bindingUsers[j].Id,
                            Following = true,
                            InitialCollaboration = DateTime.Now,
                            Initiated = true
                        });

                        if (_context.Collaborators.Count() % 100 == 0)
                        {
                            _context.SaveChanges();
                        }
                    }
                }

                i = j - 1;
            }

            _context.Configuration.AutoDetectChangesEnabled = true;
        }

        static Func<Users, Users, Collaborators> newCollaborators = 
            (a, b) => new Collaborators() { Users = a, Users1 = b,  UserA = a.Id, UserB = b.Id,
                InitialCollaboration = DateTime.Now, Initiated = true
            };

        public static void CreateCollaboratorsForUser(ref Users user, int total, List<Users> others)
        {
            user.Collaborators = new HashSet<Collaborators>(new CollaboratorsEqualityComparer());
            foreach(Users otherUser in others)
            {
                Collaborators collab = newCollaborators(user, otherUser);
                if (!user.Collaborators.Contains(collab))
                {
                    user.Collaborators.Add(collab);
                }
            }
        }
    }
}
