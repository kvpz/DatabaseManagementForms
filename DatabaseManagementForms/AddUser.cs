using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DatabaseManagementForms
{
    public partial class AddUser : Form
    {
        private AdventureWorksLT2008R2DataSetTableAdapters.CustomerTableAdapter customerTableAdapter { get; set; }
        private IdeallyConnectedTestDbEntities _context;
        private ContextMenuStrip _contextMenuStrip;

        public AddUser()
        {
            AddUser_toolStrip_delete = new ToolStripMenuItem();
            _contextMenuStrip = new ContextMenuStrip();
            _contextMenuStrip.Items.Add(AddUser_toolStrip_delete);
            AddUser_contextMenuStrip = _contextMenuStrip; 
            InitializeComponent();
        }

        public AddUser(IdeallyConnectedTestDbEntities ctx) : this()
        {
            _context = ctx;
            customerTableAdapter = new AdventureWorksLT2008R2DataSetTableAdapters.CustomerTableAdapter();
        }

        public Users CreateRandomUser()
        {
            Random random = new Random();
            Users newUser = new Users();
            DataRow customer = customerTableAdapter.GetData().Rows[(random.Next() + customerTableAdapter.GetData().Count) % customerTableAdapter.GetData().Count];
            newUser.Id = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            newUser.FirstName = (string)customer["FirstName"];
            newUser.LastName = (string)customer["LastName"];
            newUser.UserName = newUser.FirstName + newUser.LastName;
            newUser.PhoneNumber = (string)customer["Phone"];
            newUser.Email = (string)customer["EmailAddress"];
            newUser.Created = DateTime.Now;

            return newUser;
        }



        private void CreateRandomUser_Click(object sender, EventArgs e)
        {
            Users newUser = CreateRandomUser();
            usersBindingSource.DataSource = newUser;
            _context.Users.Add(newUser);
            Refresh();
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException exception)
            {
                MessageBox.Show(exception.Message);
            }

            MessageBox.Show("Users added.");
        }

        private void BulkCreateRandomUsers_button_Click(object sender, EventArgs e)
        {
            UsersUtility.CreateRandomUsers(customerTableAdapter, usersBindingSource);
            Refresh();
        }

        private void AddUsersToContext()
        {
           
            foreach (Users user in usersBindingSource.List)
            {
                _context.Users.AddOrUpdate(user);
            }
        
        }
    }
}
