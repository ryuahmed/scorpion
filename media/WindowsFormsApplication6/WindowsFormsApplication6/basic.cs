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

        int max_check = 0; 
        int check_counter = 0 ;
        private void get_media()
        {
            over_controll.static_media_location = @"E:\media\";

        }

        private void get_info()
        {
            if (over_controll.start_center == false)
            {
                this.Left = over_controll.x;
                this.Top = over_controll.y;
            }

        }

        private void get_user()
        {
            id.Text = user_log_in.UserID;
            string query = "select * from user where User_name ='"+ user_log_in.UserID + "'";
            //MessageBox.Show(query);
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                //user_log_in.pos = (string)reader["position"];
                user_log_in.dp = over_controll.static_media_location + @"dp\" + (string)reader["dp"];
                databaseConnection.Close();
            }
            else
            {
                databaseConnection.Close();

                MessageBox.Show("An error occure. Try to log in again");
                user_log_in.logout(this);
            }

            query = "SELECT id,u_id,type,s,valid_till from (SELECT max(s) as s, u_id FROM `user_type` group by u_id) as x NATURAL join user_type where u_id ='" + user_log_in.UserID + "'";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            //MessageBox.Show(query);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader basic = commandDatabase.ExecuteReader();
            if (basic.HasRows)
            {
                basic.Read();
                if (basic["valid_till"] !=null)
                {
                    string valid_till = (string)basic["valid_till"];
                    DateTime now = DateTime.Now;
                    //MessageBox.Show(valid_till);
                    //valid_till = "2019-03-21 11:59:59";
                    DateTime myDate = DateTime.Parse(valid_till);
                    //DateTime myDate = DateTime.ParseExact(valid_till, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                    if (myDate >= now)
                    {
                        user_log_in.pos = (string)basic["type"];
                    }
                    else
                    {
                        //MessageBox.Show("Guest");
                        user_log_in.pos = "Guest";


                    }

                }


            }
            else
            {
                user_log_in.pos = "Guest";

            }
            databaseConnection.Close();


        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void send_staff_noti(string user, string mesg)
        {

            string query = "SELECT count(*) as no FROM `inbox`";
            string i_id = count(query) + RandomString(5);
            string ins = "INSERT INTO `inbox` ( `i_id`, `u_id`, `message` ) VALUES('" + i_id + "','" + user + "', '" + mesg + "')";

            insert(ins);


        }

        private void send_email(string email,string msg)
        {

        }
        private void delete_all_child(Control del)
        {
            int n = 0;
            foreach (Control cover in del.Controls)
            {
                n++;
            }
            for (int i = 0; i < n; i++)
            {
                del.Controls[0].Dispose();
            }
        }

        private Panel create_panel(string name, int x, int y, Color clr, Control parent)
        {
            Panel pan = new Panel()
            {
                Name = name,
                Size = new Size(x, y),
                BackColor = clr,
                BorderStyle = BorderStyle.None,
                Parent = parent,

            };

            return pan;

        }
        private FlowLayoutPanel create_flowpanel(string name, int x, int y, Color clr, Control parent)
        {
            FlowLayoutPanel pan = new FlowLayoutPanel()
            {
                Name = name,
                Size = new Size(x, y),
                BackColor = clr,
                BorderStyle = BorderStyle.None,
                Parent = parent,

            };

            return pan;

        }


        private TextBox create_textbox(string name, string txt, int x, int y, Color backclr, Color forclr, Control parent)
        {

            TextBox textbox = new TextBox()
            {
                Name = name,
                Text = txt,
                Size = new Size(x, y),
                BackColor = backclr,
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                ForeColor = forclr,
                BorderStyle = BorderStyle.None,
                Parent = parent,
            };
            return textbox;

        }

        private Button create_button(string name, string txt, int x, int y, Color backclr, Color forclr, Control parent)
        {
            Button button = new Button()
            {
                Name = name,
                Text = txt,
                Size = new Size(x, y),
                BackColor = backclr,
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                ForeColor = forclr,
                Parent = parent,
                FlatStyle = FlatStyle.Flat,

            };
            parent.Controls.Add(button);
            return button;

        }

        private Label create_label(string name, string txt, int x, int y, Color backclr, Color forclr, Control parent)
        {

            Label label = new Label()
            {
                Name = name,
                Text = txt,
                Size = new Size(x, y),
                BackColor = backclr,
                Font = new Font("Neuropolitical", 16, FontStyle.Bold),
                ForeColor = forclr,
                //TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,

            };
            return label;

        }

        private void add_genre(Control parnt)
        {
            string query = "SELECT * FROM `genres`"; 
            MySqlConnection databaseConnection = connstring();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            //MessageBox.Show(parnt.Name.ToString());

            while (reader.Read())
            {
                //MessageBox.Show(parnt.Name.ToString());

                Panel pan = create_panel(reader["genre"].ToString(), 80, 20, Color.Transparent, parnt);
                parnt.Controls.Add(pan);

                CheckBox current = new CheckBox();
                current.Location = new Point(0, 0);
                current.Name = reader["genre"].ToString();
                current.Text = reader["genre"].ToString();
                pan.Controls.Add(current);
                current.CheckedChanged += new EventHandler(check_change);


                //add_mod_cover(reader["id"].ToString(), reader["cover"].ToString(), sub_subbody);
            }
            databaseConnection.Close();

        }

        protected void check_change(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            upload.genre_valid = true;

            if (check_counter<0)
            {
                upload.genre_valid = false;
            }

            if (check.Checked)
            {
                check_counter++;
                upload.genre.Add(check.Text);
                if (check_counter > max_check && max_check >0)
                {
                    check.Checked = false;

                }

                //MessageBox.Show(upload.genre[0].ToString());

            }
            if (!check.Checked)
            {
                upload.genre.Remove(check.Text);
                check_counter--;
            }

          // MessageBox.Show(s);
        }

        private void bringfrontfrom(string  name ,Control from )
        {
            foreach (Control check in from.Controls)
            {
                if (check.Name.ToString() == name)
                {
                    check.BringToFront();
                }
            }

        }

        private Control findchild(string name, Control from)
        {
            foreach (Control check in from.Controls)
            {
                if (check.Name.ToString() == name)
                {
                    return check; 
                }
            }

            return from;
        }
        private Panel cover_container()
        {
            Panel slideshow_panel = new Panel()
            {
                Name = "slideshow_panel",
                Size = new Size(over_controll.av_body_size_x, 394),
                Parent = over_controll.active_panel,
                BackColor = Color.Transparent,

            };
            over_controll.active_panel.Controls.Add(slideshow_panel);
            return slideshow_panel;

        }

        private PictureBox cover_pic(Control parent)
        {
            PictureBox pic = new PictureBox()
            {
                Name = "slideshow",
                Size = new Size(1200, 394),
                Location = new Point(0, 0),
                Margin = new Padding(0, 0, 0, 0),
            };
            parent.Controls.Add(pic);

            return pic; 


        }

        private void save_pic(string path)
        {
            Image pic;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpeg image|*.jpg";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pic = Image.FromFile(op.FileName);
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "jpeg image|*.jpg";
                pic.Save(path + op.SafeFileName);

            }


        }

        private void add_comment(string parent, string cmnt, string check, content con)
        {
            MessageBox.Show("a"); 
            string date_time= DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "SELECT count(*) as no FROM `comment_reply`";
            string cmnt_id = "rcmnt"+count(query) + RandomString(5);
            query = "INSERT INTO `comment_reply` ( `cmnt_id`, `c_id`, `u_id`,`comment`,`spoiler`,`date_time`,`parent` ) VALUES('" + cmnt_id + "','" + con.id + "','" + user_log_in.UserID + "', '" + cmnt + "', '" + check + "','" + date_time + "','" + parent + "')";

            insert(query);

        }
        private void add_comment(string cmnt, string check, content con)
        {

            string date_time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string query = "SELECT count(*) as no FROM `comment`";
            string cmnt_id = "cmnt" + count(query) + RandomString(5);
            query = "INSERT INTO `comment` ( `cmnt_id`, `c_id`, `u_id`,`comment`,`spoiler`,`date_time` ) VALUES('" + cmnt_id + "','" + con.id + "','" + user_log_in.UserID + "', '" + cmnt + "', '" + check + "','" + date_time + "')";

            insert(query);

        }

        private void add_country(Control panel)
        {
            string s = "SELECT country FROM `country`";
            List<string> country_list = result(s, "country");
            int y = 30; 
            foreach(string country in country_list)
            {
                Label cntry = create_label(country,country,100,30, result_search.default_color,result_search.text,panel );
                panel.Controls.Add(cntry);
                cntry.Margin = new Padding(0);
                cntry.Font = new Font("OCR A", 12, FontStyle.Bold);
                cntry.TextAlign = ContentAlignment.MiddleRight;
                panel.Size = new Size(100, y);
                cntry.MouseLeave += new EventHandler(cntry_leaeve);
                cntry.MouseHover += new EventHandler(cntry_hover);
                cntry.Click += new EventHandler(cntry_click);

                y = y + 30;
                if (y > 150)
                    y = 150;
            }

        }
        private void add_lang(Control panel)
        {
            string s = "SELECT language FROM `language`";
            List<string> country_list = result(s, "language");
            int y = 30;
            foreach (string country in country_list)
            {
                Label lang = create_label(country, country, 100, 30, result_search.default_color, result_search.text, panel);
                panel.Controls.Add(lang);
                lang.Margin = new Padding(0);
                lang.Font = new Font("OCR A", 12, FontStyle.Bold);
                lang.TextAlign = ContentAlignment.MiddleLeft;
                panel.Size = new Size(100, y);
                lang.MouseLeave += new EventHandler(cntry_leaeve);
                lang.MouseHover += new EventHandler(cntry_hover);
                lang.Click += new EventHandler(lang_click);

                y = y + 30;
                if (y > 150)
                    y = 150;
            }

        }
        private void add_on(Control panel)
        {

            List<string> country_list = new List<string>()
        {
            "On",
            "After",
            "Before",
            "Between"
        };
            int y = 30;
            foreach (string country in country_list)
            {
                Label lang = create_label(country, country, 100, 30, result_search.default_color, result_search.text, panel);
                panel.Controls.Add(lang);
                lang.Margin = new Padding(0);
                lang.Font = new Font("OCR A", 12, FontStyle.Bold);
                lang.TextAlign = ContentAlignment.MiddleCenter;
                panel.Size = new Size(100, y);
                lang.MouseLeave += new EventHandler(cntry_leaeve);
                lang.MouseHover += new EventHandler(cntry_hover);
                lang.Click += new EventHandler(all_on_click);
                y = y + 30;
                if (y > 150)
                    y = 150;
            }

        }

        private List<string> get_genre(string id)
        {
            string query = "select genre  FROM  content_genres WHERE content_genres.c_id = '"+id+ "' order by genre DESC";
            //MessageBox.Show(query);
            MySqlConnection databaseConnection = connstring();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader = commandDatabase.ExecuteReader();

            List<string> genre = new List<string>();


            while (reader.Read())
            {

                genre.Add (reader["genre"].ToString());
            }
            databaseConnection.Close();

            return genre; 

        }

        private void buy_plan(plan_page obj)
        {
            string query = "SELECT count(*) as no FROM `payment_netry`";
            string p_id = "p"+count(query) + RandomString(5);
            string date_time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            DateTime a = DateTime.Now; 
            DateTime lastDay = new DateTime(a.Year, a.Month + 1, 1).AddMilliseconds(-1);
            string l_date_time = lastDay.ToString("yyyy-MM-dd hh:mm:ss");
            string x = obj.name[obj.selected];
            string ins = "INSERT INTO `payment_netry` (`p_id`, `u_id`, `submited_on`, `valid_till`, `purchased_type`) VALUES ('"+p_id+"', '"+user_log_in.UserID+"', '"+ date_time + "', '"+ l_date_time + "', 'Basic');";
            insert(ins);
            check_user();

        }



    }
}
