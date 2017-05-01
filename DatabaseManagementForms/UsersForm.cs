using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementForms
{
    public partial class UsersForm : Form
    {
        private IdeallyConnectedTestDbEntities _context; 
        private Users currentUser;

        public delegate void AssignRandomDates();

        public UsersForm()
        {
            InitializeComponent();
            _context = new IdeallyConnectedTestDbEntities();
            usersBindingSource.DataSource = _context.Users.ToList();
        }

        private void GetUserBindResults(string name)
        {
            usersBindingSource.DataSource = _context.Users.ToList()
                .FindAll(user => user.UserName == name || user.FirstName == name || user.LastName == name);
            currentUser = (Users)usersBindingSource.Current;
            Refresh();
        }

        private void GetUser_button_click(object sender, EventArgs e)
        {
            GetUserBindResults(FindUserTextbox.Text);
        }

        private void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            MessageBox.Show("Changes saved.");
        }

        private void SaveChanges_button_click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void AddUser_button_click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser(_context);
            
            DialogResult dialogResult = addUserForm.ShowDialog(this);
        }

        private void RetrieveAllUsers_button_Click(object sender, EventArgs e)
        {
            usersBindingSource.DataSource = _context.Users.ToList();
        }

        private void RandomCreateDates_button_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in UsersDataGrid.SelectedRows)
            {
                row.Cells["createdDataGridViewTextBoxColumn"].Value = UsersUtility.CreateRandomDates(1)[0];
            }
        }

        private void CreateCollaborators_button_Click(object sender, EventArgs e)
        {
            // Store the indexes representing the rows selected
            int totalUsersSelected = UsersDataGrid.SelectedRows.Count;
            List<int> selectedRowIndex = new List<int>(new int[UsersDataGrid.SelectedRows.Count]);;
            for(int i = 0; i < selectedRowIndex.Count; ++i)
            {
                selectedRowIndex[i] = UsersDataGrid.SelectedRows[i].Index;
            }

            _context.Collaborators.Load();
            Dictionary<string, Dictionary<string, bool>> collabChecker = new Dictionary<string, Dictionary<string, bool>>(_context.Collaborators.Count());
            foreach (Collaborators co in _context.Collaborators.Local)
            {
                if (!collabChecker.ContainsKey(co.UserA))
                    collabChecker.Add(co.UserA, new Dictionary<string, bool>() { { co.UserB, true } });
                else
                    collabChecker[co.UserA].Add(co.UserB, true);
            }

            List<Users> bindingUsers = (List<Users>)usersBindingSource.List;
            
            List<Collaborators> _collabs = new List<Collaborators>();
            _context.Configuration.AutoDetectChangesEnabled = false;
            // Create a collaboration between a user and the two (rows) after.
            for(int i = 0; i < selectedRowIndex.Count; ++i)
            {
                int j = i + 1;
                int userdataGridi = UsersDataGrid["userNameDataGridViewTextBoxColumn", i].ColumnIndex;
                int totalCollabsAdded = 0;
                for( ; j < selectedRowIndex.Count && j < i + 3 && j < UsersDataGrid.RowCount - 2; ++j)
                {
                    Collaborators collabs = new Collaborators();
                    string userNameA = (string)UsersDataGrid["userNameDataGridViewTextBoxColumn", i].Value;
                    collabs.Users = bindingUsers[i];
                    collabs.UserA = collabs.Users.Id;
                    string userNameB = (string)UsersDataGrid["userNameDataGridViewTextBoxColumn", j].Value;
                    collabs.Users1 = bindingUsers[j];
                    collabs.UserB = collabs.Users1.Id;
                    collabs.InitialCollaboration = DateTime.Now;
                    collabs.Initiated = true;
                    collabs.Following = true;

                    if (!collabChecker.ContainsKey(collabs.UserA) || !collabChecker[collabs.UserA].ContainsKey(collabs.UserB))
                    {
                        _context.Collaborators.Add(collabs);//_collabs.Add(collabs);
                        if (++totalCollabsAdded % 100  == 0)
                        {
                            _context.SaveChanges();
                        }
                    }
                }
                i = j - 1;
            }

            MessageBox.Show("Collaborators set!");
        }
    }
}
