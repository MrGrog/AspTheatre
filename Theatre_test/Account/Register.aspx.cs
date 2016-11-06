using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Theatre_test.Models;

namespace Theatre_test.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            if (String.Equals(Password.Text, ConfirmPassword.Text))
            {
                using (TheatreEntitiesNew te = new TheatreEntitiesNew())
                {
                    Users us = new Users { Name = Name.Text, Surname = Surname.Text, Address = Address.Text, Pin = Password.Text, E_mail = Email.Text, Type = false };

                    te.Users.Add(us);
                    te.SaveChanges();

                    var users = te.Users.ToList();

                    ErrorMessage.Text = users[users.Count - 1].Name + " added";
                }

            }
            else 
            {
                ErrorMessage.Text = "passwords not equals";
            }
        }
    }
}