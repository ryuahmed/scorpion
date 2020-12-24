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
        private void create_profile( string id)
        {
            body_panel();
            user_profile user = new user_profile();
            user.get_data(id);
            head_body("Profile : " +user.id);
            create_user_top_section(user);
            create_history(user);
            add_footer();


        }
        private void create_user_top_section(user_profile user)
        {
            Panel top_all = create_panel("top_all", over_controll.av_body_size_x,200,Color.Transparent,over_controll.active_panel);
            over_controll.active_panel.Controls.Add(top_all);

            PictureBox dp =  new PictureBox()
            {
                Name = "dp",
                Size = new Size(180, 180),
                Location = new Point(10, 10),
                Margin = new Padding(0, 0, 0, 0),
                Parent = top_all
            };
            top_all.Controls.Add(dp);
            dp.Image =  new Bitmap(user.dp);
            dp.SizeMode = PictureBoxSizeMode.StretchImage;

            Color text_color = Color.FromArgb(50, 50, 50);

            FlowLayoutPanel user_details = create_flowpanel("user_details",300,180,Color.Transparent, top_all);
            top_all.Controls.Add(user_details);
            user_details.Location = new Point(210,10);

            Panel id = create_panel("id", 400, 20,Color.Transparent, user_details);
            user_details.Controls.Add(id);
            Label l_id = create_label("l_id","user : " + user.id , 400, 20, Color.Transparent,text_color ,id);
            id.Controls.Add(l_id);
            l_id.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_id.TextAlign = ContentAlignment.MiddleLeft;

            Panel type = create_panel("type", 400, 20, Color.Transparent, user_details);
            user_details.Controls.Add(type);
            Label l_type = create_label("l_type", "User Class : " + user.type, 400, 20 ,Color.Transparent, text_color, type);
            type.Controls.Add(l_type);
            l_type.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_type.TextAlign = ContentAlignment.MiddleLeft;

            Panel joined = create_panel("joined", 400, 20, Color.Transparent, user_details);
            user_details.Controls.Add(joined);
            Label l_joined = create_label("l_joined", "Joined : " + user.jdate, 400, 20, Color.Transparent, text_color, joined);
            joined.Controls.Add(l_joined);
            l_joined.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_joined.TextAlign = ContentAlignment.MiddleLeft;

            Panel lastdate = create_panel("lastdate", 400, 20, Color.Transparent, user_details);
            user_details.Controls.Add(lastdate);
            Label l_lastdate = create_label("l_lastdate", "Last Visited : " + user.ldate, 400, 20, Color.Transparent, text_color, lastdate);
            lastdate.Controls.Add(l_lastdate);
            l_lastdate.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_lastdate.TextAlign = ContentAlignment.MiddleLeft;

            FlowLayoutPanel additional_info = create_flowpanel("additional_info", 300, 180, Color.Transparent, top_all);
            top_all.Controls.Add(additional_info);
            additional_info.Location = new Point(520, 10);

            Panel name = create_panel("lastdate", 400, 20, Color.Transparent, additional_info);
            additional_info.Controls.Add(name);
            Label l_name = create_label("l_name", "Name : " + user.fname + " "+user.lname, 400, 20, Color.Transparent, text_color, name);
            name.Controls.Add(l_name);
            l_name.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_name.TextAlign = ContentAlignment.MiddleLeft;

            Panel email = create_panel("email", 400, 20, Color.Transparent, additional_info);
            additional_info.Controls.Add(email);
            Label l_email = create_label("l_email", "Email : " + user.email, 400, 20, Color.Transparent, text_color, email);
            email.Controls.Add(l_email);
            l_email.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_email.TextAlign = ContentAlignment.MiddleLeft;

            Panel phone = create_panel("phone", 400, 20, Color.Transparent, additional_info);
            additional_info.Controls.Add(phone);
            Label l_phone = create_label("l_phone", "Phone Number : " + user.phone, 400, 20, Color.Transparent, text_color, phone);
            phone.Controls.Add(l_phone);
            l_phone.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_phone.TextAlign = ContentAlignment.MiddleLeft;

            Panel age = create_panel("age", 400, 20, Color.Transparent, additional_info);
            additional_info.Controls.Add(age);
            Label l_age = create_label("l_age", "Age : " + user.age, 400, 20, Color.Transparent, text_color, age);
            age.Controls.Add(l_age);
            l_age.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_age.TextAlign = ContentAlignment.MiddleLeft;


            Panel country = create_panel("country", 400, 20, Color.Transparent, additional_info);
            additional_info.Controls.Add(country);
            Label l_country = create_label("l_country", "Country : " + user.region, 400, 20, Color.Transparent, text_color, country);
            country.Controls.Add(l_country);
            l_country.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_country.TextAlign = ContentAlignment.MiddleLeft;

            FlowLayoutPanel bottom = create_flowpanel("additional_info", 500, 180, Color.Transparent, top_all);
            top_all.Controls.Add(bottom);
            bottom.Location = new Point(830, 10);
            if(user.owner)
            {
                Panel privacy_panel = create_panel("privacy", 400, 30, Color.Transparent, bottom);
                bottom.Controls.Add(privacy_panel);
                Button privacy = create_button("privacy","Edit Privacy", 150, 30, text_color, Color.Transparent, privacy_panel);
                privacy.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
                privacy.Click += (sender, EventArgs) => { click_privacy_change(sender, EventArgs, user); };


                Panel privacy_show_panel = create_panel("privacy_edit", 400, 180, Color.Transparent, bottom);
                bottom.Controls.Add(privacy_show_panel);
                Label inf_show = create_label("inf_show", "Show information : ", 0, 0, Color.Transparent, text_color, privacy_show_panel);
                inf_show.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                inf_show.Location = new Point(0, 10);
                privacy_show_panel.Controls.Add(inf_show);
                inf_show.AutoSize = true;
                string x = "Only me"; 
                if (user.info)
                {
                    x = "Public";

                }
                Label info_a_show = create_label("info", x, 80, 30, Color.Transparent, text_color, privacy_show_panel);
                info_a_show.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                info_a_show.Location = new Point(150, 10);
                Label fromother_show = create_label("fromother_show", "From others  : ", 0, 0, Color.Transparent, text_color, privacy_show_panel);
                fromother_show.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                fromother_show.Location = new Point(0, 50);
                privacy_show_panel.Controls.Add(fromother_show);
                fromother_show.AutoSize = true;
                string y = "Hide";
                if (user.other)
                {
                    y = "Show";

                }
                Label fromother_a_show = create_label("fromother_a_show", y, 80, 30, Color.Transparent, text_color, privacy_show_panel);
                fromother_a_show.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                fromother_a_show.Location = new Point(150, 50);
                privacy_show_panel.Controls.Add(fromother_a_show);
                privacy_show_panel.Controls.Add(info_a_show);


                Panel privacy_edit_panel = create_panel("privacy_edit", 400, 180, Color.Transparent, bottom);
                bottom.Controls.Add(privacy_edit_panel);
                privacy_edit_panel.Hide();
                Label inf = create_label("info","Show information : ",0,0,Color.Transparent,text_color, privacy_edit_panel);
                inf.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                inf.Location = new Point(0,10);
                privacy_edit_panel.Controls.Add(inf);
                inf.AutoSize = true;

                Color onlyme = over_controll.color_active  , publi = text_color; 
                if (user.info)
                {
                    onlyme = text_color;
                    publi = over_controll.color_active; 

                }
                Button info_a = create_button("info", "Only me", 80, 30, Color.Transparent, onlyme, privacy_edit_panel);
                info_a.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                info_a.Location = new Point(150, 0);
                info_a.Click += (sender, EventArgs) => { click_privacy_change_info(sender, EventArgs, user); };
                Button info_b = create_button("info", "Public", 80, 30, Color.Transparent, publi, privacy_edit_panel);
                info_b.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                info_b.Location = new Point(230, 0);
                info_b.Click += (sender, EventArgs) => { click_privacy_change_info(sender, EventArgs, user); };


                Label fromother = create_label("fromother", "From others  : ", 0, 0, Color.Transparent, text_color, privacy_edit_panel);
                fromother.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                fromother.Location = new Point(0, 50);
                privacy_edit_panel.Controls.Add(fromother);
                fromother.AutoSize = true;

                Color hide = over_controll.color_active, show = text_color; 
                if (user.other)
                {
                    hide = text_color; 
                    show = over_controll.color_active; 
                }
                Button fromother_a = create_button("fromother_b", "Hide", 80, 30, Color.Transparent, hide, privacy_edit_panel);
                fromother_a.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                fromother_a.Location = new Point(150, 40);
                Button fromother_b = create_button("fromother_b", "Show", 80, 30, Color.Transparent, show, privacy_edit_panel);
                fromother_b.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                fromother_b.Location = new Point(230, 40);
                fromother_a.Click += (sender, EventArgs) => { click_privacy_change_other(sender, EventArgs, user); };
                fromother_b.Click += (sender, EventArgs) => { click_privacy_change_other(sender, EventArgs, user); };

                Button save = create_button("save", "Save", 100, 30, Color.Transparent, over_controll.color_active, privacy_edit_panel);
                save.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                save.Location = new Point(10, 80);
                save.Click += (sender, EventArgs) => { click_privacy_change_save(sender, EventArgs, user); };

                Button cancel = create_button("cancel", "Cancel", 100, 30, Color.Transparent, Color.IndianRed, privacy_edit_panel);
                cancel.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
                cancel.Location = new Point(130, 80);
                cancel.Click += (sender, EventArgs) => { click_privacy_change_cancel(sender, EventArgs, user); };

            }
            else
            {

                Panel message_panel = create_panel("message", 400, 30, Color.Transparent, bottom);
                bottom.Controls.Add(message_panel);
                Button message = create_button("message", "Send Message", 170, 30, text_color, Color.Transparent, message_panel);
                message.Font = new Font("Neuropolitical", 12, FontStyle.Bold);

                Panel freind_panel = create_panel("friend", 400, 30, Color.Transparent, bottom);
                bottom.Controls.Add(freind_panel);
                Button friend = create_button("friend", "Add Friend", 170, 30, text_color, Color.Transparent, freind_panel);
                friend.Font = new Font("Neuropolitical", 10, FontStyle.Bold);
            }


            Panel aa = create_panel("a", over_controll.av_body_size_x, 1, Color.Black, over_controll.active_panel);
            over_controll.active_panel.Controls.Add(aa);

            FlowLayoutPanel stat = create_flowpanel("stat", over_controll.av_body_size_x, 180, Color.Transparent, over_controll.active_panel);
            over_controll.active_panel.Controls.Add(stat);

            Panel header = create_panel("header", over_controll.av_body_size_x, 40, Color.Transparent, stat);
            stat.Controls.Add(header);
            Label l_header = create_label("l_header", "Statistics ", over_controll.av_body_size_x, 30, Color.Transparent, text_color, header);
            header.Controls.Add(l_header);
            l_header.AutoSize = false;
            l_header.Size = new Size(over_controll.av_body_size_x, 30);
            l_header.Font = new Font("Neuropolitical", 16, FontStyle.Bold);
            l_header.TextAlign = ContentAlignment.MiddleCenter;

            user.get_stat();

            Panel movie = create_panel("movie", over_controll.av_body_size_x, 20, Color.Transparent, stat);
            stat.Controls.Add(movie);
            Label l_movie = create_label("l_movie", "Movie :" + user.movie, over_controll.av_body_size_x, 20, Color.Transparent, text_color, movie);
            movie.Controls.Add(l_movie);
            l_movie.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_movie.TextAlign = ContentAlignment.MiddleCenter;

            Panel series = create_panel("series", over_controll.av_body_size_x, 20, Color.Transparent, stat);
            stat.Controls.Add(series);
            Label l_series = create_label("l_series", "Series :" + user.series, over_controll.av_body_size_x, 20 ,Color.Transparent, text_color, series);
            series.Controls.Add(l_series);
            l_series.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_series.TextAlign = ContentAlignment.MiddleCenter;
            series.Hide();
            Panel season = create_panel("season", over_controll.av_body_size_x, 20, Color.Transparent, stat);
            stat.Controls.Add(season);
            Label l_season = create_label("l_season", "Season :" + user.season, over_controll.av_body_size_x, 20, Color.Transparent, text_color, season);
            season.Controls.Add(l_season);
            l_season.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_season.TextAlign = ContentAlignment.MiddleCenter;

            Panel epi = create_panel("epi", over_controll.av_body_size_x, 20, Color.Transparent, stat);
            stat.Controls.Add(epi);
            Label l_epi = create_label("l_epi", "Episode : " + user.epi, over_controll.av_body_size_x, 20, Color.Transparent, text_color, epi);
            epi.Controls.Add(l_epi);
            l_epi.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
            l_epi.TextAlign = ContentAlignment.MiddleCenter;
            Panel aaa = create_panel("a", over_controll.av_body_size_x, 1, Color.Black, over_controll.active_panel);
            over_controll.active_panel.Controls.Add(aaa);

        }

        private void create_history(user_profile user)
        {
            user.get_hisotry();

            int max = 20;
            int page = (user.count_history/max)+1;
            //MessageBox.Show(page.ToString());
            Color text_color = Color.FromArgb(50, 50, 50);

            FlowLayoutPanel history = create_flowpanel("history", over_controll.av_body_size_x, 1000, Color.Transparent, over_controll.active_panel);
            over_controll.active_panel.Controls.Add(history);
            history.AutoSize = true;
            history.MaximumSize = new Size(over_controll.av_body_size_x, 0);
            Panel history_header = create_flowpanel("history_header", over_controll.av_body_size_x, 80, Color.Transparent, history);
            history.Controls.Add(history_header);
            Label l_history_header = create_label("l_header", "History ", over_controll.av_body_size_x, 30, Color.Transparent, text_color, history_header);
            history_header.Controls.Add(l_history_header);
            l_history_header.AutoSize = true; 
            l_history_header.AutoSize = false;
            l_history_header.Size = new Size(over_controll.av_body_size_x, 30);
            l_history_header.Font = new Font("Neuropolitical", 16, FontStyle.Bold);
            l_history_header.TextAlign = ContentAlignment.MiddleLeft;
            Label l_page = create_label("l_page", "Page : ", 100, 30, Color.Transparent, text_color, history_header);
            history_header.Controls.Add(l_page);
            l_page.AutoSize = true;
            l_page.Font = new Font("Neuropolitical", 14, FontStyle.Bold);
            for (int x = 0; x<page; x++)
            {
                Label l_page_no = create_label("l_page_no", (x + 1).ToString(), 30, 30, Color.Transparent, text_color, history_header);
                history_header.Controls.Add(l_page_no);
                l_page_no.AutoSize = true;
                l_page_no.Font = new Font("Neuropolitical", 14, FontStyle.Bold);
                l_page_no.MouseHover += new EventHandler(hover_history);
                l_page_no.MouseLeave += new EventHandler(leave_history);
                l_page_no.Click += (sender, EventArgs) => { click_history_page(sender, EventArgs, user); };

                if (x == 0)
                    l_page_no.BackColor = Color.FromArgb(200, 200, 200);


            }
            Panel history_panel = create_flowpanel("history_panel", over_controll.av_body_size_x, 40, Color.Transparent, history);
            history.Controls.Add(history_panel);
            history_panel.AutoSize = true;
            history_panel.MaximumSize = new Size(0,0);
            add_hisotry(user, history_panel, max,0);

           // MessageBox.Show(count.ToString());
        }

        private void add_hisotry(user_profile user, Control history, int max, int start  )
        {
            Color text_color = Color.FromArgb(50, 50, 50);
            if (user.count_history < max)
                max = user.count_history;
            for (int count = start; count < max ; count++)
            {
                Panel hisotry_content = create_panel(user.content_id[count], over_controll.av_body_size_x, 40, Color.FromArgb(220, 220, 220), history);
                history.Controls.Add(hisotry_content);
                hisotry_content.Margin = new Padding(5);
                hisotry_content.AutoSize = true;
                hisotry_content.MaximumSize = new Size(0, 0);
                Label l_hisotry_content = create_label(user.content_id[count], user.content_name[count], over_controll.av_body_size_x - 100, 30, Color.Transparent, text_color, hisotry_content);
                hisotry_content.Controls.Add(l_hisotry_content);
                l_hisotry_content.Font = new Font("Neuropolitical", 12, FontStyle.Regular);
                l_hisotry_content.TextAlign = ContentAlignment.MiddleLeft;
                Label l_hisotry_date = create_label(user.content_id[count], "Date : " + user.content_date[count], over_controll.av_body_size_x - 100, 30, Color.Transparent, text_color, hisotry_content);
                hisotry_content.Controls.Add(l_hisotry_date);
                l_hisotry_date.Font = new Font("Neuropolitical", 12, FontStyle.Regular);
                l_hisotry_date.TextAlign = ContentAlignment.MiddleLeft;

                hisotry_content.MouseHover += new EventHandler(hover_history);
                l_hisotry_content.MouseHover += new EventHandler(hover_l_history);
                l_hisotry_date.MouseHover += new EventHandler(hover_l_history);

                hisotry_content.MouseLeave += new EventHandler(leave_history);
                l_hisotry_content.MouseLeave += new EventHandler(leave_l_history);
                l_hisotry_date.MouseLeave += new EventHandler(leave_l_history);

                hisotry_content.Click += new EventHandler(click_history);
                l_hisotry_content.Click += new EventHandler(click_history);
                l_hisotry_date.Click += new EventHandler(click_history);

            }
            //MessageBox.Show(max.ToString());

        }

        protected void hover_l_history(object sender, EventArgs e)
        {
            hover(((Control)sender).Parent);

        }
        protected void leave_l_history(object sender, EventArgs e)
        {
            leave(((Control)sender).Parent);


        }
        protected void hover_history(object sender, EventArgs e)
        {
            hover(((Control)sender));
        }
        protected void leave_history(object sender, EventArgs e)
        {
            leave(((Control)sender));

        }

        private void hover(Control hov)
        {
            hov.BackColor = Color.FromArgb(200, 200, 200);
        }
        private void leave(Control hov)
        {
            hov.BackColor = Color.FromArgb(220, 220, 220);
            if(hov.Name== "l_page_no")
            {
                hov.BackColor = Color.Transparent;
            }
        }

        protected void click_history(object sender, EventArgs e)
        {
            Control id = ((Control)sender);
            go_to("content", id.Name.ToString());

        }
        protected void click_privacy_change_info(object sender, EventArgs e, user_profile obj)
        {
            Control id = ((Control)sender).Parent;
            foreach(Control a in id.Controls)
            {
                if (a.Name == "info")
                    a.ForeColor = Color.FromArgb(50, 50, 50);
            }
            ((Control)sender).ForeColor = over_controll.color_active;
            if(((Control)sender).Name == "info")
            {
                obj.change_info = false;
                if( ((Button)sender).Text == "Public" )
                    obj.change_info = true;
            }

        }

        protected void click_privacy_change_other(object sender, EventArgs e, user_profile obj)
        {
            Control id = ((Control)sender).Parent;
            foreach (Control a in id.Controls)
            {
                if (a.Name == "fromother_b")
                    a.ForeColor = Color.FromArgb(50, 50, 50);
            }
            ((Control)sender).ForeColor = over_controll.color_active;
            if (((Control)sender).Name == "fromother_b")
            {
                obj.change_other = false;
                if (((Button)sender).Text == "Show")
                    obj.change_other = true;
            }
        }
        protected void click_privacy_change_cancel(object sender, EventArgs e, user_profile obj)
        {
            ((Control)sender).Parent.Hide();
            ((Control)sender).Parent.Parent.Controls[1].Show();
        }
        protected void click_privacy_change_save(object sender, EventArgs e, user_profile obj)
        {
            string i = "0";
            string o = "0";
            if (obj.change_info)
                i = "1";
            if (obj.change_other)
                o = "1";
            string s = "UPDATE `user` SET `info_show` = '"+i+"', `other_show` = '"+o+"' WHERE `user`.`User_name` = '"+obj.id+"'";
            insert(s);
            ((Control)sender).Parent.Hide();
            ((Control)sender).Parent.Parent.Controls[1].Show();
            obj.info = obj.change_info;
            obj.other = obj.change_other; 
                
            foreach(Control a in ((Control)sender).Parent.Parent.Controls[1].Controls)
            {
                if(a.Name=="info")
                {
                    string x = "Only me";
                    if (obj.info)
                    {
                        x = "Public";

                    }
                    a.Text = x;
                }
                if(a.Name == "fromother_a_show")
                {
                    string y = "Hide";
                    if (obj.other)
                    {
                        y = "Show";

                    }
                    a.Text = y;

                }
            }
        }


        
        protected void click_privacy_change(object sender, EventArgs e, user_profile content_obj)
        {
            Control id = ((Control)sender);
            id.Parent.Parent.Controls[1].Hide();
            id.Parent.Parent.Controls[2].Show();


        }
        protected void click_history_page(object sender, EventArgs e, user_profile content_obj)
        {
            Control page_click = ((Control)sender);
            int start = Int32.Parse(page_click.Text);
            start = (start-1) * 20;
            MessageBox.Show(start.ToString());
            Control hisotry_header = page_click.Parent; 
            foreach(Control page_no in hisotry_header.Controls)
            {
                if(page_no.Name== "l_page_no")
                {
                    page_no.BackColor = Color.Transparent;
                }
            }
            foreach (Control history_panel in hisotry_header.Parent.Controls)
            {
                if(history_panel.Name == "history_panel")
                {
                    delete_all_child(history_panel);
                    add_hisotry(content_obj, history_panel, start+20, start);
                }
            }

            page_click.BackColor = Color.FromArgb(200,200,200);

        }



    }
}
