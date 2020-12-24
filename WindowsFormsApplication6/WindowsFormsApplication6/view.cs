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

namespace WindowsFormsApplication6
{
    public partial class view : Form
    {
        private List<string> cover_name = new List<string>();
        private int cover_i = 0;
        private int cover_n;
        private bool searchcheck = false; 
        public view()
        {
            InitializeComponent();
        }
        private void view_Load(object sender, EventArgs e)
        {
            id.Text = user_log_in.UserID;
            id.Text = "something";

            if (over_controll.start_center == false)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Left = over_controll.x;
                this.Top = over_controll.y;
            }

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
            account.BackColor = Color.FromArgb(35, 35, 35);

        }

        private void account_MouseLeave(object sender, EventArgs e)
        {
            account.BackColor = Color.FromArgb(30, 30, 30);

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

        private void slideshow_Click(object sender, EventArgs e)
        {
            //a
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;

        private void gradient_panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label2_Click(object sender, EventArgs e) //brwose
        {
            
        }
    }
}
