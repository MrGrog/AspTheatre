using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace Theatre_test
{
    public partial class _Default : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Visible==true && String.Equals(TextBox5.Text, TextBox4.Text))
            {
                using (TheatreEntitiesNew te = new TheatreEntitiesNew())
                {
                    Users us = new Users{ Name = TextBox1.Text, Surname = TextBox2.Text, Address = TextBox6.Text, Pin = TextBox5.Text, E_mail = TextBox3.Text, Type = false };
                    
                    te.Users.Add(us);
                    te.SaveChanges();

                    var users = te.Users.ToList();

                    Label7.Text = users[users.Count - 1].Name + " added";
                }

            }
            else if (TextBox1.Visible == true&&String.Equals(TextBox5.Text, TextBox4.Text) == false)
            {
                Label7.Text = "passwords not identical";
            }
            else
            {
                using (TheatreEntitiesNew te = new TheatreEntitiesNew())
                {
                    //var users = te.Users;
                    foreach (var u in te.Users)
                    {
                        if ((String.Equals(TextBox3.Text, u.E_mail) && String.Equals(TextBox4.Text, u.Pin)))
                        {
                            Label7.Text = String.Format("User: {0} name: {1}", u.E_mail, u.Name);

                            break;
                        }
                        else
                            Label7.Text = String.Format("acces denied. CHECK!!! your e-mail and password");

                    }
                }
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Visible == false)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
            }
            else
            {
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Actor
    {
        public int Actor_id { set; get; }
        public string Name_actor { set; get; }
        public string Surname_actor { set; get; }
        public string Exposition { set; get; }

    }
    public class User
    {
        public int User_id { set; get; }
        public string Name { set; get; }
        public string Surname { set; get; }
        public string Address { set; get; }
        public string Pin { set; get; }
        public string E_mail { set; get; }
        public bool Type { set; get; }
    }
    public class TheatreContext:DbContext
    {
        public TheatreContext():base ("TheatreConnectionString")
        { }

        public DbSet<Actor> Actors { set; get; }
        public DbSet<User> Users { set; get; }
    }
}