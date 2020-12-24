using System;
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
        private List<string> cover_name = new List<string>();
        private List<string> cover_id = new List<string>();
        private int cover_i = 0;
        private int cover_n;
        private bool searchcheck = false;
        private PictureBox slideshow;
        private BackgroundWorker bw;

        public homepage()
        {
            InitializeComponent();
            this.bw = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void homepage_Load(object sender, EventArgs e)
        {
           // over_controll.active_panel = homepage_panel;
           // homepage_panel.BackColor = over_controll.color_background;
            get_info();
            get_media();
            get_user();
            check_user();
            log_in();
            menubar_load();
            pictureBox2.Image = new Bitmap(user_log_in.dp);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            creat_homepage();
            this.searchbar.SelectionStart = this.searchbar.Text.Length;
            this.searchbar.DeselectAll();
        }
        private void log_in()
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string s = "SELECT count(*) as no FROM `log_in`";
            string id = "l" + count(s) + RandomString(5);
            string query = "INSERT INTO `log_in` (`login_id`, `u_id`, `date_time`) VALUES ('"+id+"', '"+user_log_in.UserID+"', '" + date + "')";
            insert(query);
        }

        private void add_test()
        {
            Panel a = new Panel()
            {
                Name = "body_panel",
                Size = new Size(100, 100),
                //Location = new Point(214, 21),
                BackColor = Color.Red,
                BorderStyle = BorderStyle.None,
               // AutoScroll = true,
            };
            over_controll.active_panel.Controls.Add(a);
            // over_controll.active_panel = a;
        }
        private void body_panel()
        {

            FlowLayoutPanel body_panel = new FlowLayoutPanel()
            {
                Name = "body_panel",
                Size = new Size(over_controll.body_size_x, over_controll.body_size_y),
                Location = new Point(214, 29),
                BackColor =over_controll.color_background,
                BorderStyle = BorderStyle.None,
                AutoScroll = true,
            };
            this.Controls.Add(body_panel);
            over_controll.active_panel = body_panel;
            //body_panel.AutoSize = true;
            //body_panel.MaximumSize = new Size(0,0);
        }
        private void add_footer()
        {
            Panel panel1 = new Panel()
            {
                Name = "footer",
                Size = new Size(over_controll.av_body_size_x, 100),
                //  Location = new Point(0, ly),
                BackColor = Color.FromArgb(17, 22, 30),
            };
            over_controll.active_panel.Controls.Add(panel1);
        }


        private Panel add_header_panel()
        {
            Panel text_panel = new Panel()
            {
                Name = "text_panel",
                Size = new Size(over_controll.av_body_size_x - 20, 50),
                //Location = new Point(214, 21),
                BackColor = over_controll.color_background,
                BorderStyle = BorderStyle.None,
                // AutoScroll = true,
            };

            over_controll.active_panel.Controls.Add(text_panel);
            return text_panel;
        }

        private Panel add_poster_panel()
        {
            FlowLayoutPanel poster_panel = new FlowLayoutPanel()
            {
                Name = "poster_panel",
                Size = new Size(over_controll.av_body_size_x - 20, 260),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                // AutoScroll = true,
            };

            over_controll.active_panel.Controls.Add(poster_panel);

            return poster_panel;
        }

 

        private void add(int i, int n, int sx, int sy, int lx, int ly, string[,] path)
        {
            for (int j = 0; j < n; j++)
            {
                Panel panel = new Panel()
                {
                    Name = path[j, 1],
                    Size = new Size(sx, sy),
                    //Location = new Point(lx, ly),
                    BackColor = Color.Transparent,
                };

                over_controll.active_panel.Controls.Add(panel);

                panel.BringToFront();
                panel.Click += new EventHandler(contentpanel_click);
                panel.MouseHover += new EventHandler(contentpanel_hover);
                panel.MouseLeave += new EventHandler(contentpanel_leave);

                var pic = new PictureBox()
                {
                    Name = path[j, 1],
                    Size = new Size(sx - 10, sy - 40),
                    Location = new Point(5, 5),
                    Parent = panel,
                    Anchor = (AnchorStyles.None),

                };
                panel.Controls.Add(pic);
                pic.BringToFront();

                pic.Click += new EventHandler(contentpic_click);
                pic.MouseHover += new EventHandler(contentpic_hover);
                pic.MouseLeave += new EventHandler(contentpic_leave);

                Panel panel_over_pic = new Panel()
                {
                    Name = path[j, 1],
                    Size = new Size(sx - 10, sy - 40),
                    Location = new Point(0, 0),
                    Parent = pic,
                    BackColor = Color.Transparent,
                };

                pic.Controls.Add(panel_over_pic);
                panel_over_pic.BringToFront();
                panel_over_pic.Click += new EventHandler(panel_over_pic_click);
                panel_over_pic.MouseHover += new EventHandler(panel_over_pic_hover);
                panel_over_pic.MouseLeave += new EventHandler(panel_over_pic_leave);


                int k = 0;
                int kx = 10;
                while (true)
                {
                    Label gen = new Label()
                    {
                        Name = i.ToString(),
                        Text = "action",
                        Location = new Point(kx, 220),
                        Font = new Font("Neuropolitical", 8, FontStyle.Regular),
                        Size = new Size(50, 20),
                        Parent = pic,
                        BackColor = Color.Transparent,
                        ForeColor = Color.FromArgb(0, 10, 30),

                    };

                    panel.Controls.Add(gen);
                    gen.BringToFront();
                    if (k == 2)                                                          //print 3
                        break;
                    Label slash = new Label()
                    {
                        Name = i.ToString(),
                        Text = "|",
                        Location = new Point(kx + 41, 220),
                        Font = new Font("Neuropolitical", 8, FontStyle.Regular),
                        Size = new Size(50, 20),
                        Parent = gen,
                        BackColor = Color.Transparent,
                        ForeColor = Color.FromArgb(0, 10, 30),

                    };
                    panel.Controls.Add(slash);
                    slash.BringToFront();
                    k++;
                    kx = kx + 46;

                    /*Panel panel1 = new Panel()
                    {
                        Name = i * 10 + j.ToString(),
                        Size = new Size(sx - 10, sy - 40),
                        Location = new Point(0, 0),
                        BackColor = Color.FromArgb(50,200, 200, 200),
                        Parent = pic,
                    };

                    pic.Controls.Add(panel1);
                    panel1.Visible = false;
                    panel1.BringToFront();*/

                }


                // MessageBox.Show(path[j,1]);

                pic.Image = new Bitmap(path[j, 0]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                lx = lx + sx + 40;

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


        }



        private void id_Click(object sender, EventArgs e)
        {
            if (usermenu.Visible == false)
                usermenu.Visible = true;
            else
                usermenu.Visible = false;
        }



        private void userdock_Click(object sender, EventArgs e)
        {
            if (usermenu.Visible == false)
                usermenu.Visible = true;
            else
                usermenu.Visible = false; 
        }

        private void userdock_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (usermenu.Visible == false)
                usermenu.Visible = true;
            else
                usermenu.Visible = false;
        }

        private void prfile_MouseHover(object sender, EventArgs e)
        {
            prfile.BackColor = Color.FromArgb(35, 35, 35);

        }

        private void prfile_MouseLeave(object sender, EventArgs e)
        {
            prfile.BackColor = Color.FromArgb(30, 30, 30);

        }

        private void account_MouseHover(object sender, EventArgs e)
        {
            Noti.BackColor = Color.FromArgb(35, 35, 35);

        }

        private void account_MouseLeave(object sender, EventArgs e)
        {
            Noti.BackColor = Color.FromArgb(30, 30, 30);

        }

        private void settings_MouseHover(object sender, EventArgs e)
        {
            settings.BackColor = Color.FromArgb(35, 35, 35);

        }

        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.BackColor = Color.FromArgb(30, 30, 30);

        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            logout.BackColor = Color.FromArgb(100, 0, 0);

        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.BackColor = Color.FromArgb(30, 30, 30);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gradient_panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usermenu_VisibleChanged(object sender, EventArgs e)
        {
            usermenu.BringToFront();
        }



        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cover_i++;
            cover_show();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            if(searchcheck==false)
            {
                searchbar.Clear();
                searchcheck = true; 
            }

            searchpanel.BackColor = Color.FromArgb(247, 148, 29);

        }

        private void gradient_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradient_panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                over_controll.start_center = false; 
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                over_controll.x = this.Left;
                over_controll.y = this.Top; 
            }


        }

        Point lastPoint;

        private void gradient_panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void home_MouseHover(object sender, EventArgs e)
        {
            if(homepanel.Visible==false)
            {
                home.BackColor = over_controll.color_menubar_hover;
            }
        }

        private void home_MouseLeave(object sender, EventArgs e)
        {
            if (homepanel.Visible == false)
            {
                home.BackColor = over_controll.color_menubar;
            }
        }
        private void home_Click(object sender, EventArgs e)
        {
            home_go_to();
        }
        private void home_go_to()
        {
            Control temp = over_controll.active_panel;
            creat_homepage();
            temp.Dispose();


            homepanel.Visible = true;
            browsepanel.Visible = false;
            trendingpanel.Visible = false;
            recomendationpanel.Visible = false;
            comingsoonpanel.Visible = false;
            profilepanel.Visible = false;
            planpanel.Visible = false;
            settingspanel.Visible = false;

            home.BackColor = over_controll.color_menubar_active;
            browse.BackColor = over_controll.color_menubar;
            trending.BackColor = over_controll.color_menubar;
            recomendation.BackColor = over_controll.color_menubar;
            comingsoon.BackColor = over_controll.color_menubar;
            profile.BackColor = over_controll.color_menubar;
            paln_menu.BackColor = over_controll.color_menubar;
            settings.BackColor = over_controll.color_menubar;
        }
        private void browse_MouseHover(object sender, EventArgs e)
        {
            if (browsepanel.Visible == false)
            {
                browse.BackColor = over_controll.color_menubar_hover;
            }
        }

        private void browse_MouseLeave(object sender, EventArgs e)
        {
            if (browsepanel.Visible == false)
            {
                browse.BackColor = over_controll.color_menubar;
            }
        }



        private void browse_Click(object sender, EventArgs e)
        {
            //backgroundWorker1.CancelAsync();
            //MessageBox.Show("aaaaaaaaa");
            // backgroundWorker1.RunWorkerAsync();
            // over_controll.active_panel.Visible = false;

            go_to("Browse","");


            homepanel.Visible = false;
            browsepanel.Visible = true;
            trendingpanel.Visible = false;
            recomendationpanel.Visible = false;
            comingsoonpanel.Visible = false;
            profilepanel.Visible = false;
            planpanel.Visible = false;
            settingspanel.Visible = false;


            home.BackColor = over_controll.color_menubar;
            browse.BackColor = over_controll.color_menubar_active;
            trending.BackColor = over_controll.color_menubar;
            recomendation.BackColor = over_controll.color_menubar;
            comingsoon.BackColor = over_controll.color_menubar;
            profile.BackColor = over_controll.color_menubar;
            paln_menu.BackColor = over_controll.color_menubar;
            settings.BackColor = over_controll.color_menubar;
        }

        private void trending_MouseHover(object sender, EventArgs e)
        {
            if (trendingpanel.Visible == false)
            {
                trending.BackColor = over_controll.color_menubar_hover;
            }
        }

        private void trending_MouseLeave(object sender, EventArgs e)
        {
            if (trendingpanel.Visible == false)
            {
                trending.BackColor = over_controll.color_menubar;
            }
        }

        private void trending_Click(object sender, EventArgs e)
        {
            go_to("Trending","");


            homepanel.Visible = false;
            browsepanel.Visible = false;
            trendingpanel.Visible = true;
            recomendationpanel.Visible = false;
            comingsoonpanel.Visible = false;
            profilepanel.Visible = false;
            planpanel.Visible = false;
            settingspanel.Visible = false;


            home.BackColor = over_controll.color_menubar;
            browse.BackColor = over_controll.color_menubar;
            trending.BackColor = over_controll.color_menubar_active;
            recomendation.BackColor = over_controll.color_menubar;
            comingsoon.BackColor = over_controll.color_menubar;
            profile.BackColor = over_controll.color_menubar;
            paln_menu.BackColor = over_controll.color_menubar;
            setting.BackColor = over_controll.color_menubar;
        }

        private void recomendation_MouseHover(object sender, EventArgs e)
        {
            if (recomendationpanel.Visible == false)
            {
                recomendation.BackColor = over_controll.color_menubar_hover;
            }
        }

        private void recomendation_MouseLeave(object sender, EventArgs e)
        {
            if (recomendationpanel.Visible == false)
            {
                recomendation.BackColor = over_controll.color_menubar;
            }
        }

        private void recomendation_Click(object sender, EventArgs e)
        {
            go_to("Recomendation","");

            homepanel.Visible = false;
            browsepanel.Visible = false;
            trendingpanel.Visible = false;
            recomendationpanel.Visible = true;
            comingsoonpanel.Visible = false;
            profilepanel.Visible = false;
            planpanel.Visible = false;
            settingspanel.Visible = false;


            home.BackColor = over_controll.color_menubar;
            browse.BackColor = over_controll.color_menubar;
            trending.BackColor = over_controll.color_menubar;
            recomendation.BackColor = over_controll.color_menubar_active;
            comingsoon.BackColor = over_controll.color_menubar;
            profile.BackColor = over_controll.color_menubar;
            paln_menu.BackColor = over_controll.color_menubar;
            setting.BackColor = over_controll.color_menubar;
        }

        private void comingsoon_MouseHover(object sender, EventArgs e)
        {
            if (comingsoonpanel.Visible == false)
            {
                comingsoon.BackColor = over_controll.color_menubar_hover;
            }
        }

        private void comingsoon_MouseLeave(object sender, EventArgs e)
        {
            if (comingsoonpanel.Visible == false)
            {
                comingsoon.BackColor = over_controll.color_menubar;
            }
        }

        private void comingsoon_Click(object sender, EventArgs e)
        {
            go_to("Coming Soon","");


            homepanel.Visible = false;
            browsepanel.Visible = false;
            trendingpanel.Visible = false;
            recomendationpanel.Visible = false;
            comingsoonpanel.Visible = true;
            profilepanel.Visible = false;
            planpanel.Visible = false;
            settingspanel.Visible = false;


            home.BackColor = over_controll.color_menubar;
            browse.BackColor = over_controll.color_menubar;
            trending.BackColor = over_controll.color_menubar;
            recomendation.BackColor = over_controll.color_menubar;
            comingsoon.BackColor = over_controll.color_menubar_active;
            profile.BackColor = over_controll.color_menubar;
            paln_menu.BackColor = over_controll.color_menubar;
            setting.BackColor = over_controll.color_menubar;
        }

        private void profile_MouseHover(object sender, EventArgs e)
        {
            if (profilepanel.Visible == false)
            {
                profile.BackColor = over_controll.color_menubar_hover;
            }
        }

        private void profile_MouseLeave(object sender, EventArgs e)
        {
            if (profilepanel.Visible == false)
            {
                profile.BackColor = over_controll.color_menubar;
            }
        }

        private void profile_Click(object sender, EventArgs e)
        {
            go_to_profile();
        }

        private void go_to_profile()
        {
            go_to("profile", "");

            homepanel.Visible = false;
            browsepanel.Visible = false;
            trendingpanel.Visible = false;
            recomendationpanel.Visible = false;
            comingsoonpanel.Visible = false;
            profilepanel.Visible = true;
            planpanel.Visible = false;
            settingspanel.Visible = false;


            home.BackColor = over_controll.color_menubar;
            browse.BackColor = over_controll.color_menubar;
            trending.BackColor = over_controll.color_menubar;
            recomendation.BackColor = over_controll.color_menubar;
            comingsoon.BackColor = over_controll.color_menubar;
            profile.BackColor = over_controll.color_menubar_active;
            paln_menu.BackColor = over_controll.color_menubar;
            setting.BackColor = over_controll.color_menubar;
        }

        private void paln_menu_MouseHover(object sender, EventArgs e)
        {
            if (planpanel.Visible == false)
            {
                paln_menu.BackColor = over_controll.color_menubar_hover;
            }
        }

        private void paln_menu_MouseLeave(object sender, EventArgs e)
        {
            if (planpanel.Visible == false)
            {
                paln_menu.BackColor = over_controll.color_menubar;
            }
        }

        private void paln_menu_Click(object sender, EventArgs e)
        {
            go_to("plan", "");

            homepanel.Visible = false;
            browsepanel.Visible = false;
            trendingpanel.Visible = false;
            recomendationpanel.Visible = false;
            comingsoonpanel.Visible = false;
            profilepanel.Visible = false;
            planpanel.Visible = true;
            settingspanel.Visible = false;


            home.BackColor = over_controll.color_menubar;
            browse.BackColor = over_controll.color_menubar;
            trending.BackColor = over_controll.color_menubar;
            recomendation.BackColor = over_controll.color_menubar;
            comingsoon.BackColor = over_controll.color_menubar;
            profile.BackColor = over_controll.color_menubar;
            paln_menu.BackColor = over_controll.color_menubar_active;
            setting.BackColor = over_controll.color_menubar;
        }

        private void setting_MouseHover(object sender, EventArgs e)
        {
            if (settingspanel.Visible == false)
            {
                setting.BackColor = over_controll.color_menubar_hover;
            }

        }

        private void setting_MouseLeave(object sender, EventArgs e)
        {
            if (settingspanel.Visible == false)
            {
                setting.BackColor = over_controll.color_menubar;
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            homepanel.Visible = false;
            browsepanel.Visible = false;
            trendingpanel.Visible = false;
            recomendationpanel.Visible = false;
            comingsoonpanel.Visible = false;
            profilepanel.Visible = false;
            planpanel.Visible = false;
            settingspanel.Visible = true;


            home.BackColor = over_controll.color_menubar;
            browse.BackColor = over_controll.color_menubar;
            trending.BackColor = over_controll.color_menubar;
            recomendation.BackColor = over_controll.color_menubar;
            comingsoon.BackColor = over_controll.color_menubar;
            profile.BackColor = over_controll.color_menubar;
            paln_menu.BackColor = over_controll.color_menubar;
            setting.BackColor = over_controll.color_menubar_active;
        }

        private void searchbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                homepanel.Visible = false;
                browsepanel.Visible = false;
                trendingpanel.Visible = false;
                recomendationpanel.Visible = false;
                comingsoonpanel.Visible = false;
                profilepanel.Visible = false;
                planpanel.Visible = false;
                settingspanel.Visible = false;


                home.BackColor = over_controll.color_menubar;
                browse.BackColor = over_controll.color_menubar;
                trending.BackColor = over_controll.color_menubar;
                recomendation.BackColor = over_controll.color_menubar;
                comingsoon.BackColor = over_controll.color_menubar;
                profile.BackColor = over_controll.color_menubar;
                paln_menu.BackColor = over_controll.color_menubar;
                setting.BackColor = over_controll.color_menubar;

                go_to("Search", "");

            }
        }

        private void adminicon_DoubleClick(object sender, EventArgs e)
        {

        }

        private void adminicon_Click(object sender, EventArgs e)
        {
            homepanel.Visible = false;
            browsepanel.Visible = false;
            trendingpanel.Visible = false;
            recomendationpanel.Visible = false;
            comingsoonpanel.Visible = false;
            profilepanel.Visible = false;
            planpanel.Visible = false;
            settingspanel.Visible = false;


            home.BackColor = over_controll.color_menubar;
            browse.BackColor = over_controll.color_menubar;
            trending.BackColor = over_controll.color_menubar;
            recomendation.BackColor = over_controll.color_menubar;
            comingsoon.BackColor = over_controll.color_menubar;
            profile.BackColor = over_controll.color_menubar;
            paln_menu.BackColor = over_controll.color_menubar;
            setting.BackColor = over_controll.color_menubar;

            go_to("Admin Panel","");
        }

        private void go_to(string key,string id)
        {
            over_controll.temp = over_controll.active_panel;
            if (key == "Admin Panel")
            {
                creat_admin();
            }
            if (key == "Recomendation")
            {
                get_recent_added();

                create_search_result(@"D:\media\a.jpg", "Recomendation");
            }
            if (key == "Trending")
            {
                get_trending();
                create_search_result(@"D:\media\a.jpg", "Trending");

            }
            if (key == "Browse")
            {
                get_recent_added();
               // MessageBox.Show("asdad");
                create_search_result(@"D:\media\a.jpg", "Browse");

            }
            if (key== "Coming Soon")
            {
                get_coming();
                create_search_result(@"D:\media\a.jpg", "Coming Soon");
            }
            if(key=="content")
            {
                creat_content_profile(id);
            }

            if(key=="Search")
            {
                create_search_result(@"C:\Users\baka\Desktop\a.jpg", "Result");

            }

            if (key == "profile")
            {
                create_profile(user_log_in.UserID);
            }
            if (key == "plan")
            {
                create_plan();
            }

            over_controll.temp.Dispose();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            user_log_in.logout(this);
        }

        private void guest_active_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prfile_Click(object sender, EventArgs e)
        {
            go_to_profile();
        }
    }
}
