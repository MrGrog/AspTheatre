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
                using (TheatreEntitiesNew te = new TheatreEntitiesNew())
                {
                var users = te.Users;
                foreach (var u in users)
                {
                    if ((String.Equals(Email.Text, u.E_mail) && String.Equals(Password.Text, u.Pin)) && u.Type == true)
                    {
                        FailureText.Text = String.Format("User: {0} type: {1}", u.E_mail, u.Type);
                        ErrorMessage.Visible = true;
                        //IdentityHelper.RedirectToReturnUrl(Request.QueryString["Admin"], Response);

                        Server.Transfer("Admin.aspx", true);
                        break;

                    }
                    else if((String.Equals(Email.Text, u.E_mail) && String.Equals(Password.Text, u.Pin)))
                    {
                        FailureText.Text = String.Format("User: {0} name: {1}", u.E_mail, u.Name);
                        ErrorMessage.Visible = true;
                        //IdentityHelper.RedirectToReturnUrl(Request.QueryString["Contact"], Response);
                        Server.Transfer("PlaceMarket.aspx", true);
                        Users temp = u;
                        break;
                    }
                    
                    else if (String.Equals(Email.Text, u.E_mail) || String.Equals(Password.Text, u.Pin))
                    {
                        FailureText.Text = "Invalid login attempt";
                        ErrorMessage.Visible = true;
                        break;
                    }

                    }

                }
        }
    }
}