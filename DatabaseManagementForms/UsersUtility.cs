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
        public static void CreateRandomUsers(CustomerTableAdapter customerTableAdapter, BindingSource bindingSource)
        {
            Random random = new Random();
            foreach (DataRow customer in customerTableAdapter.GetData().Rows)
            {
                Users newUser = new Users();
                newUser.Id = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
                newUser.FirstName = (string)customer["FirstName"];
                newUser.LastName = (string)customer["LastName"];
                newUser.UserName = newUser.FirstName + newUser.LastName + Convert.ToString(random.Next()).Substring(0, 5);
                newUser.PhoneNumber = (string)customer["Phone"];
                newUser.Email = (string)customer["EmailAddress"];
                newUser.Created = DateTime.Now;
                bindingSource.Add(newUser);
            } 
        }
    }
}
