using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
    }
}
