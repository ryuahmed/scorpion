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
    public partial class plan : Form
    {
        public plan()
        {
            InitializeComponent();


        }

        private void plan_Load(object sender, EventArgs e)
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            string query = "SELECT * FROM plan";

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


                    reader.Read();
                    basic.Text = (string)reader["name"];
                    basicprice.Text = reader["price"].ToString() + "$"; ;
                    basicscreen.Text = (string)reader["screen"] + " Screen";
                    label4.Text = (string)reader["quality"];

                    reader.Read();
                    Premium.Text = (string)reader["name"];
                    premiemprice.Text = reader["price"].ToString() + "$"; ;
                    premiumscreen.Text = (string)reader["screen"] + " Screen";
                    premiumqua.Text = (string)reader["quality"];

                    reader.Read();
                    standard.Text = (string)reader["name"];
                    standardprice.Text = reader["price"].ToString() + "$"; ;
                    standardscreen.Text = (string)reader["screen"] + " Screen";
                    standardqua.Text = (string)reader["quality"];

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

        private void basiclevel_Click(object sender, EventArgs e)
        {

        }

        private void basic_CheckedChanged(object sender, EventArgs e)
        {

            if (basic.Checked)
            {
                basic.ForeColor = Color.FromArgb(247, 148, 29);
                basicprice.ForeColor = Color.FromArgb(247, 148, 29);
                basicqua.ForeColor = Color.FromArgb(247, 148, 29);
                basicscreen.ForeColor = Color.FromArgb(247, 148, 29);

                standard.ForeColor = Color.FromArgb(233, 233, 233);
                standardprice.ForeColor = Color.FromArgb(233, 233, 233);
                standardqua.ForeColor = Color.FromArgb(233, 233, 233);
                standardscreen.ForeColor = Color.FromArgb(233, 233, 233);
                
                Premium.ForeColor = Color.FromArgb(233, 233, 233);
                premiemprice.ForeColor = Color.FromArgb(233, 233, 233);
                premiumqua.ForeColor = Color.FromArgb(233, 233, 233);
                premiumscreen.ForeColor = Color.FromArgb(233, 233, 233);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void standard_CheckedChanged(object sender, EventArgs e)
        {
            if (standard.Checked)
            {
                basic.ForeColor = Color.FromArgb(233, 233, 233);
                basicprice.ForeColor = Color.FromArgb(233, 233, 233);
                basicqua.ForeColor = Color.FromArgb(233, 233, 233);
                basicscreen.ForeColor = Color.FromArgb(233, 233, 233);

                standard.ForeColor = Color.FromArgb(247, 148, 29);
                standardprice.ForeColor = Color.FromArgb(247, 148, 29);
                standardqua.ForeColor = Color.FromArgb(247, 148, 29);
                standardscreen.ForeColor = Color.FromArgb(247, 148, 29);

                Premium.ForeColor = Color.FromArgb(233, 233, 233);
                premiemprice.ForeColor = Color.FromArgb(233, 233, 233);
                premiumqua.ForeColor = Color.FromArgb(233, 233, 233);
                premiumscreen.ForeColor = Color.FromArgb(233, 233, 233);
            }
        }

        private void Premium_CheckedChanged(object sender, EventArgs e)
        {
            if (Premium.Checked)
            {
                basic.ForeColor = Color.FromArgb(233, 233, 233);
                basicprice.ForeColor = Color.FromArgb(233, 233, 233);
                basicqua.ForeColor = Color.FromArgb(233, 233, 233);
                basicscreen.ForeColor = Color.FromArgb(233, 233, 233);

                standard.ForeColor = Color.FromArgb(233, 233, 233);
                standardprice.ForeColor = Color.FromArgb(233, 233, 233);
                standardqua.ForeColor = Color.FromArgb(233, 233, 233);
                standardscreen.ForeColor = Color.FromArgb(233, 233, 233);

                Premium.ForeColor = Color.FromArgb(247, 148, 29);
                premiemprice.ForeColor = Color.FromArgb(247, 148, 29);
                premiumqua.ForeColor = Color.FromArgb(247, 148, 29);
                premiumscreen.ForeColor = Color.FromArgb(247, 148, 29);
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

        private void nextbuttom_Click(object sender, EventArgs e)
        {

        }
    }
}
