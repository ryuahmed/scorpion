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
    public partial class signup : Form
    {
        bool user_click_check = false;
        bool email_click_check = false; 
        bool pass_click_check = false ; 
        public signup()
        {
            InitializeComponent();
        }

        private void usernameinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new startup();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            pictureBox2.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.FromArgb(233, 233, 233);
            usernameinput.ForeColor = Color.FromArgb(233, 233, 233);
            pictureBox3.BackgroundImage = Properties.Resources.lock1;
            panel2.BackColor = Color.FromArgb(233, 233, 233);
            passwordinput.ForeColor = Color.FromArgb(233, 233, 233);
            pictureBox4.BackgroundImage = Properties.Resources.email1;
            panel3.BackColor = Color.FromArgb(233, 233, 233);
            emailinput.ForeColor = Color.FromArgb(233, 233, 233);

            bool proced = true;

            if (string.IsNullOrEmpty(usernameinput.Text.ToString()) == true)
            {
                user_click_check = false;
                usernameinput.Text = "User Name";
            }

            if (string.IsNullOrEmpty(passwordinput.Text.ToString()) == true)
            {
                pass_click_check=false;
                passwordinput.Text = "Password";
                passwordinput.PasswordChar = '\0';
            }

            if (string.IsNullOrEmpty(emailinput.Text.ToString()) == true)
            {
                email_click_check = false;
                emailinput.Text = "Email";
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

            if (email_click_check == false)
            {
                emailinput.ForeColor = Color.FromArgb(100, 100, 100);
                panel3.BackColor = Color.FromArgb(190, 40, 40);
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
                            string email = (string)reader["Email"];
                            if (string.Compare(userName, usernameinput.Text.ToString()) == 0 || string.Compare(email, emailinput.Text.ToString()) == 0)
                            {
                                if (string.Compare(userName, usernameinput.Text.ToString()) == 0)
                                {
                                    panel1.BackColor = Color.FromArgb(190, 40, 40);
                                }

                                if (string.Compare(email, emailinput.Text.ToString()) == 0)
                                {
                                    panel3.BackColor = Color.FromArgb(190, 40, 40);
                                    incorrectpanel.Text = "This email is already in use";
                                }



                                incorrectpanel.Visible = true;
                                databaseConnection.Close();
                                return;
                            }
                        }
                        string insert = "INSERT INTO `user` (`First_name`, `Last_name`, `User_name`, `Email`, `Password`, `Phone_no`, `Birth_date`, `position`, `dp`) VALUES(NULL, NULL, '" + usernameinput.Text + "','" + emailinput.Text + "', '" + passwordinput.Text + "', NULL, NULL, 'guest', 'default')";

                        MessageBox.Show(insert);

                        MySqlConnection insertconnection = new MySqlConnection(connectionString);
                        insertconnection.Open();

                        MySqlCommand insertcommand = new MySqlCommand(insert, insertconnection);
                        MySqlDataReader myinsert = insertcommand.ExecuteReader();
                        MessageBox.Show("Done");
                        insertconnection.Close();

                        this.Hide();
                        var info = new info();
                        info.Closed += (s, args) => this.Close();
                        info.Show();
                        return;

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

        private void usernameinput_Click(object sender, EventArgs e)
        {
            if(user_click_check==false)
            {
                usernameinput.Clear();
                user_click_check = true; 
            }


            pictureBox2.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(247, 148, 29);
            usernameinput.ForeColor = Color.FromArgb(247, 148, 29);

            pictureBox3.BackgroundImage = Properties.Resources.lock1;
            if (pass_click_check == true)
            {
                panel2.BackColor = Color.FromArgb(233, 233, 233);
                passwordinput.ForeColor = Color.FromArgb(233, 233, 233);
            }

            pictureBox4.BackgroundImage = Properties.Resources.email1;
            if (email_click_check == true)
            {
                panel3.BackColor = Color.FromArgb(233, 233, 233);
                emailinput.ForeColor = Color.FromArgb(233, 233, 233);
            }
        }

        private void emailinput_Click(object sender, EventArgs e)
        {
            if(email_click_check==false)
            {
                emailinput.Clear();
                email_click_check = true; 

            }

            pictureBox2.BackgroundImage = Properties.Resources.user1;
            if (user_click_check == true)
            {
                panel1.BackColor = Color.FromArgb(233, 233, 233);
                usernameinput.ForeColor = Color.FromArgb(233, 233, 233);
            }

            pictureBox3.BackgroundImage = Properties.Resources.lock1;
            if (pass_click_check == true)
            {
                panel2.BackColor = Color.FromArgb(233, 233, 233);
                passwordinput.ForeColor = Color.FromArgb(233, 233, 233);
            }


            pictureBox4.BackgroundImage = Properties.Resources.email2;
            panel3.BackColor = Color.FromArgb(247, 148, 29);
            emailinput.ForeColor = Color.FromArgb(247, 148, 29);


        }

        private void passwordinput_Click(object sender, EventArgs e)
        {
            pass_click_check = true;
            passwordinput.Clear();

            passwordinput.PasswordChar = '●';


            pictureBox2.BackgroundImage = Properties.Resources.user1;
            if (user_click_check == true)
            {
                panel1.BackColor = Color.FromArgb(233, 233, 233);
                usernameinput.ForeColor = Color.FromArgb(233, 233, 233);
            }

            pictureBox3.BackgroundImage = Properties.Resources.lock2;
            panel2.BackColor = Color.FromArgb(247, 148, 29);
            passwordinput.ForeColor = Color.FromArgb(247, 148, 29);

            pictureBox4.BackgroundImage = Properties.Resources.email1;
            if (email_click_check == true)
            {
                panel3.BackColor = Color.FromArgb(247, 148, 29);
                emailinput.ForeColor = Color.FromArgb(247, 148, 29);
            }
        }

        private void passwordinput_TextChanged(object sender, EventArgs e)
        {

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

        private void signup_Load(object sender, EventArgs e)
        {
            usernameinput.Select(0, 0);
        }
    }
}
