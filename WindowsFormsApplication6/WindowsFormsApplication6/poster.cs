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
        private void add_poster(Control this_panel, int n, string[,] path)
        {


            for (int j = 0; j < n; j++)
            {
                Panel parent_panel = new Panel()
                {
                    Name = path[j, 1],
                    Size = new Size(190, 260),
                    //Location = new Point(lx, ly),
                    BackColor = Color.Transparent,
                    Parent = this_panel,
                    Margin = new Padding(4, 4, 4, 4),
                };

                this_panel.Controls.Add(parent_panel);


                Panel panel = new Panel()
                {
                    Name = path[j, 1],
                    Size = new Size(180, 260),
                    Location = new Point(15, 0),
                    BackColor = Color.Transparent,
                    Parent = parent_panel,
                    Margin = new Padding(4, 4, 4, 4),
                };

                parent_panel.Controls.Add(panel);
                panel.BringToFront();
                panel.Click += new EventHandler(contentpanel_click);
                panel.MouseHover += new EventHandler(contentpanel_hover);
                panel.MouseLeave += new EventHandler(contentpanel_leave);


                var pic = new PictureBox()
                {
                    Name = path[j, 1],
                    Size = new Size(180 - 20, 240 - 20),
                    Location = new Point(5, 5),
                    Parent = panel,
                    Anchor = (AnchorStyles.None),

                };
                panel.Controls.Add(pic);
                pic.BringToFront();

                pic.Click += new EventHandler(contentpic_click);
                pic.MouseHover += new EventHandler(contentpic_hover);
                pic.MouseLeave += new EventHandler(contentpic_leave);
                pic.Image = new Bitmap(path[j, 0]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                Panel panel_over_pic = new Panel()
                {
                    Name = path[j, 1],
                    Size = new Size(180 - 20, 240 - 20),
                    Location = new Point(0, 0),
                    Parent = pic,
                    BackColor = Color.Transparent,
                };

                pic.Controls.Add(panel_over_pic);
                panel_over_pic.BringToFront();
                panel_over_pic.Click += new EventHandler(panel_over_pic_click);
                panel_over_pic.MouseHover += new EventHandler(panel_over_pic_hover);
                panel_over_pic.MouseLeave += new EventHandler(panel_over_pic_leave);


                Panel genre_plate = create_flowpanel("genre_plate", 190, 40, Color.Transparent, panel);
                genre_plate.Location = new Point(0, 230);

                int k = 0;
                int kx = 10;
                List<string> genre = get_genre(path[j, 1]);
                while (true)
                {
                    Label gen = new Label()
                    {
                        Name = k.ToString(),
                        Text = genre[k],
                        Location = new Point(kx, 230),
                        Font = new Font("Neuropolitical", 8, FontStyle.Regular),
                        MaximumSize = new Size(50, 0),
                        Parent = genre_plate,
                        BackColor = Color.Transparent,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.FromArgb(0, 10, 30),
                        AutoSize = true,

                    };

                    genre_plate.Controls.Add(gen);
                    gen.BringToFront();
                    if (k == 2)                                                          //print 3
                        break;
                    Label slash = new Label()
                    {
                        Name = k.ToString(),
                        Text = "|",
                        Location = new Point(kx + 41, 230),
                        Font = new Font("Neuropolitical", 8, FontStyle.Regular),
                        AutoSize = true,
                        Parent = genre_plate,
                        BackColor = Color.Transparent,
                        ForeColor = Color.FromArgb(0, 10, 30),
                        TextAlign = ContentAlignment.MiddleCenter,

                    };
                    genre_plate.Controls.Add(slash);
                    slash.BringToFront();
                    k++;
                    kx = kx + 46;

                }
            }


        }


        protected void contentpanel_hover(object sender, EventArgs e)
        {
            Control panel = (Panel)sender;
            Control pic = panel.Controls[0];
            content_hover(panel, pic);


        }
        protected void contentpic_hover(object sender, EventArgs e)
        {
            Control panel = ((PictureBox)sender).Parent;
            Control pic = (PictureBox)sender;

            content_hover(panel, pic);
        }
        private void content_hover(Control panel, Control pic)
        {
            //panel.Size = new Size(160 + 10, 240 + 10);
            //pic.Size = new Size(160, (200 * 160) / 150);
        }

        protected void contentpanel_leave(object sender, EventArgs e)
        {
            Control panel = (Panel)sender;
            Control pic = panel.Controls[0];
            content_leave(panel, pic);


        }
        protected void contentpic_leave(object sender, EventArgs e)
        {
            Control panel = ((PictureBox)sender).Parent;
            Control pic = (PictureBox)sender;

            content_leave(panel, pic);
        }
        private void content_leave(Control panel, Control pic)
        {
            //panel.Size = new Size(160, 240);
            //pic.Size = new Size(150, 200);

        }
        protected void panel_over_pic_hover(object sender, EventArgs e)
        {
            Control fade = (Panel)sender;
            if (fade.BackColor != Color.FromArgb(200, 50, 50, 50))
                fade.BackColor = Color.FromArgb(100, 50, 50, 50);
        }
        protected void panel_over_pic_leave(object sender, EventArgs e)
        {
            Control fade = (Panel)sender;
            if (fade.BackColor != Color.FromArgb(200, 50, 50, 50))
            fade.BackColor = Color.Transparent;
        }
        protected void contentpanel_click(object sender, EventArgs e)
        {
            Panel content = (Panel)sender;
            go_to("content", content.Name.ToString());
        }
        protected void contentpic_click(object sender, EventArgs e)
        {
            PictureBox content = (PictureBox)sender;
            go_to("content", content.Name.ToString());
        }
        protected void panel_over_pic_click(object sender, EventArgs e)
        {
            Panel content = (Panel)sender;
            go_to("content", content.Name.ToString());
        }
    }
}
