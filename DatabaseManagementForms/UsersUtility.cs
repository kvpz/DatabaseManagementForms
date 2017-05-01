﻿using System;
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

        public static List<DateTime> CreateRandomDates(int amount)
        {
            List<DateTime> dates = new List<DateTime>(new DateTime[amount]);
            DateTime minDate = new DateTime(2012, 1, 1);
            DateTime maxDate = DateTime.Now;
            long elapsedTicks = maxDate.Ticks - minDate.Ticks;
            

            for(int i = 0; i < amount; ++i)
            {
                dates[i] = new DateTime(DateTime.Now.Ticks - (elapsedTicks / random.Next(1,100)));
            }

            return dates;
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
