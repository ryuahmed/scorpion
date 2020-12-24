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
    public partial class startup : Form
    {
        bool user_click_check = false;
        bool pass_click_check = false; 

        public startup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)  //log in
        {

            
            usernameinput.ForeColor = Color.FromArgb(233, 233, 233);
            passwordinput.ForeColor = Color.FromArgb(233, 233, 233);
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            panel2.BackColor = Color.FromArgb(233, 233, 233);
            pictureBox3.BackgroundImage = Properties.Resources.lock1;
            pictureBox2.BackgroundImage = Properties.Resources.user1;

            bool proced = true;

            if(string.IsNullOrEmpty(usernameinput.Text.ToString()) == true)
            {
                user_click_check = false;
                usernameinput.Text = "User Name";
            }


            if (string.IsNullOrEmpty(passwordinput.Text.ToString()) == true)
            {
                pass_click_check = false;
                passwordinput.PasswordChar = '\0';
                passwordinput.Text = "Password";
            }

            if (user_click_check == false)
            {
                usernameinput.ForeColor = Color.FromArgb(100, 100, 100);
                panel1.BackColor = Color.FromArgb(190, 40, 40);
                proced = false;
            }
               

            if (pass_click_check == false)
            {
                passwordinput.ForeColor = Color.FromArgb(100, 100, 100);
                panel2.BackColor = Color.FromArgb(190, 40, 40);
                proced = false;
            }

            if(proced==true)
            {


                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";

                // Select all
                string query = "SELECT * FROM user";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    // Success, now list 

                    // If there are available rows
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string userName = (string)reader["User_name"];
                            string pass = (string)reader["Password"];

                            if (string.Compare(userName, usernameinput.Text.ToString()) == 0 && string.Compare(pass, passwordinput.Text.ToString()) == 0)
                            {
                                // MessageBox.Show("you are loged in");

                                user_log_in.UserID = userName;

                                databaseConnection.Close();

                                this.Hide();
                                var home = new homepage();
                                home.Closed += (s, args) => this.Close();
                                home.Show();
                                return;
                                //MessageBox.Show("you are loged in");
                            }



                            incorrectpanel.Visible = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }

                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }


        private void usernameinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameinput_Click(object sender, EventArgs e)
        {
            if(user_click_check == false)
            {
                usernameinput.Clear();
                user_click_check = true;
            }

            
      
            pictureBox2.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(247, 148, 29);
            usernameinput.ForeColor = Color.FromArgb(247, 148, 29);


            pictureBox3.BackgroundImage = Properties.Resources.lock1;
            if(pass_click_check==true)
            {
                panel2.BackColor = Color.FromArgb(233, 233, 233);
                passwordinput.ForeColor = Color.FromArgb(233, 233, 233);
            }






        }

        private void passwordinput_Click(object sender, EventArgs e)
        {
            pass_click_check = true; 
            passwordinput.Clear();
            passwordinput.PasswordChar = '●';


            pictureBox2.BackgroundImage = Properties.Resources.user1;
            if(user_click_check==true)
            {
                panel1.BackColor = Color.FromArgb(233, 233, 233);
                usernameinput.ForeColor = Color.FromArgb(233, 233, 233);
            }


            pictureBox3.BackgroundImage = Properties.Resources.lock2;
            panel2.BackColor = over_controll.color_active;
            passwordinput.ForeColor = Color.FromArgb(247, 148, 29);

        }

        private void button1_Click_1(object sender, EventArgs e) // signup
        {


            this.Hide();
            var signup = new signup();
            signup.Closed += (s, args) => this.Close();
            signup.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackgroundImage = Properties.Resources.close21;

        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackgroundImage = Properties.Resources.close1;

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
