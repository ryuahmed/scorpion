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
        private void creat_homepage()
        {
            body_panel();
            check_user();

            add_slide_container();
            get_cover();
            cover_show();
            // add_test();
            add_home_content();
            add_footer();
        }

        private void check_user()
        {
            //guest_active.BringToFront();
           // guest_active.Show();
            if (user_log_in.pos == "Staff" || user_log_in.pos == "Moderator" || user_log_in.pos == "Admin")
            {
                adminicon.Show();
            }

        }

        private void add_home_content()
        {


            string[] home_body_label_text = new string[] { "Continue Watching", "Trending", "You may like", "Coming This Month" };

            for (int i = 0; i < 4; i++)
            {
                string[,] c = new string[5, 2];

                if (i == 0)
                {
                    //continued watching er code hobe
                    continue;
                }

                if (i == 1)
                {
                     get_trending();
                }
                if (i == 2)
                {
                    get_suggestion();
                }
                if (i == 3)
                {
                    get_coming();
                }

                //add_test();



                int j = 0;
                string[,] s = new string[5, 2];
                foreach (string link in result_search.poster)
                {

                    s[j, 0] = link;
                    s[j, 1] = result_search.id[j];
                    j++;
                    if (j == 5)
                    {
                        if (i == 3)
                        {
                            MessageBox.Show("a");
                        }
                        add_title(i, home_body_label_text[i]);

                        Panel poster_panel = add_poster_panel();
                        add_poster(poster_panel, j, s);
                        j = 0;
                        Panel more = new Panel()
                        {
                            Name = "more",
                            Size = new Size(50, 260),
                            BackColor = Color.Transparent,
                            BorderStyle = BorderStyle.None,
                            // AutoScroll = true,
                        };
                        poster_panel.Controls.Add(more);
                        PictureBox right = new PictureBox()
                        {
                            Name = "right",
                            Size = new Size(50, 70),
                            Location = new Point(0, 100),
                            Parent = more,
                            //Image = new Bitmap(c),
                            BackgroundImage = Properties.Resources.right,
                            BackgroundImageLayout = ImageLayout.Zoom,
                            BackColor = Color.Transparent,

                        };
                        more.Controls.Add(right);
                        break;
                    }
                }
                if (j < 5 && j>0)
                {
                    add_title(i, home_body_label_text[i]);

                    Panel poster_panel = add_poster_panel();
                    add_poster(poster_panel, j, s);
                    j = 0;
                    Panel more = new Panel()
                    {
                        Name = "more",
                        Size = new Size(50, 260),
                        BackColor = Color.Transparent,
                        BorderStyle = BorderStyle.None,
                        // AutoScroll = true,
                    };
                    poster_panel.Controls.Add(more);
                    PictureBox right = new PictureBox()
                    {
                        Name = "right",
                        Size = new Size(50, 70),
                        Location = new Point(0, 100),
                        Parent = more,
                        //Image = new Bitmap(c),
                        BackgroundImage = Properties.Resources.right,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        BackColor = Color.Transparent,

                    };
                    more.Controls.Add(right);
                }




            }


        }

        private void add_title(int i, string s)
        {
            Panel text_panel = add_header_panel();

            Label label = new Label()
            {
                Name = i.ToString(),
                Text = s,
                Location = new Point(60, 0),
                Font = new Font("Neuropolitical", 28, FontStyle.Bold),
                Size = new Size(400, 100),
                Parent = text_panel,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(0, 10, 30),
            };
            text_panel.Controls.Add(label);
            label.BringToFront();
        }
    }
}
