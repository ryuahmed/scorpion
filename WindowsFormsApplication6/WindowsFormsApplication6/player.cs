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
    public partial class player_form : Form
    {
        public player_form()
        {
            InitializeComponent();
        }

        private void run()
        {
            mediaplayer.URL = player_data.now_play;
            mediaplayer.Ctlcontrols.stop();
        }

        private void player_form_Load(object sender, EventArgs e)
        {
            int x =854 , y = 480+32; 
            re_size(x, y);
            mediaplayer.Location = new Point(0,32);
            Panel drag = new Panel()
            {
                Name = "drag",
                Size = new Size(x, 32),
                Location = new Point(0, 0),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Parent = mediaplayer,

            };
            this.Controls.Add(drag);
            drag.MouseMove += new System.Windows.Forms.MouseEventHandler(mousemove);
            drag.MouseDown += new System.Windows.Forms.MouseEventHandler(mousedown);

            FlowLayoutPanel nameplate = new FlowLayoutPanel()
            {
                Name = "nameplate",
                Location = new Point(5, 5),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Parent = mediaplayer,
                Margin = new Padding(0),
                AutoSize = true,


            };
            drag.Controls.Add(nameplate);



            Label content = new Label()
            {
                Name = "name",
                Text = player_data.content,
                BackColor = Color.Transparent,
                Font = new Font("Neuropolitical", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Parent = nameplate,
                Margin = new Padding(0),
        };
            nameplate.Controls.Add(content);
            if(player_data.type=="TV")
            {
                Label sep = new Label()
                {
                    Name = "sep",
                    Text = ": " + player_data.season + player_data.ep,
                    BackColor = Color.Transparent,
                    Font = new Font("Neuropolitical", 10, FontStyle.Bold),
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                    Parent = nameplate,
                    Margin = new Padding(0),
                };
                nameplate.Controls.Add(sep);
            }


            FlowLayoutPanel pan = new FlowLayoutPanel()
            {
                Name = "qua",
                Size = new Size(200, 32),
                Location = new Point(250, 0),

                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Parent = mediaplayer,

            };
            drag.Controls.Add(pan);
            Label label480 = new Label()
            {
                Name = player_data.ep_480,
                Text = "480p",
                Size = new Size(50, 32),
                BackColor = Color.Transparent,
                Font = new Font("Neuropolitical", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(210, 210, 210),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Parent = pan,

            };
            pan.Controls.Add(label480);
            Label label720 = new Label()
            {
                Name = player_data.ep_720,
                Text = "720p",
                Size = new Size(50, 32),
                BackColor = Color.Transparent,
                Font = new Font("Neuropolitical", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 60),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Parent = pan,

            };
            pan.Controls.Add(label720);
            Label label1080 = new Label()
            {
                Name = player_data.ep_1080,
                Text = "1080p",
                Size = new Size(80, 32),
                BackColor = Color.Transparent,
                Font = new Font("Neuropolitical", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(210, 210, 210),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Parent = pan,

            };
            pan.Controls.Add(label1080);

            label480.Click += new EventHandler(qua_click);
            label720.Click += new EventHandler(qua_click);
            label1080.Click += new EventHandler(qua_click);
            label480.MouseHover += new EventHandler(qua_hover);
            label720.MouseHover += new EventHandler(qua_hover);
            label1080.MouseHover += new EventHandler(qua_hover);
            label480.MouseLeave += new EventHandler(qua_leave);
            label720.MouseLeave += new EventHandler(qua_leave);
            label1080.MouseLeave += new EventHandler(qua_leave);

            var pic = new PictureBox()
            {
                Name = "close",
                Size = new Size(30, 30),
                Location = new Point(x-30, 0),
                Parent = drag,
                Anchor = (AnchorStyles.None),

            };
            drag.Controls.Add(pic);
            pic.BringToFront();
            pic.Image = Properties.Resources.close21;

            pic.Click += new EventHandler(close_click);
           // pic.MouseHover += new EventHandler(contentpic_hover);
           // pic.MouseLeave += new EventHandler(contentpic_leave);
           // pic.Image = new Bitmap(path[j, 0]);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;



            run();

        }

        private void re_size(int x , int y )
        {
            this.Size = new Size(x, y+32);
            mediaplayer.Size = new Size(x, y);
        }
        private void close_click(object sender, EventArgs e)
        {
            this.Close();

            player_data.run = false ;
        }
        private void qua_click(object sender, EventArgs e)
        {
            Control qua = (Control)sender;
            Control pan = qua.Parent;

            bool approval = false;
            if (qua.Text == "480p")
                approval = true;

            if (qua.Text == "720p")
            {
                if (user_log_in.pos != "basic")
                    approval = true; 
            }
            if (qua.Text == "1080p")
            {
                if (user_log_in.pos != "basic" && user_log_in.pos != "premium")
                    approval = true;
            }
            if(approval)
            {
                foreach (Control e_qua in pan.Controls)
                {
                    e_qua.ForeColor = Color.FromArgb(210, 210, 210);
                }
                qua.ForeColor = Color.FromArgb(60, 60, 60);
                player_data.now_play = qua.Name;
                run();
            }

        }
        private void qua_hover(object sender, EventArgs e)
        {
            Control qua = (Control)sender;

            bool approval = false;

            if (qua.Text == "480p")
                approval = true;

            if (qua.Text == "720p")
            {
                if (user_log_in.pos != "basic")
                    approval = true;
            }
            if (qua.Text == "1080p")
            {
                if (user_log_in.pos != "basic" && user_log_in.pos != "premium")
                    approval = true;
            }
            if (approval)
            {
                if (qua.ForeColor != Color.FromArgb(60, 60, 60))
                {
                    qua.ForeColor = Color.FromArgb(180, 180, 180);
                }
            }

        }

        private void qua_leave(object sender, EventArgs e)
        {
            Control qua = (Control)sender;
            if (qua.ForeColor != Color.FromArgb(60, 60, 60))
            {
                qua.ForeColor = Color.FromArgb(210, 210, 210);
            }
        }

        private void mousemove(object sender, MouseEventArgs e)
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

        private void mousedown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
