using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Theatre_test.Models;

namespace Theatre_test.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            //if (TextBox1.Visible == true && String.Equals(TextBox5.Text, TextBox4.Text))
            //{
            //    using (TheatreEntitiesNew te = new TheatreEntitiesNew())
            //    {
            //        Users us = new Users { Name = TextBox1.Text, Surname = TextBox2.Text, Address = TextBox6.Text, Pin = TextBox5.Text, E_mail = TextBox3.Text, Type = false };

            //        te.Users.Add(us);
            //        te.SaveChanges();

            //        var users = te.Users.ToList();

            //        Label7.Text = users[users.Count - 1].Name + " added";
            //    }

            //}
            //else if (TextBox1.Visible == true && String.Equals(TextBox5.Text, TextBox4.Text) == false)
            //{
            //    Label7.Text = "passwords not identical";
            //}
            //else
            //{
                using (TheatreEntitiesNew te = new TheatreEntitiesNew())
                {
                    //var users = te.Users;
                    foreach (var u in te.Users)
                    {
                        if ((String.Equals(Email.Text, u.E_mail) && String.Equals(Password.Text, u.Pin)))
                        {
                        FailureText.Text = String.Format("User: {0} name: {1}", u.E_mail, u.Name);
                        ErrorMessage.Visible = true;
                        IdentityHelper.RedirectToReturnUrl(Request.QueryString["About"], Response);
                        break;
                        }
                        else
                        FailureText.Text = "Invalid login attempt";
                                ErrorMessage.Visible = true;
                                break;

                }

            }
            
        }
    }
}