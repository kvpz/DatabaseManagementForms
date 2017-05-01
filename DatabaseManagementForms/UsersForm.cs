using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementForms
{
    public partial class UsersForm : Form
    {
        private IdeallyConnectedTestDbEntities _context; 
        private Users currentUser;

        public UsersForm()
        {
            InitializeComponent();
            _context = new IdeallyConnectedTestDbEntities();
        }

        private void GetUserBindResults(string name)
        {
            List<Users> users = _context.Users.Where(u => u.FirstName == name).ToList();
            usersBindingSource.DataSource = users.First();
            
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
    }
}
