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
        private void creat_admin()
        {
            body_panel();
            Panel a = (Panel)over_controll.active_panel;
            a.AutoScroll = false;
            //over_controll.active_panel.
            submenu();
            submenucontainer();
            creat_admin_user_sub();
        }
        private void submenucontainer()
        {
            Panel subbody = new Panel()
            {
                Name = "body_panel",
                Size = new Size(over_controll.av_body_size_x-190, 690),
                BackColor = over_controll.color_background,
                BorderStyle = BorderStyle.None,
                AutoScroll = false,
                Padding = new Padding(0),

            };
            over_controll.active_panel.Controls.Add(subbody);
            over_controll.active_sub_body = subbody;
        }


        private void submenu()
        {
            Panel submenu = new Panel()
            {
                Size = new Size(200, 701),
                BackColor = Color.FromArgb(55, 60, 70),
            };
            over_controll.active_panel.Controls.Add(submenu);

            int n = 5, y = 0;
            string[] submenu_bottom = new string[] { "User", "Homepage", "Upload", "Promote", "Plan" };

            for (int i = 0; i < n; i++)
            {
                Label label = new Label()
                {
                    Name = submenu_bottom[i],
                    Text = submenu_bottom[i],
                    Location = new Point(0, y),
                    Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                    Size = new Size(200, 40),
                    BackColor = Color.Transparent,
                    ForeColor = Color.FromArgb(180, 180, 180),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,

                };
                if (i == 0)
                {
                    over_controll.active_submenu = label;
                    label.ForeColor = Color.FromArgb(247, 148, 29);
                    label.BackColor = Color.FromArgb(45, 45, 50);
                }
                submenu.Controls.Add(label);
                label.BringToFront();

                label.Click += new EventHandler(submenu_click);
                label.MouseHover += new EventHandler(submenu_hover);
                label.MouseLeave += new EventHandler(submenu_leave);
                y = y + 40;
            }
        }

        protected void submenu_click(object sender, EventArgs e)
        {
            over_controll.active_submenu.ForeColor = Color.FromArgb(180, 180, 180);
            over_controll.active_submenu.BackColor = Color.Transparent;

            Control sub = (Label)sender;
            over_controll.active_submenu = sub;
            over_controll.active_submenu.ForeColor = Color.FromArgb(247, 148, 29);
            over_controll.active_submenu.BackColor = Color.FromArgb(45, 45, 50);


            over_controll.temp = over_controll.active_sub_body;
            submenucontainer();

            if (over_controll.active_submenu.Name.ToString() == "User")
            {
                creat_admin_user_sub();
            }
            if (over_controll.active_submenu.Name.ToString() == "Homepage")
            {
                create_modi_home_sub();
            }
            if (over_controll.active_submenu.Name.ToString() == "Upload")
            {
                create_up_sub();
            }
            if (over_controll.active_submenu.Name.ToString() == "Promote")
            {
                create_promo_sub();
            }
            if (over_controll.active_submenu.Name.ToString() == "Plan")
            {
                create_plan_sub();
            }




            over_controll.temp.Dispose();



        }
        protected void submenu_hover(object sender, EventArgs e)
        {

            Control sub = (Label)sender;
            sub.ForeColor = Color.FromArgb(247, 148, 29);



        }
        protected void submenu_leave(object sender, EventArgs e)
        {
            Control sub = (Label)sender;
            if (over_controll.active_submenu != sub)
            {
                sub.ForeColor = Color.FromArgb(180, 180, 180);
            }

        }

        private void header (string s )
        {
            Label label = new Label()
            {
                Name = s,
                Text = s,
                Location = new Point(20, 20),
                Font = new Font("Neuropolitical", 20, FontStyle.Bold),
                Size = new Size(500, 40),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(37, 41, 48),
                AutoSize = false,

            };
            over_controll.active_sub_body.Controls.Add(label);
            label.BringToFront();

            Panel line = new Panel()
            {
                Name = "line",
                Size = new Size(1210 - 222 - 80, 2),
                Location = new Point(20, 60),
                BackColor = Color.FromArgb(37, 41, 48),
                BorderStyle = BorderStyle.None,
            };

            over_controll.active_sub_body.Controls.Add(line);
            line.BringToFront();
        }

        private void creat_admin_user_sub()
        {
            header("Add Staff"); 

            Label New = new Label()
            {
                Name = "New User",
                Text = "New User",
                Location = new Point(20, 120),
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                Size = new Size(130, 35),
                BackColor = Color.FromArgb(150, 150, 150),
                ForeColor = Color.FromArgb(37, 41, 48),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = over_controll.active_sub_body,

            };
            over_controll.active_sub_body.Controls.Add(New);
            New.BringToFront();
            New.Click += new EventHandler(user_click);
            New.MouseHover += new EventHandler(user_hover);
            New.MouseLeave += new EventHandler(user_leave);

            Panel line2 = new Panel()
            {
                Name = "line2",
                Size = new Size(130, 4),
                Location = new Point(0, 31),
                BackColor = over_controll.color_active,
                BorderStyle = BorderStyle.None,
                Parent = New,
            };

            New.Controls.Add(line2);
            line2.BringToFront();           

            Label existing = new Label()
            {
                Name = "Existing",
                Text = "Existing User",
                Location = new Point(150, 120),
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                Size = new Size(170, 35),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(37, 41, 48),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = over_controll.active_sub_body,


            };
            over_controll.active_sub_body.Controls.Add(existing);
            existing.BringToFront();
            existing.Click += new EventHandler(user_click);
            existing.MouseHover += new EventHandler(user_hover);
            existing.MouseLeave += new EventHandler(user_leave);

            Panel line3 = new Panel()
            {
                Name = "line3",
                Size = new Size(170, 4),
                Location = new Point(0, 31),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Parent = existing,

            };

            existing.Controls.Add(line3);
            line3.BringToFront();

            Panel line4 = new Panel()
            {
                Name = "line4",
                Size = new Size(400, 1),
                Location = new Point(20, 155),
                BackColor = Color.FromArgb(37, 41, 48),
                BorderStyle = BorderStyle.None,
                Parent = New,

            };

            over_controll.active_sub_body.Controls.Add(line4);
            line4.BringToFront();

            over_controll.active_user = New;

            TextBox input = new TextBox()
            {
                Name = "input",
                Text = "Enter Email",
                Size = new Size(200, 100),
                BackColor = over_controll.color_background,
                Location = new Point(50, 200),
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(200, 200, 200),
                BorderStyle =BorderStyle.None,

            };
            over_controll.active_sub_body.Controls.Add(input);

            input.Click += new EventHandler(input_click);
            input.TextChanged+= new EventHandler(input_change);

            Panel line5 = new Panel()
            {
                Name = "line5",
                Size = new Size(200, 1),
                Location = new Point(50, 235),
                BackColor = Color.FromArgb(37, 41, 48),
                BorderStyle = BorderStyle.None,
            };
            over_controll.active_sub_body.Controls.Add(line5);
            line5.BringToFront();

            Label reset = new Label()
            {
                Name = "reset",
                Text = "Reset",
                Location = new Point(50, 245),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(60, 25),
                BackColor = Color.IndianRed,
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(reset);
            reset.Click += new EventHandler(bottom_click);
            reset.MouseHover += new EventHandler(bottom_hover);
            reset.MouseLeave += new EventHandler(bottom_leave);

            Label add = new Label()
            {
                Name = "add",
                Text = "Add Staff",
                Location = new Point(115, 245),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(135, 25),
                BackColor = Color.FromArgb(247, 177,74),
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(add);
            add.Click += new EventHandler(bottom_click);
            add.MouseHover += new EventHandler(bottom_hover);
            add.MouseLeave += new EventHandler(bottom_leave);

        }

        protected void user_click(object sender, EventArgs e)
        {
            Control user = (Control)sender;
            if (user.BackColor != Color.FromArgb(150, 150, 150))
            {
                user.BackColor = Color.FromArgb(150, 150, 150);
                Control line = user.Controls[0];
                //MessageBox.Show();
                line.BackColor = over_controll.color_active;
            }


            over_controll.active_user.BackColor = Color.Transparent;
            over_controll.active_user.Controls[0].BackColor = Color.Transparent;        
            over_controll.active_user = user;

            if (user.Name.ToString() == "Movie")
            {
                upload.type = 0; 
                change_content_type(false);

            }
            if (user.Name.ToString() == "Series")
            {
                upload.type = 1;
                change_content_type(true);
            }

            foreach (Control change in over_controll.active_sub_body.Controls )
            {
                if(change.Name== "line5")
                {
                    change.BackColor = Color.FromArgb(37, 41, 48);
                }
                if (change.Name == "input")
                {
                    if (user.Name == "New User")
                    {
                        change.Text = "Enter Email";
                    }
                    if (user.Name == "Existing")
                    {
                        change.Text = "Enter Username";
                    }

                    change.ForeColor = Color.FromArgb(200, 200, 200);
                }
                if (change.Name == "add")
                {
                    if (user.Name == "New User")
                    {
                        change.Text = "Add Staff";
                    }
                    if (user.Name == "Existing")
                    {
                        change.Text = "Add to Staff";
                    }
                }
                if (change.Name == "error")
                {
                    change.Hide();
                }
            }

        }
        protected void user_hover(object sender, EventArgs e)
        {
            Control hov = (Control)sender;
            if (hov != over_controll.active_user)
            {
                hov.BackColor = Color.FromArgb(200, 200, 200);

            }

        }
        protected void user_leave(object sender, EventArgs e)
        {
            Control hov = (Control)sender;
            if (hov != over_controll.active_user)
            {
                hov.BackColor = Color.Transparent;

            }
        }

        protected void input_click(object sender, EventArgs e)
        {
            Control text = (Control)sender;
            if (text.Text.ToString() == "Enter Email" || text.Text.ToString() == "Enter Username")
            {
                text.Text = "";
            }
            text.ForeColor = Color.FromArgb(17, 22, 30);
            foreach (Control change in over_controll.active_sub_body.Controls)
            {
                if (change.Name == "line5")
                {
                    change.BackColor = over_controll.color_active;
                }
            }

        }
        protected void input_change(object sender, EventArgs e)
        {

            Control inbox = (Control)sender;
            string s = inbox.Text.ToString();
 
            for(int i=1; i<=5; i++)
            {
                delete_sugge("sugge" + i.ToString());
            }

            if (inbox.Text== "Enter Email" || inbox.Text == "Enter Username")
            {
                return; 
            }

            else if(s.Length < 3 && s.Length >= 0)
            {
                add_suggestion_label(1, 200, "input few more character");
            }
            else
            {
                string sugg = "SELECT user_name FROM `user` where User_name  like '%"+s+"%'" ;
                //MessageBox.Show(sugg);
                List<string> res = result(sugg, "user_name");

                int y = 200;
                int i = 0; 

                int c = 1; 
                foreach(string sugge in res)
                {
                    if(i==5)
                    {
                        break; 
                    }
                    //MessageBox.Show(sugge);
                    add_suggestion_label(c,y, sugge);
                    y = y + 30;
                    i++;
                    c++; 
                }

            }

        }
        protected void bottom_click(object sender, EventArgs e)
        {
            Control bottom = (Control)sender;

            if (bottom.Name == "add")
            {
                foreach (Control change in over_controll.active_sub_body.Controls)
                {
 
                    if (change.Name == "input")
                    {
                        if (over_controll.active_user.Name == "New User")
                        {
                            add_staff(change.Text.ToString());
                        }
                        if (over_controll.active_user.Name == "Existing")
                        {
                            add_to_staff(change.Text.ToString());
                        }
                    }

                }



            }
            if (bottom.Name == "reset")
            {
                foreach (Control change in over_controll.active_sub_body.Controls)
                {
                    if (change.Name == "input")
                    {
                        change.Text = "";
                    }
                    if(change.Name=="error")
                    {
                        change.Hide();
                    }
                }                 
            }
        }
        protected void bottom_hover(object sender, EventArgs e)
        {
            Control bottom = (Control)sender;

            if(bottom.Name=="add" || bottom.Name == "change" || bottom.Name == "upload")
            {
                bottom.BackColor = over_controll.color_active;
            }
            if(bottom.Name=="reset")
            {

                bottom.BackColor = Color.Red;
            }


        }

        protected void bottom_leave(object sender, EventArgs e)
        {
            Control bottom = (Control)sender;

            if (bottom.Name == "add" || bottom.Name == "change" || bottom.Name == "upload")
            {
                bottom.BackColor = Color.FromArgb(247, 177, 74);
            }
            if (bottom.Name == "reset")
            {
                bottom.BackColor = Color.IndianRed;
            }
        }

        private void error_message(string s )
        {
            Label input = new Label()
            {
                Name = "error",
                Text = "* "+ s,
                Size = new Size(200, 100),
                BackColor = over_controll.color_background,
                Location = new Point(250, 200),
                Font = new Font("Neuropolitical", 8, FontStyle.Bold),
                ForeColor = Color.Red,
                BorderStyle = BorderStyle.None,

            };
            over_controll.active_sub_body.Controls.Add(input);
        }

        private void add_suggestion_label(int c , int y ,string text )
        {
            Label sugg = new Label()
            {
                Name = "sugge"+c.ToString(),
                Text = text ,
                Size = new Size(200, 30),
                BackColor = Color.FromArgb(200, 200, 200),
                Location = new Point(250, y),
                Font = new Font("Neuropolitical", 10, FontStyle.Bold),
                ForeColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                TextAlign = ContentAlignment.MiddleLeft,


            };
            over_controll.active_sub_body.Controls.Add(sugg);
            //MessageBox.Show(sugg.Name.ToString());
        }

        private void delete_sugge(string s )
        {
            foreach (Control sugge in over_controll.active_sub_body.Controls)
            {
                if (sugge.Name == s)
                {
                    sugge.Dispose();
                }

            }
        }

        private void create_modi_home_sub()
        {
            header("Homepage : Change Slide Show");

            FlowLayoutPanel add_to_cover = new FlowLayoutPanel()
            {
                Name = "add_to_cover",
                Size = new Size(over_controll.av_body_size_x - 400, 100),
                Location = new Point(0, 70),
                BackColor = over_controll.color_background,
                BorderStyle = BorderStyle.None,
                AutoScroll = true,

            };
            over_controll.active_sub_body.Controls.Add(add_to_cover);

            TextBox search = new TextBox()
            {
                Name = "search",
                Text = "Search",
                Size = new Size(180, 100),
                BackColor = over_controll.color_background,
                Location = new Point(over_controll.av_body_size_x - 400 +20, 140),
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(200, 200, 200),
                BorderStyle = BorderStyle.None,

            };
            over_controll.active_sub_body.Controls.Add(search);
            search.Click += new EventHandler(search_click);
            search.TextChanged += new EventHandler(search_change);
            search.KeyDown += new KeyEventHandler(search_KeyDown);


            Panel seachline = new Panel()
            {
                Name = "seachline",
                Size = new Size(180, 1),
                Location = new Point(over_controll.av_body_size_x - 400 + 20, 170),
                BackColor = Color.FromArgb(37, 41, 48),
                BorderStyle = BorderStyle.None,
                Parent = search,
            };
            over_controll.active_sub_body.Controls.Add(seachline);
            seachline.BringToFront();


            Control sub_subbody = add_sub_subbody("sub_subbody");


            Label reset = new Label()
            {
                Name = "reset",
                Text = "Reset",
                Location = new Point(over_controll.av_body_size_x - 780 + 20, 140),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(60, 25),
                BackColor = Color.IndianRed,
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(reset);
            reset.BringToFront();
            reset.Click += new EventHandler(reset_click);
            reset.MouseHover += new EventHandler(bottom_hover);
            reset.MouseLeave += new EventHandler(bottom_leave);

            Label change = new Label()
            {
                Name = "change",
                Text = "Change",
                Location = new Point(over_controll.av_body_size_x - 700 + 20, 140),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(135, 25),
                BackColor = Color.FromArgb(247, 177, 74),
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(change);
            change.BringToFront();
            change.Click += new EventHandler(change_click);
            change.MouseHover += new EventHandler(bottom_hover);
            change.MouseLeave += new EventHandler(bottom_leave);

            string query = "SELECT * FROM `content` WHERE cover like '%_'";
            get_mod_cover(query, sub_subbody);

        }

        private Control add_sub_subbody(string s )
        {
            FlowLayoutPanel sub_subbody = new FlowLayoutPanel()
            {
                Name = s,
                Size = new Size(over_controll.av_body_size_x - 200, 501),
                Location = new Point(0, 180),
                BackColor = over_controll.color_background,
                BorderStyle = BorderStyle.None,
                AutoScroll = true,

            };
            over_controll.active_sub_body.Controls.Add(sub_subbody);

            return sub_subbody;
        }




        protected void mod_cover_click(object sender, EventArgs e)
        {
            Control cover = (Control)sender;
            Control panel = cover.Controls[0];
            cover_panel_clicked(panel);


        }
        protected void mod_cover_panel_click(object sender, EventArgs e)
        {
            Control cover = (Control)sender;
            cover_panel_clicked(cover);

        }

        private void cover_panel_clicked (Control change)
        {

            if (change.BackColor != Color.FromArgb(200, 50, 50, 50))
            {

                if (check_selected() > 5)
                {
                    return;
                }
                change.BackColor = Color.FromArgb(200, 50, 50, 50);
                // var pb = change.Parent;
                //   MessageBox.Show(pb.ImageLocation);
                foreach (Control con in over_controll.active_sub_body.Controls)
                {
                    if (con.Name.ToString() == "add_to_cover")
                    {
                        string query = "select * from content where id = '" + change.Name.ToString() + "'";
                        get_mod_cover(query, con);
                       // add_mod_cover(change.Name.ToString(), "game of thrones.jpg", con);
                    }

                }

            }

            else
            {

                change.BackColor = Color.FromArgb(100, 50, 50, 50);
                remove_mod_cover(change.Name.ToString());

            }
        }
        protected void search_click(object sender, EventArgs e)
        {
            Control search = (Control)sender;
            search.Text = "";
            search.ForeColor = Color.FromArgb(17, 22, 30);

        }

        protected void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                delete_all_mod_cover();
                Control search = (Control)sender;
                string s = search.Text.ToString();
                if (search.Text.Length == 0)
                {
                    foreach (Control con in over_controll.active_sub_body.Controls)
                    {
                        if(con.Name.ToString()== "sub_subbody")
                        {
                            string query = "SELECT * FROM `content` WHERE cover like '%_'";
                            get_mod_cover(query,con);
                        }

                    }
                }
                else
                {
                    foreach (Control con in over_controll.active_sub_body.Controls)
                    {
                        if (con.Name.ToString() == "sub_subbody")
                        {
                            string query = "SELECT * FROM `content` WHERE cover like '%_' and name like '%" + s + "%'";
                            get_mod_cover(query, con);
                        }

                    }
                }
            }
        }
        protected void search_change(object sender, EventArgs e)
        {
            Control search = (Control)sender;
            string s = search.Text.ToString();

           // MessageBox.Show(search.Name.ToString());



            if (search.Text.Length==0 && search.Text.Length <= 3)
            {
                string query = "SELECT * FROM `content` WHERE cover like '%_'";
               // add_mod_cover(query);

            }
            else
            {      
                         
            }
        }

        protected void  change_click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM slideshow";
            insert(delete);

            foreach (Control container in over_controll.active_sub_body.Controls)
            {
                if (container.Name == "add_to_cover")
                {
                    foreach (Control con in container.Controls)
                    {
                        string s = "INSERT INTO `slideshow` (`content_id`) VALUES ('" + con.Name.ToString() + "')";
                        insert(s);
                    }

                }
            }

        }
        protected void  reset_click(object sender, EventArgs e)
        {
            foreach (Control container in over_controll.active_sub_body.Controls)
            {
                if (container.Name == "sub_subbody")
                {
                   foreach (Control con in container.Controls)
                   {
                       if (con.Controls[0].Controls[0].BackColor == Color.FromArgb(200, 50, 50, 50))
                       {
                           con.Controls[0].Controls[0].BackColor = Color.Transparent; 
                       }
                   }

                }
                if (container.Name == "add_to_cover")
                {
                    delete_all_child(container);
                }
            }
        }

        private void create_up_sub()
        {
            header("Upload");

            //header("Add Staff");
            max_check = 3;

            upload.type = 0; // movie

            Label New = new Label()
            {
                Name = "Movie",
                Text = "Movie",
                Location = new Point(20, 120),
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                Size = new Size(130, 35),
                BackColor = Color.FromArgb(150, 150, 150),
                ForeColor = Color.FromArgb(37, 41, 48),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = over_controll.active_sub_body,

            };
            over_controll.active_sub_body.Controls.Add(New);
            New.BringToFront();
            New.Click += new EventHandler(user_click);
            New.MouseHover += new EventHandler(user_hover);
            New.MouseLeave += new EventHandler(user_leave);

            Panel line2 = new Panel()
            {
                Name = "line2",
                Size = new Size(130, 4),
                Location = new Point(0, 31),
                BackColor = over_controll.color_active,
                BorderStyle = BorderStyle.None,
                Parent = New,
            };

            New.Controls.Add(line2);
            line2.BringToFront();

            Label existing = new Label()
            {
                Name = "Series",
                Text = "Series",
                Location = new Point(150, 120),
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                Size = new Size(130, 35),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(37, 41, 48),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = over_controll.active_sub_body,


            };
            over_controll.active_sub_body.Controls.Add(existing);
            existing.BringToFront();
            existing.Click += new EventHandler(user_click);
            existing.MouseHover += new EventHandler(user_hover);
            existing.MouseLeave += new EventHandler(user_leave);

            Panel line3 = new Panel()
            {
                Name = "line3",
                Size = new Size(170, 4),
                Location = new Point(0, 31),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Parent = existing,

            };

            existing.Controls.Add(line3);
            line3.BringToFront();
            over_controll.active_user = New;

            Panel line4 = new Panel()
            {
                Name = "line4",
                Size = new Size(400, 1),
                Location = new Point(20, 155),
                BackColor = Color.FromArgb(37, 41, 48),
                BorderStyle = BorderStyle.None,
                Parent = New,

            };

            over_controll.active_sub_body.Controls.Add(line4);
            line4.BringToFront();

            Control sub_subbody = add_sub_subbody("sub_subbody_up");

            FlowLayoutPanel left_sub_subbody = create_flowpanel("left_sub_subbody", 300, 400, over_controll.color_background, sub_subbody);


            Panel new_or_season = create_panel("new_or_season", 500, 50, over_controll.color_background, left_sub_subbody);
            left_sub_subbody.Controls.Add(new_or_season);
            new_or_season.BringToFront();

            Label Series = new Label()
            {
                Name = "New Series",
                Text = "New Series",
                Location = new Point(10, 10),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(135, 25),
                BackColor = over_controll.color_active,
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Parent = new_or_season,
            };

            new_or_season.Controls.Add(Series);
            Series.BringToFront();
            Series.Click += new EventHandler(new_or_season_click);
            Series.MouseHover += new EventHandler(bottom_hover);
            Series.MouseLeave += new EventHandler(bottom_leave);

            Label Season = new Label()
            {
                Name = "New Season",
                Text = "New Season",
                Location = new Point(150, 10),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(135, 25),
                BackColor = Color.FromArgb(247, 177, 74),
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Parent = new_or_season,
            };

            new_or_season.Controls.Add(Season);
            Season.BringToFront();
            Season.Click += new EventHandler(new_or_season_click);
            Season.MouseHover += new EventHandler(bottom_hover);
            Season.MouseLeave += new EventHandler(bottom_leave);
            new_or_season.Hide();


            Panel inp_up_name = create_panel("inp_up_name", 500, 50, over_controll.color_background, left_sub_subbody);
            left_sub_subbody.Controls.Add(inp_up_name);

            TextBox name_in = create_textbox("name_in","Movie Name", 180,100, over_controll.color_background, Color.FromArgb(200, 200, 200), inp_up_name);
            inp_up_name.Controls.Add(name_in);
            name_in.Location = new Point(0,10);
            name_in.Click += new EventHandler(name_in_click);
            name_in.TextChanged += new EventHandler(name_in_change);



            Panel name_in_line = new Panel()
            {
                Name = "name_in_line",
                Size = new Size(180, 1),
                Location = new Point(0, 40),
                BackColor = Color.FromArgb(37, 41, 48),
                BorderStyle = BorderStyle.None,
                Parent = inp_up_name,

            };
            inp_up_name.Controls.Add(name_in_line);

            Panel season = create_panel("season", 500, 50, over_controll.color_background, left_sub_subbody);
            left_sub_subbody.Controls.Add(season);

            TextBox season_in = create_textbox("season_in", "Season", 180, 100, over_controll.color_background, Color.FromArgb(200, 200, 200), season);
            season.Controls.Add(season_in);
            season_in.Location = new Point(0, 10);
            season_in.Click += new EventHandler(name_in_click);
            season_in.KeyPress += new KeyPressEventHandler(episode_KeyPress);
            season_in.TextChanged += new EventHandler(season_in_change);

            Panel season_in_line = new Panel()
            {
                Name = "season_in_line",
                Size = new Size(180, 1),
                Location = new Point(0, 40),
                BackColor = Color.FromArgb(37, 41, 48),
                BorderStyle = BorderStyle.None,
                Parent = season_in,

            };
            season.Controls.Add(season_in_line);
            season_in_line.BringToFront();
            season.Hide();

            Panel episode = create_panel("episode", 500, 50, over_controll.color_background, left_sub_subbody);
            left_sub_subbody.Controls.Add(episode);

            TextBox episode_in = create_textbox("episode_in", "Episode", 180, 100, over_controll.color_background, Color.FromArgb(200, 200, 200), episode);
            episode.Controls.Add(episode_in);
            episode_in.Location = new Point(0, 10);
            episode_in.KeyPress += new KeyPressEventHandler(episode_KeyPress);
            episode_in.Click += new EventHandler(name_in_click);
            episode_in.TextChanged += new EventHandler(episode_in_change);

            Panel episode_in_line = new Panel()
            {
                Name = "season_in_line",
                Size = new Size(180, 1),
                Location = new Point(0, 40),
                BackColor = Color.FromArgb(37, 41, 48),
                BorderStyle = BorderStyle.None,
                Parent = season_in,

            };
            episode.Controls.Add(episode_in_line);
            episode_in_line.BringToFront();
            episode.Hide();


            Panel releasedate = create_panel("releasedate", 500, 50, over_controll.color_background, left_sub_subbody);
            left_sub_subbody.Controls.Add(releasedate);

            DateTimePicker redate = new DateTimePicker()
            {
                Name = "redate",
                Parent = releasedate,

            };
            releasedate.Controls.Add(redate);
            redate.Location = new Point(0, 10);
            redate.ValueChanged += new EventHandler(picker_ValueChanged);


            Panel post_cover = create_panel("post_cover", 500, 50, over_controll.color_background, left_sub_subbody);
            left_sub_subbody.Controls.Add(post_cover);

            Button post = new Button()
            {
                Name = "post",
                Text = "Poster",
                Parent = post_cover,
            };
            post_cover.Controls.Add(post);
            post.Location = new Point(0, 10);
            post.Click += new EventHandler(post_click);


            Button cov = new Button()
            {
                Name = "cov",
                Text = "Cover",
                Parent = post_cover,
            };
            post_cover.Controls.Add(cov);
            cov.Location = new Point(100, 10);
            cov.Click += new EventHandler(cov_click);

            FlowLayoutPanel up_genre = create_flowpanel("up_genre", 400, 400, over_controll.color_background, sub_subbody);
            sub_subbody.Controls.Add(up_genre);

            upload.genre_valid = false;
            Panel select_3 = create_panel("select_3", 400, 20, over_controll.color_background, up_genre);
            up_genre.Controls.Add(select_3);
            max_check = 3;
            TextBox genre_tag_select_3 = create_textbox("genre_tag_select_3", "Select 3 genres", 200, 400, over_controll.color_background, ForeColor = Color.FromArgb(37, 41, 48),
 inp_up_name);
            select_3.Controls.Add(genre_tag_select_3);
            genre_tag_select_3.Font = new Font("Neuropolitical", 10, FontStyle.Regular);

            add_genre(up_genre);


            Label reset = new Label()
            {
                Name = "reset",
                Text = "Reset",
                Location = new Point(over_controll.av_body_size_x - 400, 250),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(135, 25),
                BackColor = Color.IndianRed,
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(reset);
            reset.BringToFront();
            reset.Click += new EventHandler(reset_click);
            reset.MouseHover += new EventHandler(bottom_hover);
            reset.MouseLeave += new EventHandler(bottom_leave);

            Label change = new Label()
            {
                Name = "upload",
                Text = "Upload",
                Location = new Point(over_controll.av_body_size_x - 400, 280),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(135, 25),
                BackColor = Color.FromArgb(247, 177, 74),
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(change);
            change.BringToFront();
            change.Click += new EventHandler(up_click);
            change.MouseHover += new EventHandler(bottom_hover);
            change.MouseLeave += new EventHandler(bottom_leave);

        }

        private void change_content_type(bool show)
        {
            foreach(Control container in over_controll.active_sub_body.Controls)
            {
                if(container.Name.ToString()== "sub_subbody_up")
                {
                    foreach (Control conn in container.Controls)
                    {
                        if(conn.Name.ToString()== "left_sub_subbody")
                        {
                            foreach (Control check in conn.Controls)
                            {
                                if(show)
                                {
                                    if (check.Name.ToString() == "inp_up_name")
                                    {
                                        check.Controls[0].Text = "Sereis Name";
                                    }
                                    if (check.Name.ToString() == "new_or_season")
                                    {
                                        check.Show();
                                    }

                                    if (check.Name.ToString() == "episode")
                                    {
                                        check.Show();
                                    }
                                }
                                else
                                {
                                    if (check.Name.ToString() == "inp_up_name")
                                    {
                                        check.Controls[0].Text = "Movie Name";
                                    }
                                    if (check.Name.ToString() == "new_or_season")
                                    {
                                        check.Hide();
                                    }

                                    if (check.Name.ToString() == "episode")
                                    {
                                        check.Hide();
                                    }
                                }
                                
                            }
                        }
                        break; 
                    }
                   break; 
                }
            }
        }
        protected void up_click(object sender, EventArgs e)
        {
            up();
        }

        protected void new_or_season_click(object sender, EventArgs e)
        {
            Control seasonorseries = (Control)sender;

            if(seasonorseries.Name.ToString()== "New Series")
            {
                change_series_type(false);
                upload.type = 1; 
            }

            if (seasonorseries.Name.ToString() == "New Season")
            {
                change_series_type(true);
                upload.type = 2;
            }
        }

        protected void episode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void change_series_type(bool show)
        {
            foreach (Control container in over_controll.active_sub_body.Controls)
            {

                if (container.Name.ToString() == "sub_subbody_up")
                {

                    foreach (Control conn in container.Controls)
                    {
                        if (conn.Name.ToString() == "left_sub_subbody")
                        {

                            foreach (Control check in conn.Controls)
                            {
                                if (check.Name.ToString() == "season")
                                {
                                    if (show)
                                        check.Show();
                                    else
                                        check.Hide();
                                    break; 
                                }
                            }
                        }
                        break;
                    }
                    break;
                }
            }
        }

        protected void name_in_click(object sender, EventArgs e)
        {
            Control name = (Control)sender;
            if (name.Text.ToString() == "Movie Name" || name.Text.ToString() == "Sereis Name" || name.Text.ToString() == "Episode"|| name.Text.ToString() == "Season")
            {
                name.Text = "";
            }

        }
        protected void name_in_change(object sender, EventArgs e)
        {
            Control name = (Control)sender;
            upload.name = name.Text;

        }

        protected void season_in_change(object sender, EventArgs e)
        {
            Control s = (Control)sender;
            if (s.Text != "")
                upload.season = Int32.Parse(s.Text);

        }
        protected void episode_in_change(object sender, EventArgs e)
        {
            Control ep = (Control)sender;
            if(ep.Text!="")
                upload.episode = Int32.Parse(ep.Text);

        }
        protected void picker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker date = (DateTimePicker)sender;
            DateTime dt = date.Value.Date;
            upload.rdate = dt.ToString("yyyy-MM-dd ");
        }
        

        protected void post_click(object sender, EventArgs e)
        {
            up_pic(true);
        }
        protected void cov_click(object sender, EventArgs e)
        {
            up_pic(false);
        }



        private void up_pic(bool post)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpeg image|*.jpg";

            if (op.ShowDialog() == DialogResult.OK)
            {
                if(post)
                {
                    upload.post = Image.FromFile(op.FileName);
                    upload.pname = op.SafeFileName.ToString();

                }
                else
                {
                    upload.cover = Image.FromFile(op.FileName);
                    upload.cname = op.SafeFileName.ToString();
                }


            }
        }

        

        private void create_promo_sub()
        {
            header("Promote");

            TextBox search = new TextBox()
            {
                Name = "search",
                Text = "Search",
                Size = new Size(180, 100),
                BackColor = over_controll.color_background,
                Location = new Point(over_controll.av_body_size_x - 400 + 20, 140),
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(200, 200, 200),
                BorderStyle = BorderStyle.None,

            };
            over_controll.active_sub_body.Controls.Add(search);
            search.Click += new EventHandler(search_click);
            search.TextChanged += new EventHandler(search_change);
            search.KeyDown += new KeyEventHandler(search_KeyDown);


            Panel seachline = new Panel()
            {
                Name = "seachline",
                Size = new Size(180, 1),
                Location = new Point(over_controll.av_body_size_x - 400 + 20, 170),
                BackColor = Color.FromArgb(37, 41, 48),
                BorderStyle = BorderStyle.None,
                Parent = search,
            };
            over_controll.active_sub_body.Controls.Add(seachline);
            seachline.BringToFront();


            Label reset = new Label()
            {
                Name = "reset",
                Text = "Reset",
                Location = new Point(over_controll.av_body_size_x - 400 + 20, 100),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(60, 25),
                BackColor = Color.IndianRed,
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(reset);
            reset.BringToFront();
            reset.Click += new EventHandler(reset_click);
            reset.MouseHover += new EventHandler(bottom_hover);
            reset.MouseLeave += new EventHandler(bottom_leave);

            Label change = new Label()
            {
                Name = "change",
                Text = "Change",
                Location = new Point(over_controll.av_body_size_x - 400 + 90, 100),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(110, 25),
                BackColor = Color.FromArgb(247, 177, 74),
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(change);
            change.BringToFront();
            change.Click += new EventHandler(change_click);
            change.MouseHover += new EventHandler(bottom_hover);
            change.MouseLeave += new EventHandler(bottom_leave);

            Control sub_subbody = add_sub_subbody("sub_subbody_up");

            string query = "select * from content";

            MySqlConnection databaseConnection = connstring();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string poster = reader["poster"].ToString();
                Panel new_or_season = create_panel("new_or_season", 450, 200, over_controll.color_active, sub_subbody);
                sub_subbody.Controls.Add(new_or_season);
            }
            databaseConnection.Close();

        }

        private void create_plan_sub()
        {
            header("Change Plan");
            Label reset = new Label()
            {
                Name = "reset",
                Text = "Rest",
                Location = new Point(over_controll.av_body_size_x - 780 + 20, 140),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(60, 25),
                BackColor = Color.IndianRed,
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(reset);
            reset.BringToFront();
            reset.Click += new EventHandler(reset_click);
            reset.MouseHover += new EventHandler(bottom_hover);
            reset.MouseLeave += new EventHandler(bottom_leave);

            Label change = new Label()
            {
                Name = "change",
                Text = "Change",
                Location = new Point(over_controll.av_body_size_x - 700 + 20, 140),
                Font = new Font("Neuropolitical", 14, FontStyle.Bold),
                Size = new Size(135, 25),
                BackColor = Color.FromArgb(247, 177, 74),
                ForeColor = over_controll.color_background,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight,
                Parent = over_controll.active_sub_body,
            };

            over_controll.active_sub_body.Controls.Add(change);
            change.BringToFront();
            change.Click += new EventHandler(change_click);
            change.MouseHover += new EventHandler(bottom_hover);
            change.MouseLeave += new EventHandler(bottom_leave);

            Control sub_subbody = add_sub_subbody("sub_subbody_up");

            for(int i=0; i<3; i++ )
            {
                Panel new_or_season = create_panel("new_or_season", 300, 450, over_controll.color_active, sub_subbody);
                sub_subbody.Controls.Add(new_or_season);
            }

        }

    }
}
