using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementForms
{
    using AdventureWorksLT2008R2DataSetTableAdapters;
    using System.ComponentModel;
    using System.Data.Entity.Migrations;
    using System.Windows.Forms;

    public class UsersUtility
    {
        public static Random random = new Random(); 

        public static void CreateNewUsers(CustomerTableAdapter customerTableAdapter, 
            ref BindingSource bindingSource, ref IdeallyConnectedTestDbEntities context)
        {
            // Iterating through the list of users from AdventureWorksLT2008
            foreach (DataRow customer in customerTableAdapter.GetData().Rows)
            {
                Users newUser = new Users();
                newUser.Id = Guid.NewGuid().ToString();
                newUser.FirstName = (string)customer["FirstName"];
                newUser.LastName = (string)customer["LastName"];
                newUser.UserName = newUser.FirstName + newUser.LastName + Convert.ToString(random.Next()).Substring(0, 5);
                newUser.PhoneNumber = (string)customer["Phone"];
                newUser.Email = (string)customer["EmailAddress"];
                newUser.Created = DateTime.Now;
                context.Users.Add(newUser);
                if(bindingSource.Count % 100 == 0)
                {
                    context.SaveChanges();
                }
                bindingSource.Add(newUser);
            }
        }

        /// <summary>
        /// Create a list of random dates (DateTime objects).
        /// </summary>
        /// <param name="amount">The amount of random dates to produce.</param>
        /// <returns></returns>
        public static List<DateTime> CreateRandomDates(int amount)
        {
            List<DateTime> randomDates = new List<DateTime>(new DateTime[amount]);
            long elapsedTicks = DateTime.Now.Ticks - (new DateTime(2012, 1, 1)).Ticks;
            
            // Create a random date within a recent time frame (after 2012).
            for(int i = 0; i < amount; ++i)
            {
                randomDates[i] = new DateTime(DateTime.Now.Ticks - (elapsedTicks / random.Next(1,100)));
            }

            return randomDates;
        }
    }

    public class UserEqualityComparer : IEqualityComparer<Users>
    {
        public static bool CompareUsers(Users A, Users B)
        {
            UserEqualityComparer comp = new UserEqualityComparer();
            return comp.Equals(A, B);
        }

        public bool Equals(Users x, Users y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(Users obj)
        {
            throw new NotImplementedException();
        }
    }
}
