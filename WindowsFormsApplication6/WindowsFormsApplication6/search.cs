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
        private void create_search_result(string query, string tag)
        {
            max_check = -1;

            body_panel();
            head_body(tag);
                        //MessageBox.Show("asdad");

            add_filter();
            add_result_poster();

        }


        private void head_body( string tag)
        {
            add_header_panel();     // for space 
            Panel tag_panel = add_header_panel();

            Label Tag = new Label()
            {
                Name = tag,
                Text = tag,
                //Location = new Point(lx, ly),
                Font = new Font("OCR A", 18, FontStyle.Bold),
                Size = new Size(500, 50),
                // Parent = gen,
                // BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 100, 100),

            };
            tag_panel.Controls.Add(Tag);
            Panel underline = new Panel()
            {
                Name = "line",
                Size = new Size(over_controll.av_body_size_x, 1),
                Location = new Point(0, 40),
                BackColor = Color.FromArgb(100, 100, 100),
            };

            tag_panel.Controls.Add(underline);
            underline.BringToFront();

        }

        private void add_filter()
        {
            Panel whole_filter_panel = new Panel()
            {
                Name = "whole_filter_panel",
                Size = new Size(over_controll.av_body_size_x, 200),
                Location = new Point(0, 40),
                BackColor = over_controll.color_background,
            };
            over_controll.active_panel.Controls.Add(whole_filter_panel);




            Panel filter = new Panel()
            {
                BackColor = Color.FromArgb(220, 220, 220),
                Name = "filter",
                Size = new Size(950, 180),
                Location = new Point(130, 0),
                // BackColor = Color.FromArgb(220, 220, 220),
            };
            whole_filter_panel.Controls.Add(filter);
            filter.BringToFront();



            Panel type = create_flowpanel("type", 275, 30, result_search.bar_color, filter);
            filter.Controls.Add(type);
            type.Location = new Point(20, 20);
            //type.BorderStyle = BorderStyle.FixedSingle; 
            Label movie = create_label("Movie", "Movie", 100, 30, result_search.clicked_color, result_search.text, type);
            type.Controls.Add(movie);
            movie.Margin = new Padding(0);
            movie.TextAlign = ContentAlignment.MiddleRight;
            movie.Font = new Font("OCR A", 15, FontStyle.Bold);
            Label tv = create_label("TV", "Series", 100, 30, result_search.clicked_color, result_search.text, type);
            type.Controls.Add(tv);
            tv.Margin = new Padding(0);
            tv.TextAlign = ContentAlignment.MiddleLeft;
            tv.Font = new Font("OCR A", 15, FontStyle.Bold);
            Label both = create_label("both", "Both", 70, 30, result_search.default_color, result_search.text, type);
            type.Controls.Add(both);
            both.Margin = new Padding(5,0,0,0);
            both.TextAlign = ContentAlignment.MiddleCenter;
            both.Font = new Font("OCR A", 15, FontStyle.Bold);
            movie.Click += new EventHandler(type_click);
            tv.Click += new EventHandler(type_click);
            both.Click += new EventHandler(type_click);
            movie.MouseHover += new EventHandler(type_hover);
            tv.MouseHover += new EventHandler(type_hover);
            both.MouseHover += new EventHandler(type_hover);
            movie.MouseLeave += new EventHandler(type_leave);
            tv.MouseLeave += new EventHandler(type_leave);
            both.MouseLeave += new EventHandler(type_leave);

            Panel country_lang = create_flowpanel("country_lang", 275, 30, result_search.bar_color, filter);
            filter.Controls.Add(country_lang);
            country_lang.Location = new Point(20, 70);
            Label country = create_label("country", "-Country", 100, 30, result_search.default_color, result_search.text, country_lang);
            country_lang.Controls.Add(country);
            country.Margin = new Padding(0);
            country.TextAlign = ContentAlignment.MiddleRight;
            country.Font = new Font("OCR A", 12, FontStyle.Bold);
            Label language = create_label("language", "Language-", 100, 30, result_search.default_color, result_search.text, country_lang);
            country_lang.Controls.Add(language);
            language.Margin = new Padding(0);
            language.TextAlign = ContentAlignment.MiddleLeft;
            language.Font = new Font("OCR A", 12, FontStyle.Bold);
            Label any = create_label("any", "Any", 70, 30, result_search.default_color, result_search.text, country_lang);
            country_lang.Controls.Add(any);
            any.Margin = new Padding(5, 0, 0, 0);
            any.TextAlign = ContentAlignment.MiddleCenter;
            any.Font = new Font("OCR A", 15, FontStyle.Bold);
            Panel all_country = create_flowpanel("all_country", 100, 0, result_search.bar_color, filter);
            filter.Controls.Add(all_country);
            all_country.AutoScroll = true;
            add_country(all_country);
            all_country.Location = new Point(20, 70);
            all_country.Hide();
            all_country.BringToFront();
            all_country.Margin = new Padding(0);
            all_country.Font = new Font("OCR A", 12, FontStyle.Bold);
            Panel all_lang = create_flowpanel("all_lang", 100, 0, result_search.bar_color, filter);
            filter.Controls.Add(all_lang);
            all_lang.AutoScroll = true;
            add_lang(all_lang);
            all_lang.Location = new Point(120, 70);
            all_lang.Hide();
            all_lang.BringToFront();
            all_lang.Margin = new Padding(0);
            all_lang.Font = new Font("OCR A", 12, FontStyle.Bold);
            country.Click += new EventHandler(country_click);
            language.Click += new EventHandler(language_click);
            any.Click += new EventHandler(any_click);
            any.MouseHover += new EventHandler(any_hover);
            any.MouseLeave += new EventHandler(any_leave);


            Panel year = create_flowpanel("year", 300, 30, result_search.bar_color, filter);
            filter.Controls.Add(year);
            year.Location = new Point(310, 20);
            Label on = create_label("on", "Between", 70, 30, result_search.clicked_color, result_search.text, year);
            year.Controls.Add(on);
            on.Margin = new Padding(0, 0,5, 0);
            on.Font = new Font("OCR A", 10, FontStyle.Bold);
            on.TextAlign = ContentAlignment.MiddleCenter;
            Panel all_on = create_flowpanel("all_on", 70, 120, result_search.default_color, filter);
            filter.Controls.Add(all_on);
            all_on.AutoScroll = true;
            all_on.BringToFront();
            all_on.Location = new Point(310, 20);
            add_on(all_on);
            all_on.Hide();
            TextBox from = create_textbox("from", "From", 110, 30, result_search.default_color, result_search.text, year);
            year.Controls.Add(from);
            from.Margin = new Padding(0);
            from.TextAlign = HorizontalAlignment.Right;
            TextBox to = create_textbox("to", "To", 110, 30, result_search.default_color, result_search.text, year);
            year.Controls.Add(to);
            to.Margin = new Padding(5,0,0,0);
            to.TextAlign = HorizontalAlignment.Left;
            from.Font = new Font("OCR A", 20, FontStyle.Bold);
            to.Font = new Font("OCR A", 20, FontStyle.Bold);
            on.Click += new EventHandler(on_click);
            from.Click += new EventHandler(year_click);
            to.Click += new EventHandler(year_click);
            from.KeyPress += new KeyPressEventHandler(episode_KeyPress);
            to.KeyPress += new KeyPressEventHandler(episode_KeyPress);
            from.TextChanged += new EventHandler(year_change);
            to.TextChanged += new EventHandler(year_change);

            Panel status = create_flowpanel("status", 300, 30, result_search.bar_color, filter);
            filter.Controls.Add(year);
            status.Location = new Point(310, 70);
            //status.BorderStyle = BorderStyle.FixedSingle;
            Label completed = create_label("completed", "Completed", 100, 30, result_search.clicked_color, result_search.text, status);
            status.Controls.Add(completed);
            completed.Margin = new Padding(0);
            completed.TextAlign = ContentAlignment.MiddleRight;
            Label ongoing = create_label("ongoing", "Ongoing", 100, 30, result_search.clicked_color, result_search.text, status);
            status.Controls.Add(ongoing);
            ongoing.Margin = new Padding(0);
            ongoing.TextAlign = ContentAlignment.MiddleCenter;
            Label upcoming = create_label("upcoming", "Upcoming", 100, 30, result_search.clicked_color, result_search.text, status);
            status.Controls.Add(upcoming);
            upcoming.Margin = new Padding(0);
            upcoming.TextAlign = ContentAlignment.MiddleLeft;
            completed.Font = new Font("OCR A", 12, FontStyle.Bold);
            ongoing.Font = new Font("OCR A", 12, FontStyle.Bold);
            upcoming.Font = new Font("OCR A", 12, FontStyle.Bold);
            completed.Click += new EventHandler(status_click);
            ongoing.Click += new EventHandler(status_click);
            upcoming.Click += new EventHandler(status_click);
            completed.MouseHover += new EventHandler(status_hover);
            ongoing.MouseHover += new EventHandler(status_hover);
            upcoming.MouseHover += new EventHandler(status_hover);
            completed.MouseLeave += new EventHandler(status_leave);
            ongoing.MouseLeave += new EventHandler(status_leave);
            upcoming.MouseLeave += new EventHandler(status_leave);

            Panel genre = create_flowpanel("genre", 500, 180, Color.FromArgb(220, 220, 220), filter);
            filter.Controls.Add(genre);
            genre.Location = new Point(over_controll.av_body_size_x - 550, 10);
            add_genre(genre);

            TextBox search_filter = new TextBox()
            {
                Name = "search_filter",
                Text = "Keyword",
                Location = new Point(-50 + 950/ 2 - 180, 210-70),
                Font = new Font("OCR A", 15, FontStyle.Bold),

                Size = new Size(150, 30),
                Parent = filter,
                BackColor = Color.FromArgb(220, 220, 220),
                ForeColor = over_controll.color_menubar_active,
                BorderStyle = BorderStyle.None,

            };
            filter.Controls.Add(search_filter);
            search_filter.BringToFront();

            Panel search_filter_panel = new Panel()
            {
                Name = "search_filter_panel",
                Location = new Point(-50 + 950 / 2 - 180, 245-70),
                Size = new Size(150, 1),
                Parent = filter,
                BackColor = over_controll.color_menubar_active,

            };
            filter.Controls.Add(search_filter_panel);
            search_filter_panel.BringToFront();

            Label filterbottom = new Label()
            {
                Name = "filterbottom",
                Text = "Filter",
                Location = new Point(-50 + 950 / 2, 210-70),
                Font = new Font("OCR A", 15, FontStyle.Bold),
                Size = new Size(100, 30),
                // Parent = gen,
                BackColor = over_controll.color_menubar_active,
                ForeColor = Color.FromArgb(220, 220, 220),
                TextAlign = ContentAlignment.TopCenter,

            };
            filter.Controls.Add(filterbottom);
            filterbottom.BringToFront();
            filterbottom.Click += new EventHandler(filter_click);

        }


        protected void type_click(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control type = buttom.Parent;        
            if(buttom.Name == "both")
            {
                result_search.type = 2;
                type.Controls[0].BackColor = result_search.clicked_color;
                type.Controls[1].BackColor = result_search.clicked_color;
                buttom.BackColor = result_search.default_color;

            }
            if (buttom.Name == "Movie")
            {
                result_search.type = 0;
                type.Controls[0].BackColor = result_search.clicked_color;
                type.Controls[1].BackColor = result_search.default_color;
                type.Controls[2].Text = "Both";            
            }
            if (buttom.Name == "TV")
            {
                result_search.type = 1;
                type.Controls[1].BackColor = result_search.clicked_color;
                type.Controls[0].BackColor = result_search.default_color;
                type.Controls[2].Text = "Both";               
            }

        }
        protected void type_hover(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control type = buttom.Parent;
            if (buttom.Name == "both")
            {
                if (result_search.type == 2)
                    return; 
                else
                {
                    buttom.BackColor = result_search.hover_color;
                }
            }
            if (buttom.Name == "Movie")
            {
                if (result_search.type == 0 || result_search.type == 2)
                    return;
                else
                {
                    buttom.BackColor = result_search.hover_color;
                }
            }
            if (buttom.Name == "TV")
            {
                if (result_search.type == 1 || result_search.type == 2)
                    return;
                else
                {
                    buttom.BackColor = result_search.hover_color;
                }
            }

        }

        protected void type_leave(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control type = buttom.Parent;
            if (buttom.Name == "both")
            {
                if (result_search.type == 2)
                    return;
                else
                {
                    buttom.BackColor = result_search.default_color;
                }
            }
            if (buttom.Name == "Movie")
            {
                if (result_search.type == 0 || result_search.type == 2)
                    return;
                else
                {
                    buttom.BackColor = result_search.default_color;
                }
            }
            if (buttom.Name == "TV")
            {
                if (result_search.type == 1 || result_search.type == 2)
                    return;
                else
                {
                    buttom.BackColor = result_search.default_color;
                }
            }
        }
        protected void status_click(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control type = buttom.Parent;
            if (buttom.Name == "completed")
            {
                if(result_search.cp)
                {
                    result_search.cp = false;
                    buttom.BackColor = result_search.default_color; 
                }
                else
                {
                    result_search.cp = true;
                    buttom.BackColor = result_search.clicked_color;
                }
            }
            if (buttom.Name == "ongoing")
            {
                if (result_search.on)
                {
                    result_search.on = false;
                    buttom.BackColor = result_search.default_color;
                }
                else
                {
                    result_search.on = true;
                    buttom.BackColor = result_search.clicked_color;
                }
            }
            if (buttom.Name == "upcoming")
            {
                if (result_search.up)
                {
                    result_search.up = false;
                    buttom.BackColor = result_search.default_color;
                }
                else
                {
                    result_search.up = true;
                    buttom.BackColor = result_search.clicked_color;
                }
            }

        }
        protected void status_hover(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control type = buttom.Parent;
            if (buttom.Name == "completed")
            {
                if (!result_search.cp)
                {
                    buttom.BackColor = result_search.hover_color;
                }

            }
            if (buttom.Name == "ongoing")
            {
                if (!result_search.on)
                {
                    buttom.BackColor = result_search.hover_color;

                }
            }
            if (buttom.Name == "upcoming")
            {
                if (!result_search.up)
                {
                    buttom.BackColor = result_search.hover_color;

                }
            }
        }
        protected void status_leave(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control type = buttom.Parent;
            if (buttom.Name == "completed")
            {
                if (!result_search.cp)
                {
                    buttom.BackColor = result_search.default_color;
                }

            }
            if (buttom.Name == "ongoing")
            {
                if (!result_search.on)
                {
                    buttom.BackColor = result_search.default_color;

                }
            }
            if (buttom.Name == "upcoming")
            {
                if (!result_search.up)
                {
                    buttom.BackColor = result_search.default_color;

                }
            }
        }

        protected void country_click(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control filter = buttom.Parent.Parent;
            close_all_list(filter);

            foreach (Control  cntry_list in filter.Controls)
            {
                if(cntry_list.Name== "all_country")
                {
                    cntry_list.Show();
                }
            }

        }
        protected void language_click(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control filter = buttom.Parent.Parent;
            close_all_list(filter);

            foreach (Control cntry_list in filter.Controls)
            {
                if (cntry_list.Name == "all_lang")
                {
                    cntry_list.Show();
                }
            }
        }
        protected void any_click(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control country_lang = buttom.Parent;
            Control filter = country_lang.Parent;
            close_all_list(filter);
            country_lang.Controls[0].BackColor = result_search.default_color;
            country_lang.Controls[1].BackColor = result_search.default_color;
            country_lang.Controls[0].Text = "-Country";
            country_lang.Controls[1].Text = "Language-";
            result_search.country = "";
            result_search.lang = "";

        }

        private void close_all_list(Control filter)
        {
            foreach (Control clo in filter.Controls)
            {
                if (clo.Name == "all_country" || clo.Name == "all_lang")
                {
                    clo.Hide();
                }
            }
        }
        protected void any_hover(object sender, EventArgs e)
        {
            if(result_search.country != "" || result_search.lang != "")
            {
                Control buttom = (Control)sender;
                buttom.BackColor = result_search.hover_color;
            }
        }
        protected void any_leave(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            buttom.BackColor = result_search.default_color;

        }


        protected void cntry_hover(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            buttom.BackColor = result_search.hover_color;
        }

        protected void cntry_leaeve(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            buttom.BackColor = result_search.default_color;
        }
        protected void cntry_click(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control filter = buttom.Parent.Parent;

            result_search.country = buttom.Name;
            buttom.Parent.Hide();
            foreach (Control country_lang in filter.Controls)
            {
                if(country_lang.Name== "country_lang")
                {
                    Label country = (Label)country_lang.Controls[0];
                    country.Text = result_search.country;
                    country.BackColor = result_search.clicked_color;
                }
            }

        }




        protected void lang_click(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control filter = buttom.Parent.Parent;

            result_search.lang = buttom.Name;
            buttom.Parent.Hide();
            foreach (Control country_lang in filter.Controls)
            {
                if (country_lang.Name == "country_lang")
                {
                    Label country = (Label)country_lang.Controls[1];
                    country.Text = result_search.lang;
                    country.BackColor = result_search.clicked_color;
                }
            }
        }
        protected void year_click(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Parent.Controls[2].Text == "")
                textbox.Parent.Controls[2].Text = "To";
            if (textbox.Parent.Controls[1].Text == "")
                textbox.Parent.Controls[1].Text = "From";

            if (textbox.Text == "From" )
            {
                textbox.Text = "";

            }
            if ( textbox.Text == "To")
            {
                textbox.Text = "";
            }
            if (textbox.Text == "Year")
            {
                textbox.Text = "";
            }

        }
        protected void on_click(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control filter = buttom.Parent.Parent;
            close_all_list(filter);

            foreach (Control cntry_list in filter.Controls)
            {
                if (cntry_list.Name == "all_on")
                {
                    cntry_list.Show();
                }
            }
        }

        protected void all_on_click(object sender, EventArgs e)
        {
            Control buttom = (Control)sender;
            Control on = buttom.Parent;
            on.Hide();
            Control filter = on.Parent;
            foreach (Control clo in filter.Controls)
            {
                if (clo.Name == "year")
                {
                    Label country = (Label)clo.Controls[0];
                    country.Text = buttom.Name;
                    country.BackColor = result_search.clicked_color;
                    if (country.Text == "Between")
                    {
                        clo.Size = new Size(300,30);
                        Control from = clo.Controls[1];
                        Control to = clo.Controls[2];
                        from.Text = "From";
                        to.Text = "To";
                        clo.Controls[2].Show();
                        result_search.betn = true;
                        result_search.before = false;
                        result_search.after = false;
                        result_search.on_this = false;
                    }
                    else
                    {
                        clo.Size = new Size(185, 30);
                        clo.Controls[2].Hide();
                        Control from = clo.Controls[1];
                        from.Text = "Year";
                        result_search.betn = false;
                        if (country.Text == "On")
                        {
                            result_search.before = false;
                            result_search.after = false;
                            result_search.on_this = true;
                        }
                        if (country.Text == "After")
                        {
                            result_search.before = false;
                            result_search.after = true;
                            result_search.on_this = false;
                        }
                        if (country.Text == "Before")
                        {
                            result_search.before = true;
                            result_search.after = false;
                            result_search.on_this = false;
                        }
                    }
                }
            }

        }
        protected void year_change(object sender, EventArgs e)
        {
            Control tex = (Control)sender;
            if (tex.Name == "from")
                result_search.from = tex.Text;

            if (tex.Name == "to")
                result_search.to = tex.Text;

            //MessageBox.Show(result_search.to);

        }
        protected void filter_click(object sender, EventArgs e)
        {
            result_search.name.Clear();
            result_search.id.Clear();
            result_search.poster.Clear();
            foreach(Control dele in over_controll.active_panel.Controls)
            {
                foreach (Control del in over_controll.active_panel.Controls)
                    if (del.Name == "poster_panel")
                        del.Dispose();
            }
            //delete_all_child();
            get_filter_result();
            add_result_poster();
        }
        private void add_result_poster()
        {

            int i = 0,j=0;
            string[,] s = new string[5, 2];
            foreach (string link in result_search.poster)
            {
                s[i, 0] = link;
                s[i, 1] = result_search.id[j];
                i++;
                j++;
                if (i == 5)
                {
                    Panel poster_panel = add_poster_panel();
                    Panel space = new Panel()
                    {
                        Name = "search_filter_panel",
                        Size = new Size(100, 100),
                        BackColor = Color.Transparent,
                    };
                    poster_panel.Controls.Add(space);
                    add_poster(poster_panel, i, s);
                    i = 0;
                }

            }

            Panel poster_panel_a = add_poster_panel();
            Panel space_a = new Panel()
            {
                Name = "search_filter_panel",
                Size = new Size(100, 100),
                BackColor = Color.Transparent,
            };
            poster_panel_a.Controls.Add(space_a);
            add_poster(poster_panel_a, i, s);
        }

        


    }
}
