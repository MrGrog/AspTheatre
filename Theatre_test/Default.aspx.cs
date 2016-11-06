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