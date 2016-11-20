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
        static int[] actorsList = new int[] { 0 };

        protected void Page_Load(object sender, EventArgs e)
        {
            ActorsCheck.Items.Clear();
            using (TheatreEntitiesNew te = new TheatreEntitiesNew())
            {
                var actors = te.Actors;
                foreach(var a in actors)
                {
                    ActorsCheck.Items.Add(String.Format("{0} : {1} {2}", a.Actor_id, a.Name_actor, a.Surname_actor));
                }
            }

        }

       
        public static string AddSpectacleJS(string Spectacle_name, string Exposition_sp, DateTime Date_sp)
        {
            string respond = "not added";
            using (TheatreEntitiesNew te = new TheatreEntitiesNew())
            {

                var actors = te.Actors;

               
                Spectacles s = new Spectacles
                {
                    Spectacle_name = Spectacle_name,
                    Exposition_sp = Exposition_sp,
                    Date_sp = Date_sp,
                    Actor1 = actorsList[0],
                    Actor2 = actorsList[1],
                    Actor3 = actorsList[2],
                    Actor4 = actorsList[3],
                    Actor5 = actorsList[4],
                    Actor6 = actorsList[5],
                    Actor7 = actorsList[6],
                    Actor8 = actorsList[7],
                    Actor9 = actorsList[8],
                    Actor10 = actorsList[9]
                };

                te.Spectacles.Add(s);
                te.SaveChanges();
                 respond= String.Format("спектакль {0} доданий", s.Spectacle_name);
            }
            return respond;
        }
        protected void ClickAddSpectacle(object sender, EventArgs e)
        {
            using (TheatreEntitiesNew te = new TheatreEntitiesNew())
            {
                
                var actors = te.Actors;
                int n = 0;
                
                    for (int i = 0; i < ActorsCheck.Items.Count; ++i)
                    {
                        if (ActorsCheck.Items[i] == ActorsCheck.SelectedItem )
                        {
                            foreach (var a in actors)
                            {
                            if (ActorsCheck.Items[i].ToString().Contains(a.Name_actor) && ActorsCheck.Items[i].ToString().Contains(a.Surname_actor))
                            {
                                actorsList[n] = a.Actor_id;
                                message.Text += String.Format("актор доданий {0}",  actorsList[n].ToString());
                                ++n;
                            }
                            }
                        }
                    }
            
                Spectacles s = new Spectacles { Spectacle_name = TextBox1.Text,
                    Exposition_sp = TextBox2.Text,
                    Date_sp = Convert.ToDateTime(DateTimePicker1.Value),
                    Actor1 = actorsList[0],
                    Actor2 = actorsList[1],
                    Actor3 = actorsList[2] ,
                    Actor4 = actorsList[3] ,
                    Actor5 = actorsList[4] ,
                    Actor6 = actorsList[5] ,
                    Actor7 = actorsList[6] ,
                    Actor8 = actorsList[7],
                    Actor9 = actorsList[8],
                    Actor10 = actorsList[9] };

                te.Spectacles.Add(s);
                te.SaveChanges();
                //
                //var sp = te.Spectacles;
                //message.Text = String.Format("spectacle {0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", s.Spectacle_name, s.Exposition_sp,s.Date_sp,s.Actor1,s.Actor2,s.Actor3,s.Actor4,s.Actor5,s.Actor6,s.Actor7,s.Actor8);
                message.Text += String.Format("спектакль {0} доданий", s.Spectacle_name);

            }

        }

    }
}