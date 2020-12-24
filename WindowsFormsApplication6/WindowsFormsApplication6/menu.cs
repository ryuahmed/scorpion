using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;


namespace WindowsFormsApplication6
{
    public partial class homepage : Form
    {
        private void menubar_load()
        {
            home.BackColor = over_controll.color_menubar_active;
            homepanel.BackColor = over_controll.color_active;
            homepanel.Visible = true;

            browse.BackColor = over_controll.color_menubar;
            browsepanel.BackColor = over_controll.color_active;
            browsepanel.Visible = false;

            trending.BackColor = over_controll.color_menubar;
            trendingpanel.BackColor = over_controll.color_active;
            trendingpanel.Visible = false;

            recomendation.BackColor = over_controll.color_menubar;
            recomendationpanel.BackColor = over_controll.color_active;
            recomendationpanel.Visible = false;

            comingsoon.BackColor = over_controll.color_menubar;
            comingsoonpanel.BackColor = over_controll.color_active;
            comingsoonpanel.Visible = false;

            profile.BackColor = over_controll.color_menubar;
            profilepanel.BackColor = over_controll.color_active;
            profilepanel.Visible = false;

            paln_menu.BackColor = over_controll.color_menubar;
            planpanel.BackColor = over_controll.color_active;
            planpanel.Visible = false;

            if (user_log_in.pos == "Guest")
            {
                paln_menu.BackColor = over_controll.color_menubar;
                planpanel.BackColor = Color.IndianRed;
                planpanel.Visible = true;

            }


            settings.BackColor = over_controll.color_menubar;
            settingspanel.BackColor = over_controll.color_active;
            settingspanel.Visible = false;
        }



    }
}
