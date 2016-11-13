using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Theatre_test.Account
{
    public partial class Admin : System.Web.UI.Page
    {

        int[] actorsList = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        protected void Page_Load(object sender, EventArgs e)
        {
            using (TheatreEntitiesNew te = new TheatreEntitiesNew())
            {
                var actors = te.Actors;
                foreach(var a in actors)
                {
                    ActorsCheck.Items.Add(String.Format("{0} {1}", a.Name_actor, a.Surname_actor));
                }
            }

        }
        protected void ClickAddSpectacle(object sender, EventArgs e)
        {
            using (TheatreEntitiesNew te = new TheatreEntitiesNew())
            {
                int i = 0;
                var actors = te.Actors;
                foreach (var su in ActorsCheck.Items)
                {
                    foreach (var a in actors)
                    {
                        if (su == ActorsCheck.SelectedItem&&su.ToString().Contains(a.Name_actor)&& su.ToString().Contains(a.Surname_actor))
                        {
                            actorsList[i]=a.Actor_id;
                            ++i;
                        }
                    }
                }
            }
                using (TheatreEntitiesNew te = new TheatreEntitiesNew())
            {
                Spectacles s = new Spectacles { Spectacle_name = TextBox1.Text, Exposition_sp = TextBox2.Text, Date_sp = Convert.ToDateTime(DateTimePicker1.Value), Actor1 = actorsList[0], Actor2 = actorsList[1], Actor3 = actorsList[2] , Actor4 = actorsList[3] , Actor5 = actorsList[4] , Actor6 = actorsList[5] , Actor7 = actorsList[6] , Actor8 = actorsList[7], Actor9 = actorsList[8], Actor10 = actorsList[9] };

                te.Spectacles.Add(s);
                te.SaveChanges();
                //
                //var sp = te.Spectacles;
                //message.Text = String.Format("spectacle {0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", s.Spectacle_name, s.Exposition_sp,s.Date_sp,s.Actor1,s.Actor2,s.Actor3,s.Actor4,s.Actor5,s.Actor6,s.Actor7,s.Actor8);
                message.Text = String.Format("spectacle {0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} ", TextBox1.Text, TextBox2.Text, DateTimePicker1.Value, actorsList[0], actorsList[1], actorsList[2], actorsList[3], actorsList[4], actorsList[5], actorsList[6], actorsList[7], actorsList[8], actorsList[9]);

            }

        }

    }
}