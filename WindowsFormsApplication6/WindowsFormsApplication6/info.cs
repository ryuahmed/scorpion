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
    public partial class info : Form
    {
        bool firstname_click_check = false;
        bool lastname_click_check = false;
        bool phon_click_check = false;

        public info()
        {
            InitializeComponent();
           // label1.Text = user_log_in.UserID;
        }    

        private void usernameinput_Click(object sender, EventArgs e) // firstname
        {
            if(firstname_click_check==false)
            {
                firstname_click_check = true;
                usernameinput.Clear();
            }

            pictureBox2.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(247, 148, 29);
            usernameinput.ForeColor = Color.FromArgb(247, 148, 29);

            panel8.BackColor = Color.FromArgb(233, 233, 233);
            lastname.ForeColor = Color.FromArgb(233, 233, 233);

            pictureBox4.BackgroundImage = Properties.Resources.phon1;
            panel3.BackColor = Color.FromArgb(233, 233, 233);
            phoneinput.ForeColor = Color.FromArgb(233, 233, 233);
        }

        private void lastname_Click(object sender, EventArgs e)
        {
            if (lastname_click_check == false)
            {
                lastname_click_check = true;
                lastname.Clear();
            }

            pictureBox2.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            usernameinput.ForeColor = Color.FromArgb(233, 233, 233);

            panel8.BackColor = Color.FromArgb(247, 148, 29);
            lastname.ForeColor = Color.FromArgb(247, 148, 29);

            pictureBox4.BackgroundImage = Properties.Resources.phon1;
            panel3.BackColor = Color.FromArgb(233, 233, 233);
            phoneinput.ForeColor = Color.FromArgb(233, 233, 233);
        }

        private void phoneinput_Click(object sender, EventArgs e)
        {
            if (phon_click_check == false)
            {
                phon_click_check = true;
                phoneinput.Clear();
            }

            pictureBox2.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            usernameinput.ForeColor = Color.FromArgb(233, 233, 233);

            panel8.BackColor = Color.FromArgb(233, 233, 233);
            lastname.ForeColor = Color.FromArgb(233, 233, 233);

            pictureBox4.BackgroundImage = Properties.Resources.phon2;
            panel3.BackColor = Color.FromArgb(247, 148, 29);
            phoneinput.ForeColor = Color.FromArgb(247, 148, 29);
        }

        private void loginbutton_Click(object sender, EventArgs e) //next
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            
            // Select all
            string query = "UPDATE `user` SET `First_name`='"+usernameinput.Text +"',`last_name`='"+lastname.Text+"',`Phone_no`='"+phoneinput.Text+ "' WHERE User_name ='" + user_log_in.UserID+"'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();

                this.Hide();
                var plan = new plan();
                plan.Closed += (s, args) => this.Close();
                plan.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackgroundImage = Properties.Resources.close21;

        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackgroundImage = Properties.Resources.close1;

        }

        private void skip_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new homepage();
            home.Closed += (s, args) => this.Close();
            home.Show();
            return;
        }
    }
}
