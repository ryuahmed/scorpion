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
        private void creat_content_profile(string content_id)
        {
            body_panel();

            content con = new content();
            con.get_info(content_id);
            con.genre = get_genre(content_id);

            create_cover(con);
            create_info(con);
            create_season(con);
            create_ep(con);
            create_sugg(con);
            create_comment(con);
            add_footer();
        }

        private void create_cover( content con)
        {


            Panel slideshow_panel = create_panel("cover", over_controll.av_body_size_x, 394, over_controll.color_background, over_controll.active_panel);
            PictureBox cover = cover_pic(slideshow_panel);
            cover.Image = new Bitmap(over_controll.static_media_location + @"cover\" + con.cover);
            cover.SizeMode = PictureBoxSizeMode.Zoom;



        }

        private void create_info(content con)
        {
            Panel info = create_panel("info", over_controll.av_body_size_x, 200, over_controll.color_background, over_controll.active_panel);

            Label title = create_label(con.name, con.name, 400, 30, over_controll.color_background, Color.Black, info);
            info.Controls.Add(title);
            title.Location = new Point(5, 5);

            Label tag = create_label(con.tag, con.tag, 400, 20, over_controll.color_background, Color.Black, info);
            info.Controls.Add(tag);
            tag.Location = new Point(5, 35);
            tag.Font = new Font("Neuropolitical", 10, FontStyle.Regular);

            Label creator = create_label("Creator", "Creator : " + con.creator, 400, 20, over_controll.color_background, Color.Black, info);
            info.Controls.Add(creator);
            creator.Location = new Point(5, 60);
            creator.Font = new Font("Neuropolitical", 10, FontStyle.Regular);
            if (con.type == "Movie")
            {
                creator.Text = "Director : ";
            }


            Label star = create_label("star", "Stars : " + con.star[0] + ", " + con.star[1] + ", " + con.star[2], 400, 20, over_controll.color_background, Color.Black, info);
            info.Controls.Add(star);
            star.Location = new Point(5, 80);
            star.Font = new Font("Neuropolitical", 10, FontStyle.Regular);

            Label genre = create_label("genre", "Genre : " + con.genre[0] + ", " + con.genre[1] + ", " + con.genre[2], 400, 20, over_controll.color_background, Color.Black, info);
            info.Controls.Add(genre);
            genre.Location = new Point(5, 100);
            genre.Font = new Font("Neuropolitical", 10, FontStyle.Regular);

            Label air = create_label("air", "Air : " + con.r_date, 400, 20, over_controll.color_background, Color.Black, info);
            info.Controls.Add(air);
            air.Location = new Point(5, 120);
            air.Font = new Font("Neuropolitical", 10, FontStyle.Regular);
            if (con.type == "Movie")
            {
                air.Text = "Release Date : ";
            }
            int x = 140;
            if (con.type == "Movie")
            {
                Label status = create_label("status", "Status : Ongoing", 400, 20, over_controll.color_background, Color.Black, info);
                info.Controls.Add(status);
                status.Location = new Point(5, x);
                status.Font = new Font("Neuropolitical", 10, FontStyle.Regular);

                if (con.e_date != "")
                {
                    air.Text = air.Text + " to " + con.e_date;
                    status.Text = "Status : Ended";
                }
                x = x + 20;
            }


            Label country = create_label("country", "Country : " + con.country, 400, 20, over_controll.color_background, Color.Black, info);
            info.Controls.Add(country);
            country.Location = new Point(5, x);
            country.Font = new Font("Neuropolitical", 10, FontStyle.Regular);
            x = x + 20;

            Label lang = create_label("lang", "Language : " + con.lang, 400, 20, over_controll.color_background, Color.Black, info);
            info.Controls.Add(lang);
            lang.Location = new Point(5, x);
            lang.Font = new Font("Neuropolitical", 10, FontStyle.Regular);


            Label plot_head = create_label("plot_head", "Plot", 500, 30, over_controll.color_background, Color.Black, info);
            info.Controls.Add(plot_head);
            plot_head.Location = new Point(405, 5);

            Panel plot_head_line = create_panel("ep", 500, 1, over_controll.color_menubar_hover, plot_head);
            plot_head.Controls.Add(plot_head_line);
            plot_head_line.Location = new Point(0, 25);

            Label plot = create_label("plot", con.plot, 500, 180, over_controll.color_background, Color.Black, info);
            info.Controls.Add(plot);
            plot.Location = new Point(405, 35);
            plot.Font = new Font("Neuropolitical", 10, FontStyle.Regular);

            //  Panel rate = create_panel("ep", 100, 200, over_controll.color_menubar_hover, info);
            // info.Controls.Add(rate);
            //  rate.Location = new Point(510, 5);
        }

        private void create_season(content con)
        {
            int size_x = 45 *(((con.season_no-1) / 5)+1);
            Panel season = create_flowpanel("season", over_controll.av_body_size_x, size_x, over_controll.color_background, over_controll.active_panel);
            //season.BorderStyle = BorderStyle.FixedSingle; 

            for (int i = 0; i < con.season_no; i++)
            {  

                if(con.type == "Movie")
                {
                    con.sid.Add( con.id);
                }
                Panel s = create_panel(con.sid[i], 200, 35,Color.FromArgb(192, 195, 198), season);
                Button ts = create_button(con.sid[i], "Season " + (1 + i).ToString(), 200, 35, Color.Transparent, Color.FromArgb(122, 130, 142), s);
                s.Controls.Add(ts);
                ts.AutoSize = false;
                ts.TextAlign = ContentAlignment.MiddleCenter;
                if (con.type == "Movie")
                {
                    ts.Text = "Play";
                    s.Click += (sender, EventArgs) => { movie_play_click(sender, EventArgs, con); };
                    ts.Click += (sender, EventArgs) => { movie_play_click(sender, EventArgs, con); };

                }
              //  s.Click += new EventHandler(season_click);
              //  ts.Click += new EventHandler(season_click);
                s.Click += (sender, EventArgs) => { season_click(sender, EventArgs, con); };
                ts.Click += (sender, EventArgs) => { season_click(sender, EventArgs, con); };
                //s.MouseHover += new EventHandler(season_hover);
                // ts.MouseHover += new EventHandler(season_hover);
                // s.MouseLeave += new EventHandler(season_leave);
                // ts.MouseLeave += new EventHandler(season_leave);
           }
        }
        private void create_ep(content con)
        {
            Panel ep = create_flowpanel("ep", over_controll.av_body_size_x, 50, over_controll.color_background, over_controll.active_panel);
            ep.Hide();
   
        }

        private void add_ep(string sid, Control ep, content con)
        {
            con.get_ep_no(sid);

            int size_y = 45 * (((con.ep_no - 1) / 5) + 1);

            ep.Show();
            ep.Size = new Size(over_controll.av_body_size_x, size_y);
            con.get_ep(sid);
            //season.BorderStyle = BorderStyle.FixedSingle; 
            for (int i = 0; i < con.ep_no; i++)
            {

                Panel e = create_panel(con.ep[i], 150, 35, Color.FromArgb(192, 195, 198), ep);
                Button te = create_button(con.ep[i], "Episode " + (1 + i).ToString(), 150, 35, Color.Transparent, Color.FromArgb(122, 130, 142), e);
                e.Controls.Add(te);
                te.AutoSize = false;
                te.TextAlign = ContentAlignment.MiddleCenter;
                te.Font = new Font("Neuropolitical", 14, FontStyle.Bold);


                e.Click += (sender, EventArgs) => { ep_click(sender, EventArgs, con); };
                te.Click += (sender, EventArgs) => { ep_click(sender, EventArgs, con); };
                // s.Click += (sender, EventArgs) => { season_click(sender, EventArgs, con); };
                //ts.Click += (sender, EventArgs) => { season_click(sender, EventArgs, con); };
                //s.MouseHover += new EventHandler(season_hover);
                // ts.MouseHover += new EventHandler(season_hover);
                // s.MouseLeave += new EventHandler(season_leave);
                // ts.MouseLeave += new EventHandler(season_leave);
            }
        }
        private void create_sugg(content con)
        {
            FlowLayoutPanel sug = create_flowpanel("sug", over_controll.av_body_size_x, 260, over_controll.color_background, over_controll.active_panel);

            get_similliar(con.id,con.genre[0], con.genre[1], con.genre[2]);
            int j = 0;
            string[,] s = new string[5, 2];
            foreach (string link in result_search.poster)
            {
                s[j, 0] = link;
                s[j, 1] = result_search.id[j];
                j++;
                if (j == 5)
                {
                    add_poster(sug, j, s);
                    break;
                }
            }
        }

        private void create_comment(content con)
        {
            int full_comment_y = 0;
            int comment_no=0;
            Panel cmnt = create_flowpanel("cmnt", over_controll.av_body_size_x, 500, over_controll.color_background, over_controll.active_panel);
            cmnt.AutoSize = true; 
            Panel cmmnt_title = create_panel("cmnt_panel", over_controll.av_body_size_x, 50, over_controll.color_background, over_controll.active_panel);
            cmnt.Controls.Add(cmmnt_title);
            string query = "select count(*) as no from comment where c_id = '"+con.id+"'";
            string c = count(query);
            if (c == "0")
                c = "No";
            else
                comment_no = Int32.Parse(c);

            Label title = create_label("Comment", c+" Comments", 400, 30, over_controll.color_background, Color.Black, cmmnt_title);
            cmmnt_title.Controls.Add(title);
            title.Location = new Point(5, 5);

            Panel cmmnt_line = create_panel("line", over_controll.av_body_size_x, 1, over_controll.color_menubar_hover, cmmnt_title);
            cmmnt_title.Controls.Add(cmmnt_line);
            cmmnt_line.Location = new Point(0, 35);
            cmmnt_line.BringToFront();


            write_comment(cmnt, con, "wr_comment");
            full_comment_y = full_comment_y + 200;


            query = "select *  from comment where c_id = '" + con.id + "'";
            

            MySqlConnection databaseConnection = connstring();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            string[] data = new string[7];

            for (int i=0; i<5 && i< comment_no; i++)
            {

                int Location_x = 100;
                reader.Read();
                data[5] = "time";
                //DateTime s = DateTime.Parse(reader["date_time"].ToString());
                data[ 0] = reader["cmnt_id"].ToString();
                data[ 1] = reader["c_id"].ToString();
                data[ 2] = reader["u_id"].ToString();
                data[ 3] = reader["comment"].ToString();
                data[ 4] = reader["spoiler"].ToString();
                // data[i, 5] = s.ToString("dd-M-yyyy");
                string s = "SELECT count(*) as no from comment  join comment_love WHERE comment.cmnt_id = comment_love.cmnt_id and  comment.cmnt_id = '"+ data[0] + "' and  comment.c_id= '"+ con.id + "'group by comment_love.cmnt_id";
                data[6] = count(s);

                full_comment_y = full_comment_y+show_comment(cmnt, data);

                Panel write_comment_reply = create_panel("write_comment_reply_"+ data[0], over_controll.av_body_size_x, 200, over_controll.color_deactive, cmnt);
                cmnt.Controls.Add(write_comment_reply);
                write_comment_reply.AutoSize = true;

                Panel write_comment_reply_sub = create_panel("write_comment_reply_sub_forspace", over_controll.av_body_size_x-Location_x, 100, over_controll.color_background, write_comment_reply);
                write_comment_reply.Controls.Add(write_comment_reply_sub);
                write_comment_reply_sub.Location = new Point(Location_x, 0);
                write_comment(write_comment_reply_sub, con,  data[0]);
                write_comment_reply_sub.AutoSize = true;

                write_comment_reply.Hide();

                //full_comment_y = full_comment_y + write_comment_reply.Height;


            }
            databaseConnection.Close();

            //MessageBox.Show(full_comment_y.ToString());

            cmnt.Size = new Size(over_controll.av_body_size_x, full_comment_y);


        }

        private void write_comment(Control cmnt, content con, string id)
        {
            int width = over_controll.av_body_size_x;
            int hight = 150;
            int ps = 30;
            int textbox_max_hight = 70;
            string comnt_comnt_text = "comnt_comnt";
            string cancel = "cancel";
            string wr_comment =  id;
            if (cmnt.Name!="cmnt")
            {
                wr_comment = "write_comment_reply_" + id;
                width = 1058-100; 
                hight =120; 
                ps=25;
                textbox_max_hight = 35;
                comnt_comnt_text = "reply_comnt_comnt";
                cancel = "reply_cancel";
 
            }


            Panel wr_comment_panel = create_panel("wr_comment_panel", width, hight, over_controll.color_background, cmnt);
            cmnt.Controls.Add(wr_comment_panel);

            PictureBox dp = new PictureBox()
            {
                Name = "dp",
                Size = new Size(ps, ps),
                Location = new Point(0, 0),
                Margin = new Padding(0, 0, 0, 0),
            };
            wr_comment_panel.Controls.Add(dp);
            //MessageBox.Show(user_log_in.dp);
            dp.Image = new Bitmap(user_log_in.dp);
            dp.SizeMode = PictureBoxSizeMode.StretchImage;


            TextBox comment_write = create_textbox(wr_comment, "Add a comment", width - 50, textbox_max_hight, over_controll.color_background, Color.Black, wr_comment_panel);
            wr_comment_panel.Controls.Add(comment_write);
            comment_write.Location = new Point(45, 5);
            comment_write.Multiline = true;
            comment_write.Font = new Font("Neuropolitical", 10, FontStyle.Regular);
            comment_write.Click += new EventHandler(comment_write_click);
            comment_write.TextChanged += new EventHandler(comment_write_TextChanged);


            Panel comment_write_line = create_panel("comment_write_line", over_controll.av_body_size_x, 1, over_controll.color_menubar_hover, wr_comment_panel);
            wr_comment_panel.Controls.Add(comment_write_line);
            comment_write_line.Location = new Point(45, 75);
            comment_write_line.BringToFront();

            Label cancel_comnt = create_label(cancel, "Cancel", 60, 25, Color.IndianRed, over_controll.color_background, wr_comment_panel);
            wr_comment_panel.Controls.Add(cancel_comnt);
            cancel_comnt.Font = new Font("Neuropolitical", 12, FontStyle.Regular);
            cancel_comnt.Location = new Point(45, 77);
            cancel_comnt.Hide();
            cancel_comnt.Click += new EventHandler(cancel_comnt_click);

            Label comnt_comnt = create_label(comnt_comnt_text, "Comment", 80, 25, Color.FromArgb(200, 200, 200), over_controll.color_background, wr_comment_panel);
            wr_comment_panel.Controls.Add(comnt_comnt);
            comnt_comnt.Font = new Font("Neuropolitical", 12, FontStyle.Regular);
            comnt_comnt.Location = new Point(110, 77);
            comnt_comnt.Hide();
            comnt_comnt.Click += (sender, EventArgs) => { comnt_comnt_click(sender, EventArgs, con); };

            Panel spoiler_panel = create_panel("spoiler_panel", 200, 50, over_controll.color_background, wr_comment_panel);
            wr_comment_panel.Controls.Add(spoiler_panel);
            spoiler_panel.Location = new Point(200, 77);
            spoiler_panel.Hide();

            CheckBox spoiler = new CheckBox()
            {
                Name = "spoiler",
                Text = "Sploier",
                AutoSize = true,
                Font = new Font("Neuropolitical", 11, FontStyle.Regular),
                BackColor = over_controll.color_background,
                ForeColor = Color.FromArgb(200, 200, 200),
            };
            spoiler_panel.Controls.Add(spoiler);
            spoiler.Location = new Point(0, 0);
            spoiler.CheckedChanged += new EventHandler(spoiler_change);

            Panel panel = create_panel("parent", width, hight, over_controll.color_background, wr_comment_panel);
            wr_comment_panel.Controls.Add(panel);

            Panel parent_id = create_panel(id, width, hight, over_controll.color_background, panel);
            panel.Controls.Add(parent_id);


        }

        private int show_comment(Control cmnt,string[] data )
        {
            // show comment
            string id = data[0];
            string uid = data[2];
            string time = data[5];
            string comment_text = data[3];
            string spoiler = data[4];
            string lno = data[6];

            string s = "select dp from user where User_name='" + uid + "'";
            List<string> dp = result(s,"dp");


            //main
            Panel show_cmnt = create_panel(id,1058, 200, over_controll.color_background, cmnt);
            cmnt.Controls.Add(show_cmnt);
            show_cmnt.AutoSize = true;

            //main->dp
            PictureBox show_cmnt_dp = new PictureBox()
            {
                Name = uid,
                Size = new Size(30, 30),
                Location = new Point(20, 15),
                Margin = new Padding(0, 0, 0, 0),
            };
            show_cmnt.Controls.Add(show_cmnt_dp);
            //MessageBox.Show(user_log_in.dp);
            show_cmnt_dp.Image = new Bitmap(over_controll.static_media_location + @"dp\" + dp[0]);
            show_cmnt_dp.SizeMode = PictureBoxSizeMode.StretchImage;
            show_cmnt_dp.Click += new EventHandler(user_click_to_profile);

            //main->id
            Label show_cmnt_user = create_label(uid, uid, 500, 20, over_controll.color_background, Color.Black, show_cmnt);
            show_cmnt.Controls.Add(show_cmnt_user);
            show_cmnt_user.Font = new Font("Neuropolitical", 11, FontStyle.Bold);
            show_cmnt_user.Location = new Point(55, 5);
            show_cmnt_user.Click += new EventHandler(user_click_to_profile);

            //main->time
            Label show_cmnt_time = create_label(time, time, 500, 15, over_controll.color_background, Color.FromArgb(200, 200, 200), show_cmnt);
            show_cmnt.Controls.Add(show_cmnt_time);
            show_cmnt_time.Font = new Font("Neuropolitical", 11, FontStyle.Regular);
            show_cmnt_time.Location = new Point(55, 25);

            //main->sub_panel(comment,love,reply)
            Panel comnt_love_reply_panel = create_flowpanel("comnt_love_reply_panel", 1000, 120, over_controll.color_background, show_cmnt);
            comnt_love_reply_panel.Location = new Point(55, 55);
            show_cmnt.Controls.Add(comnt_love_reply_panel);
            //main->sub_panel->comment_panel
            Panel comment_panel = create_flowpanel("comment_panel", 1000, 120, over_controll.color_background, comnt_love_reply_panel);
            comment_panel.Location = new Point(0, 0);
            comnt_love_reply_panel.Controls.Add(comment_panel);
            comment_panel.AutoSize = true;


            //main->sub_panel->comment_panel->sopler_reveal
            Panel sopler_reveal = create_panel("comment_panel", 1000, 120, over_controll.color_background, comment_panel);
            comment_panel.Controls.Add(sopler_reveal);
            Label sopler_reveal_label = create_label(id, "Reveal Spoiler", 1000, 100, Color.FromArgb(5, 70, 170), over_controll.color_background, sopler_reveal);
            sopler_reveal.Controls.Add(sopler_reveal_label);
            sopler_reveal_label.Font = new Font("Neuropolitical", 8, FontStyle.Regular);
            sopler_reveal_label.AutoSize = true;
            sopler_reveal.Size = new Size(1000, sopler_reveal_label.Height);
            sopler_reveal_label.Click += new EventHandler(sopler_reveal_label_click);



            //main->sub_panel->comment_panel->comment_text
            Label comment = create_label(id, comment_text, 1000, 100, over_controll.color_background, Color.Black, comment_panel);
            comment_panel.Controls.Add(comment);
            comment.Font = new Font("Neuropolitical", 11, FontStyle.Regular);
            comment.Location = new Point(0, 0);
            comment.AutoSize = true;

            int y = comment.Height;
            //sopler_reveal.Hide();


            if (spoiler=="0")
            {
                sopler_reveal.Hide();
                //main->sub_panel->comment_panel->view bottom_panel
                Panel show_cmnt_view_panel = create_panel(id, 1000, 20, over_controll.color_background, comment_panel);
                comment_panel.Controls.Add(show_cmnt_view_panel);
                show_cmnt_view_panel.Hide();

                //main->sub_panel->comment_panel->view bottom_text
                Label show_cmnt_view = create_label("view", "View more", 500, 20, over_controll.color_background, Color.Black, show_cmnt_view_panel);
                show_cmnt_view.Font = new Font("Neuropolitical", 8, FontStyle.Regular);
                show_cmnt_view_panel.Controls.Add(show_cmnt_view);
                show_cmnt_view.Click += new EventHandler(show_cmnt_view_click);

                //MessageBox.Show(y. ToString());
                if (y > 100)
                {
                    comment.MaximumSize = new Size(1000, 100);
                    show_cmnt_view_panel.Show();
                    y = 130;
                }
                //MessageBox.Show(y.ToString());
                // comment_panel.AutoSize = false; 
                comment_panel.Size = new Size(1000, y);
            }
            else
            {
                comment.Hide();
                y = sopler_reveal_label.Height+10;
            }

            comment_panel.Size = new Size(1000, y);


            int ry = 0;

            Panel love_reply_panel = create_panel("love_reply_panel", 1000, ry + 30, Color.Transparent, comnt_love_reply_panel);
            love_reply_panel.Location = new Point(0, 0);
            comnt_love_reply_panel.Controls.Add(love_reply_panel);

            PictureBox love = new PictureBox()
            {
                Name = "love",
                Size = new Size(20, 20),
                Location = new Point(0, 0),
                BackColor = Color.Transparent,
                Parent = love_reply_panel,
            };
            love_reply_panel.Controls.Add(love);
            love.Image = Properties.Resources.love1;
            love.SizeMode = PictureBoxSizeMode.StretchImage;
            love.Click += new EventHandler(love_click);

            Label love_no = create_label("love_no", lno, 100, 100, Color.Transparent, Color.FromArgb(200, 200, 200), love_reply_panel);
            love_no.AutoSize = true;
            love_no.Location = new Point(25, 2);
            love_reply_panel.Controls.Add(love_no);
            love_no.Font = new Font("Neuropolitical", 9, FontStyle.Regular);

            Label reply = create_label(id, "Reply", 100, 100, Color.Transparent, Color.Black, love_reply_panel);
            reply.AutoSize = true;
            love_reply_panel.Controls.Add(reply);
            reply.Font = new Font("Neuropolitical", 10, FontStyle.Regular);
            reply.Location = new Point(30 + 10 + love_no.Width, 0);
            reply.Click += new EventHandler(reply_click);

            comnt_love_reply_panel.Size = new Size(1000, y + 30 + ry);

            s = "select count(*) as no from comment_love where cmnt_id = '" + id + "' and u_id = '" + user_log_in.UserID + "'";
            if(count(s)!="0")
            {
                love.Image = Properties.Resources.love2;
            }


            return y + 30 + ry + 80; 

        }

        protected void movie_play_click(object sender, EventArgs e,content content_obj )
        {
            Control id = ((Control)sender);
            if (user_log_in.pos == "guest")
            {
                MessageBox.Show("Your payment expired");
                return;
            }
            if (!player_data.run)
            {
                player_data.get_video_media(id.Name, content_obj);
                player_data.run = true;
                Form player = new player_form();
                player.Show();
            }

        }

        protected void season_click(object sender, EventArgs e,content content_obj )
        {
            Control season = (Control)sender;
           // MessageBox.Show(season.Name);

            foreach (Control container in over_controll.active_panel.Controls)
            {
                if(container.Name.ToString()== "season")
                {
                    foreach (Control con in container.Controls)
                    {
                        if (con.Name.ToString()!=season.Name.ToString())
                        {
                            con.BackColor = Color.FromArgb(192, 195, 198);
                        }
                        else
                        {
                            con.BackColor = Color.FromArgb(158, 163, 168);
                        }
                    }
                }
                if (container.Name.ToString() == "ep")
                {
                    delete_all_child(container);
                    add_ep(season.Name, container, content_obj);
                }
            }
        }
        protected void comment_write_click(object sender, EventArgs e)
        {
            Control clean = (Control)sender;
            if(clean.Text== "Add a comment")
                clean.Text = "";

            comment_bottom(true,  clean.Name);
        }
        protected void show_cmnt_view_click(object sender, EventArgs e)
        {
            Control view = (Control)sender;
            Panel change = (Panel)view.Parent.Parent;
            MessageBox.Show(change.Name);

            if (view.Text == "View more")
            {
                view.Text = "View Less";
                int x = change.Height;

                change.AutoSize = true;
                change.Controls[1].MaximumSize=new Size(0, 0);
                change.Size = new Size(1000, change.Controls[1].Height);
                int y = change.Height;
                int z =  y-x;

                change.Parent.Size = new Size(change.Parent.Width, change.Parent.Height+z);

            }
            else
            {
                view.Text = "View more";
                int x = change.Height;

                change.AutoSize = true;
                change.Controls[1].MaximumSize = new Size(1000,100);
                change.Size = new Size(1000, 100);
                int y = change.Height;
                int z = x-y ;

                change.Parent.Size = new Size(change.Parent.Width, change.Parent.Height - z);
            }


        }
        protected void sopler_reveal_label_click(object sender, EventArgs e)
        {

            Control view = (Control)sender;

            Panel change = (Panel)view.Parent.Parent;
            MessageBox.Show(change.Name);

            if (view.Text == "Reveal Spoiler")
            {
                int x = change.Height;

                view.Text = "Hide Spoiler";
                change.Controls[1].Show();

                change.AutoSize = true;
                change.Controls[1].MaximumSize = new Size(0, 0);
                change.Size = new Size(1000, change.Controls[1].Height);
                int y = change.Height;
                int z = y - x;

                change.Parent.Size = new Size(change.Parent.Width, change.Parent.Height + z);

            }
            else
            {
                int x = change.Height;
                view.Text = "Reveal Spoiler";
                ((Control)sender).Parent.Parent.Controls[1].Hide();

                change.AutoSize = true;
                change.Controls[1].MaximumSize = new Size(1000, 100);
                change.Size = new Size(1000, 100);
                int y = change.Height;
                int z = x - y;

                change.Parent.Size = new Size(change.Parent.Width, change.Parent.Height - z);
            }

        }

        protected void cancel_comnt_click(object sender, EventArgs e)
        {
            Control cancel = (Control)sender;
            if(cancel.Name=="cancel")
            {
                hide_bottom("wr_comment");
            }
            else if (cancel.Name == "reply_cancel")
            {
                string s = ((cancel.Parent).Parent).Parent.Name;
                MessageBox.Show(s);
                hide_bottom(s);
            }
        }

        private void hide_bottom(string s )
        {            

            comment_bottom(false,s);
           if(s== "wr_comment")
            {
                foreach (Control cmnt in over_controll.active_panel.Controls)
                {
                    if (cmnt.Name.ToString() == "cmnt")
                    {
                        foreach (Control wr_comment_panel in cmnt.Controls)
                        {
                            if (wr_comment_panel.Name.ToString() == "wr_comment_panel")
                            {
                                foreach (Control wr_comment in wr_comment_panel.Controls)
                                {
                                    if (wr_comment.Name.ToString() == "wr_comment")
                                    {
                                        wr_comment.Text = "Add a comment";
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
           else
            {
                foreach (Control cmnt in over_controll.active_panel.Controls)
                {
                    if (cmnt.Name.ToString() == "cmnt")
                    {
                        foreach (Control wr_reply in cmnt.Controls)
                        {
                            if (wr_reply.Name.ToString() == s)
                            {
                                foreach (Control wr_comment_panel in wr_reply.Controls[0].Controls)
                                {
                                    if (wr_comment_panel.Name.ToString() == "wr_comment_panel")
                                    {
                                        foreach (Control wr_comment in wr_comment_panel.Controls)
                                        {
                                            if (wr_comment.Name.ToString() == s)
                                            {
                                                wr_comment.Text = "Add a comment";
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            
        }
        private void comment_bottom(bool show,string main)
        {
           // MessageBox.Show(main);

            if (main == "wr_comment")
            {
                foreach (Control cmnt in over_controll.active_panel.Controls)
                {
                    if (cmnt.Name.ToString() == "cmnt")
                    {
                        foreach (Control wr_comment_panel in cmnt.Controls)
                        {
                            if (wr_comment_panel.Name.ToString() == "wr_comment_panel")
                            {
                                foreach (Control comnt_comnt in wr_comment_panel.Controls)
                                {
                                    if (comnt_comnt.Name.ToString() == "comnt_comnt" || comnt_comnt.Name.ToString() == "cancel" || comnt_comnt.Name.ToString() == "spoiler_panel")
                                    {
                                        if (show)
                                            comnt_comnt.Show();
                                        else
                                            comnt_comnt.Hide();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(main);
                foreach (Control cmnt in over_controll.active_panel.Controls)
                {
                    if (cmnt.Name.ToString() == "cmnt")
                    {
                        foreach (Control wr_reply in cmnt.Controls)
                        {
                            if (wr_reply.Name.ToString() == main)
                            {
                                foreach (Control wr_comment_panel in wr_reply.Controls[0].Controls)
                                {
                                    if (wr_comment_panel.Name.ToString() == "wr_comment_panel")
                                    {
                                        foreach (Control comnt_comnt in wr_comment_panel.Controls)
                                        {
                                            if (comnt_comnt.Name.ToString() == "reply_comnt_comnt" || comnt_comnt.Name.ToString() == "reply_cancel" || comnt_comnt.Name.ToString() == "spoiler_panel")
                                            {
                                                if (show)
                                                    comnt_comnt.Show();
                                                else
                                                {
                                                    comnt_comnt.Hide();
                                                    wr_reply.Hide();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }



        }
        protected void comment_write_TextChanged(object sender, EventArgs e)
        {
            Control txt = (Control)sender;
            if(txt.Name == "wr_comment")
            {
                foreach (Control cmnt in over_controll.active_panel.Controls)
                {
                    if (cmnt.Name.ToString() == "cmnt")
                    {
                        foreach (Control wr_comment_panel in cmnt.Controls)
                        {
                            if (wr_comment_panel.Name.ToString() == "wr_comment_panel")
                            {
                                foreach (Control comnt_comnt in wr_comment_panel.Controls)
                                {
                                    if (comnt_comnt.Name.ToString() == "comnt_comnt")
                                    {
                                        if (txt.Text.Length > 0 || txt.Text != "Add a comment")
                                        {
                                            comnt_comnt.BackColor = Color.FromArgb(5, 70, 170);
                                        }

                                        if (txt.Text.Length == 0 || txt.Text == "Add a comment")
                                        {
                                            comnt_comnt.BackColor = Color.FromArgb(200, 200, 200);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Control cmnt in over_controll.active_panel.Controls)
                {
                    if (cmnt.Name.ToString() == "cmnt")
                    {
                        foreach (Control wr_reply in cmnt.Controls)
                        {
                            if (wr_reply.Name.ToString() == txt.Name)
                            {
                                foreach (Control wr_comment_panel in wr_reply.Controls[0].Controls)
                                {
                                    if (wr_comment_panel.Name.ToString() == "wr_comment_panel")
                                    {
                                        foreach (Control comnt_comnt in wr_comment_panel.Controls)
                                        {
                                            if (comnt_comnt.Name.ToString() == "reply_comnt_comnt")
                                            {
                                                if (txt.Text.Length > 0 || txt.Text != "Add a comment")
                                                {
                                                    comnt_comnt.BackColor = Color.FromArgb(5, 70, 170);
                                                }

                                                if (txt.Text.Length == 0 || txt.Text == "Add a comment")
                                                {
                                                    comnt_comnt.BackColor = Color.FromArgb(200, 200, 200);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
                 
        }

        protected void comnt_comnt_click(object sender, EventArgs e, content content_obj)
        {
            Control comment = (Control)sender;

            if (comment.BackColor != Color.FromArgb(5, 70, 170))
                return;
            if (comment.Name == "reply_comnt_comnt")
            {
                Control wr_comment_panel = comment.Parent; 
                string commenttext = comment.Parent.Controls[2].Text;
                string check = "0";
                string parent = "";
                foreach (Control a in wr_comment_panel.Controls)
                {
                    if (a.Name == "spoiler_panel")
                    {
                        CheckBox sp= (CheckBox)a.Controls[0];
                        if(sp.Checked)
                        {
                            check = "1";
                        }

                    }
                    if (a.Name == "parent")
                    {
                        Control ab = a.Controls[0];
                       //MessageBox.Show(ab.Name);
                        parent = ab.Name; 

                    }
                }
                //Control spoiler = comment.Parent.Controls[6];
                //MessageBox.Show(spoiler.Name);
                add_comment(parent, commenttext, check, content_obj);
                hide_bottom("write_comment_reply_" + parent);


            }
            foreach (Control cmnt in over_controll.active_panel.Controls)
            {
                if (cmnt.Name.ToString() == "cmnt")
                {
                    foreach (Control wr_comment_panel in cmnt.Controls)
                    {
                        if (wr_comment_panel.Name.ToString() == "wr_comment_panel")
                        {
                            string check = "0";

                            foreach (Control wr_comment in wr_comment_panel.Controls)
                            {
                                if (wr_comment.Name.ToString() == "spoiler_panel")
                                {
                                    foreach (CheckBox a in wr_comment.Controls)
                                    {
                                        if(a.Checked)
                                        {
                                            check = "1";
                                        }
                                    }
                                }
                            }
                            foreach (Control wr_comment in wr_comment_panel.Controls)
                            {

                                if (wr_comment.Name.ToString() == "wr_comment")
                                {
                                    string s = wr_comment.Text;
                                    add_comment(s, check,content_obj);
                                    hide_bottom("wr_comment");
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }

        protected void spoiler_change(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;

            if (check.Checked)
            {
                check.ForeColor = Color.FromArgb(5, 70, 170);
            }
            else
                check.ForeColor = Color.FromArgb(200,200,200);

        }

        protected void reply_click(object sender, EventArgs e)
        {
            Control reply = (Control)sender;
           // MessageBox.Show(reply.Name.ToString());

            foreach( Control cmnt in over_controll.active_panel.Controls)
            {
                if (cmnt.Name == "cmnt")
                {
                    foreach (Control wr_reply in cmnt.Controls)
                    {
                        if(wr_reply.Name == "write_comment_reply_" + reply.Name.ToString())
                        {
                            wr_reply.Show();
                        }
                    }
                }
            }

        }
        protected void love_click(object sender, EventArgs e)
        {
            Control id = ((Control)sender).Parent.Parent.Parent;
            //MessageBox.Show(id.Name);

            string s = "select count(*) as no from comment_love where cmnt_id = '" + id.Name + "' and u_id = '" + user_log_in.UserID + "'";
            if (count(s) == "0")
            {
                string ins = "INSERT INTO `comment_love` (`cmnt_id`, `u_id`) VALUES ('" + id.Name + "', '" + user_log_in.UserID + "')";
                insert(ins);
                ((PictureBox)sender).Image = Properties.Resources.love2;
                ((Control)sender).Parent.Controls[1].Text = (Int32.Parse(((Control)sender).Parent.Controls[1].Text) + 1).ToString();
            }
            else
            {
                string del = "DELETE FROM `comment_love` WHERE `cmnt_id` = '" + id.Name + "'";
                insert(del);
                ((PictureBox)sender).Image = Properties.Resources.love1;
                ((Control)sender).Parent.Controls[1].Text = (Int32.Parse(((Control)sender).Parent.Controls[1].Text) - 1).ToString();

            }
        }
        protected void ep_click(object sender, EventArgs e, content content_obj)
        {

            Control id = ((Control)sender);
            if(user_log_in.pos=="guest")
            {
                MessageBox.Show("Your payment expired");
                return; 
            }
            if(!player_data.run)
            {
                player_data.run = true;
                Form player = new player_form();
                player_data.get_video_media(id.Name, content_obj);
                player.Show();
            }



        }
        protected void user_click_to_profile(object sender, EventArgs e)
        {
            Control id = ((Control)sender);
            string id_click = id.Name;
            over_controll.temp = over_controll.active_panel;
            create_profile(id_click);
            over_controll.temp.Dispose();

        }







    }
}
