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

        private void cover_count()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            string query = "SELECT count(*) as c FROM content  JOIN slideshow WHERE content.id = slideshow.content_id ";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;

            databaseConnection.Open();
            // Success, now list 

            // If there are available rows

            cover_n = Convert.ToInt32(commandDatabase.ExecuteScalar());
            databaseConnection.Close();
        }


        protected void dot_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            PictureBox dot_value = (PictureBox)sender;
            string dot_value_string = dot_value.Name;
            int dot_value_int = 0;
            Int32.TryParse(dot_value_string, out dot_value_int);

            cover_i = dot_value_int;
            cover_show();
            timer1.Start();
            //MessageBox.Show(x.ToString());
            //Your process you want to do on click.
        }
        private void add_slide_container()
        {
            Panel slideshow_panel = cover_container();



            slideshow = new PictureBox()
            {
                Name = "slideshow",
                Size = new Size(1200, 394),
                Location = new Point(0, 0),
                Parent = slideshow_panel,
                Margin = new Padding(0, 0, 0, 0),
            };
            slideshow_panel.Controls.Add(slideshow);
            slideshow.Click += new EventHandler(slideshow_Click);

            PictureBox left = new PictureBox()
            {
                Name = "left",
                Size = new Size(50, 70),
                Location = new Point(28, 154),
                Parent = slideshow,
                BackgroundImage = Properties.Resources.left2,
                BackgroundImageLayout = ImageLayout.Zoom,
                BackColor = Color.Transparent,
                //Image = new Bitmap(c),

            };
            slideshow.Controls.Add(left);
            left.Click += new EventHandler(left_Click);

            PictureBox right = new PictureBox()
            {
                Name = "right",
                Size = new Size(50, 70),
                Location = new Point(1109, 154),
                Parent = slideshow,
                //Image = new Bitmap(c),
                BackgroundImage = Properties.Resources.right,
                BackgroundImageLayout = ImageLayout.Zoom,
                BackColor = Color.Transparent,

            };
            slideshow.Controls.Add(right);
            right.Click += new EventHandler(right_Click);


        }

        private void get_cover()
        {

            cover_count();
            cover_name.Clear();
            cover_id.Clear();  

            int wi = (1190 / 2) - ((cover_n / 2) * 15);

            for (int i = 0; i < cover_n; i++)
            {

                var picture = new PictureBox
                {

                    Name = i.ToString(),
                    Size = new Size(10, 10),
                    Location = new Point(wi, 350),
                    BackgroundImage = Properties.Resources.dot,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Parent = slideshow,
                    BackColor = Color.Transparent,
                    Anchor = (AnchorStyles.Top),
                };
                picture.Click += new EventHandler(dot_Click);
                slideshow.Controls.Add(picture);
                picture.BringToFront();
                wi = wi + 15;
            }


            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            string query = "SELECT id,cover FROM content  JOIN slideshow WHERE content.id = slideshow.content_id ";

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

                    for (int i = 0; i < cover_n; i++)
                    {
                        reader.Read();
                        cover_name.Add((string)reader["cover"]);
                        cover_id.Add((string)reader["id"]);
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
        private void cover_show()
        {
            string cover_path;
            cover_path = over_controll.static_media_location + @"cover\" + cover_name[cover_i % cover_n];
            //MessageBox.Show(cover_path);
            slideshow.Image = new Bitmap(cover_path);

            slideshow.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void slideshow_Click(object sender, EventArgs e)
        {

            string id = cover_id[cover_i % cover_n];
            go_to("content", id);


        }

        private void right_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            cover_i++;
            cover_show();
            timer1.Start();
        }

        private void left_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            cover_i--;
            if (cover_i < 0)
            {
                cover_i = cover_i + cover_n;
            }
            cover_show();
            timer1.Start();
        }

    }
}
