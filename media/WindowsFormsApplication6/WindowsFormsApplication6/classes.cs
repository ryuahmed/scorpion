using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication6
{
    public static class user_log_in
    {
        public static bool valid = true; 
        public static string UserID;
        public static string dp;
        public static string pos;
        internal static void logout(Form close)
        {
            valid = false;
            UserID = "";
            dp = "";
            pos = "";

            close.Hide();
            var home = new startup();
            home.Closed += (s, args) => close.Close();
            home.Show();

        }

    }
    public static class over_controll
    {
        public static string static_media_location;
        public static int x, y;
        public static bool start_center = true;
        public static int body_size_x= 1188,av_body_size_x= body_size_x- 23, body_size_y= 709-5;

        public static Color color_active = Color.FromArgb(247, 148, 2);
        public static Color color_deactive = Color.FromArgb(233, 233, 233);
        public static Color color_background = Color.FromArgb(235, 235, 235);
        public static Color color_menubar = Color.FromArgb(37, 41, 48);
        public static Color color_menubar_active = Color.FromArgb(55, 60, 70);
        public static Color color_menubar_hover = Color.FromArgb(45, (60* 45) /55, (70 * 45) / 55);
        public static Control active_panel,temp,active_submenu,active_sub_body,active_user,active_user_body;

        public static DateTime  today = DateTime.Today;
    }

    public class upload
    {
        public static int type; // 0 = movie, 1 = series 2 = season
        public static Image post, cover;
        public static string name, rdate,pname,cname;
        public static int season ,episode;
        public static bool genre_valid = false;
        public static List<string> genre = new List<string>();

    }

    public static class result_search
    {
        public static List<string> name = new List<string>();
        public static List<string> id = new List<string>();
        public static List<string> poster = new List<string>();

        public static Color default_color = Color.FromArgb(150, 150, 150);
        public static Color clicked_color = over_controll.color_menubar;
        public static Color hover_color = over_controll.color_menubar_active;
        public static Color bar_color = Color.FromArgb(50, 50, 50);
        public static Color text = over_controll.color_background;
        public static int type = 2;
        public static bool cp = true;
        public static bool on = true;
        public static bool up = true;
        public static string country = "";
        public static string lang = "";
        public static bool betn = false;
        public static bool after = false;
        public static bool before = false;
        public static bool on_this = false;

        public static string from = "";
        public static string to = "";


    }

    public static class player_data
    {
        public static bool run = false;
        public static string ep_id = "";
        public static string ep_480 = "";
        public static string ep_720 = ""; 
        public static string ep_1080 = "";
        public static string now_play = ""; 
        public static string content = "";
        public static string season = "";
        public static string ep = "";
        public static string type = "";






        internal static void get_video_media(string id,content con)
        {
            content = con.name;
            type = con.type; 
            ep_id = id;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            if (type == "TV")
            {
                string query = "SELECT * from episode join season_ep join season WHERE  episode.id = season_ep.e_id and season_ep.s_id = season.id and episode.id = '" + ep_id + "' ";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60; ;
                databaseConnection.Open();
                MySqlDataReader basic = commandDatabase.ExecuteReader();
                basic.Read();
                season = (string)basic["no"];
                ep = (string)basic["ep"];
                ep_480 = over_controll.static_media_location + @"content\" + (string)basic["link480"];
                ep_720 = over_controll.static_media_location + @"content\" + (string)basic["link720"];
                ep_1080 = over_controll.static_media_location + @"content\" + (string)basic["link1080"];
            }
           if (type == "Movie")
           {
               string query = "SELECT * FROM movie_play where m_id = '" + ep_id + "'";
               MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
               commandDatabase.CommandTimeout = 60; ;
               databaseConnection.Open();
               MySqlDataReader basic = commandDatabase.ExecuteReader();
               basic.Read();
               ep_480 = over_controll.static_media_location + @"content\" + (string)basic["link480"];
               ep_720 = over_controll.static_media_location + @"content\" + (string)basic["link720"];
               ep_1080 = over_controll.static_media_location + @"content\" + (string)basic["link1080"];
           }
           databaseConnection.Close();

        }

    }
    public class user_profile
    {
        public string id;
        public string fname, lname;
        public string email, phone;
        public string bd, region;
        public string dp, pos, type;
        public string jdate, ldate;
        public string age; 
        public bool owner ;
        public bool privacy;
        public bool info;
        public bool other;
        public int movie ;
        public int series ;
        public int season ;
        public int epi;
        public int count_history;
        public  List<string> content_name = new List<string>();
        public  List<string> content_id = new List<string>();
        public  List<string> content_date = new List<string>();

        public bool change_info;
        public bool change_other;



        internal user_profile()
        {
            id = "";
            fname = "";
            lname = "";
            email = "";
            phone = "";
            bd = "";
            region = "";
            dp = "";
            pos = "";
            owner = false;
            privacy = false;
            type = "";
            jdate = "";
            ldate = "";
            movie = 0;
            series = 0;
            season = 0;
            epi = 0;
            count_history = 0;
            info = false;
            other = false;
            change_info = info;
            change_other = other;
        }

        private void owner_check()
        {
            if(id==user_log_in.UserID)
            {
                owner = true;
            }
        }
        private void check_privacy()
        {
            if(!info && !owner)
            {
                fname = "___";
                lname = "___";
                email = "___";
                phone = "___";
                bd = "___";
                region = "___";
            }
        }

        internal void  get_data(string local_id )
        {
            id = local_id;

            owner_check();
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            string query = "SELECT* FROM `user` WHERE User_name ='" + id + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;
            databaseConnection.Open();
            MySqlDataReader basic = commandDatabase.ExecuteReader();
            if(basic.HasRows)
            {
                basic.Read();
                ldate = (string)basic["First_name"];
                lname = (string)basic["Last_name"];
                email = (string)basic["Email"];
                phone = (string)basic["Phone_no"];
                bd = (string)basic["Birth_date"];
                region = (string)basic["Region"];
                dp = over_controll.static_media_location + @"dp\" + (string)basic["dp"];
                jdate = (string)basic["joined"];
                if ((string)basic["info_show"] == "1")
                    info = true;

                if ((string)basic["other_show"] == "1")
                    other = true;

                change_info = info;
                change_other = other;

            }
            else
            {
                MessageBox.Show("user not found");
            }
            databaseConnection.Close();


            DateTime oDate = DateTime.Parse(bd);
            int local_age = 0;
            local_age = DateTime.Now.Year - oDate.Year;
            if (DateTime.Now.DayOfYear < oDate.DayOfYear)
                local_age = local_age - 1;
            age = local_age.ToString();

            query = "SELECT max(date_time) as no FROM `log_in` where u_id ='" + id + "'";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;
            databaseConnection.Open();
            basic = commandDatabase.ExecuteReader();
            if (basic.HasRows)
            {
                basic.Read();
                ldate = (string)basic["no"];

            }
            else
            {
                MessageBox.Show("user not found");
            }
            databaseConnection.Close();

            query = "SELECT id,u_id,type,s,valid_till from (SELECT max(s) as s, u_id FROM `user_type` group by u_id) as x NATURAL join user_type where u_id ='" + local_id + "'";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string valid_till = (string)reader["valid_till"];
                DateTime now = DateTime.Now;
                DateTime myDate = DateTime.ParseExact(valid_till, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                if (myDate >= now)
                {
                    type = (string)reader["type"];
                }
                else
                {
                    type = "Guest";

                }
            }
            else
            {
                type = "Guest";

            }
            databaseConnection.Close();

            check_privacy();

        }

        internal void get_hisotry()
        {
            count_history = 0;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            string query = "SELECT * FROM `history_user` where history_user.u_id = '" + id + "' ORDER by date DESC " ;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;
            databaseConnection.Open();
            MySqlDataReader basic = commandDatabase.ExecuteReader();
            while (basic.Read())
            {
                content_name.Add((string)basic["name"]);
                content_id.Add((string)basic["id"]);
                content_date.Add((string)basic["date"]);
                count_history ++;
            }
            databaseConnection.Close();
        }
        internal void get_stat()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            string query = "SELECT * FROM `movie_stat` where u_id ='" + id + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;
            databaseConnection.Open();
            MySqlDataReader basic = commandDatabase.ExecuteReader();
            if(basic.HasRows)
            {
                basic.Read();
                string x = basic["movie"].ToString();
                movie = Int32.Parse(x);

            }  
            databaseConnection.Close();

            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            query = "SELECT * FROM `ep_stat` where u_id ='" + id + "'";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;
            databaseConnection.Open();
            basic = commandDatabase.ExecuteReader();
            if (basic.HasRows)
            {
                basic.Read();
                string x = basic["no"].ToString();
                epi = Int32.Parse(x);

            }
            databaseConnection.Close();

            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            query = "SELECT  u_id, COUNT(id) as no from (SELECT season_ep.s_id as s_id, u_id, count(*) as no_ep FROM `history_tv` join season_ep where history_tv.e_id = season_ep.e_id group by season_ep.s_id) as ep join season where ep.s_id = id and no_ep = season.noofep and u_id ='" + id + "' group by u_id" ;
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;
            databaseConnection.Open();
           // MessageBox.Show(query);
            basic = commandDatabase.ExecuteReader();
            if (basic.HasRows)
            {
                basic.Read();
                string x = basic["no"].ToString();
                season = Int32.Parse(x);

            }
            databaseConnection.Close();

        }

    }

    public class content
    {
        public string id, name, r_date, cover, creator, plot, tag, country, lang, e_date, type;
        public string[] star = new string[3];
        public List<string> genre = new List<string>();

        public int season_no = 0, ep_no = 0;
        public List<string> sid = new List<string>();
  
        public List<string> ep = new List<string>();

        internal void get_info(string content_id)
        {

            id = content_id;


            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            string query = "SELECT * from content   join info_series WHERE info_series.c_id = content.id and content.id = '" + id + "'";

            //MessageBox.Show(query);

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;

            databaseConnection.Open();
            // Success, now list 
            MySqlDataReader basic = commandDatabase.ExecuteReader();
            basic.Read();

            name = (string)basic["name"];
            tag = (string)basic["tag"];
            creator = (string)basic["creator"];
            star[0] = (string)basic["star1"];
            star[1] = (string)basic["star2"];
            star[2] = (string)basic["star3"];
            r_date = ((DateTime)basic["release_date"]).ToString("MM/d/yyyy");
            //e_date = ((DateTime)basic["last_date"]).ToString("MM/d/yyyy");
            country = (string)basic["country"];
            lang = (string)basic["language"];
            plot = (string)basic["plot"];
            cover = (string)basic["cover"];
            type = (string)basic["type"];
            //season_no = Int32.Parse(basic["no_s"].ToString());
            // If there are available rows
            databaseConnection.Close();
            season_no = 1;
            if (type == "TV")
            {
                query = "SELECT * FROM no_of_season WHERE id = '" + id + "'";

                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60; ;

                databaseConnection.Open();
                basic = commandDatabase.ExecuteReader();
                basic.Read();
                season_no = Int32.Parse(basic["no_of_season"].ToString());
                databaseConnection.Close();

                query = "SELECT content.id , s_id FROM content join tv_season join season where content.id = tv_season.c_id and tv_season.s_id = season.id and content.id = '" + id + "'ORDER by season.no";
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60; ;

                sid.Clear();
                databaseConnection.Open();
                basic = commandDatabase.ExecuteReader();
                while (basic.Read())
                {
                    sid.Add((string)basic["s_id"]);
                }
                databaseConnection.Close();
            }




        }
        internal void get_ep_no(string sid)
        {
            ep_no = 0;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";

            string query = "SELECT * FROM no_of_ep WHERE id = '" + sid + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;
            databaseConnection.Open();
            MySqlDataReader basic = commandDatabase.ExecuteReader();

            if (basic.HasRows)
            {
                basic.Read();

                ep_no = Int32.Parse(basic["no_of_ep"].ToString());
            }
            else
                basic.Read();

            databaseConnection.Close();
        }
        internal void get_ep(string sid)
        {

            ep.Clear();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            string query = "SELECT episode.id as epi FROM season join season_ep join episode where season.id = season_ep.s_id and season_ep.e_id = episode.id and season.id = '" + sid + "' ORDER by episode.ep";
            //MessageBox.Show(query);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;

            databaseConnection.Open();
            MySqlDataReader basic = commandDatabase.ExecuteReader();

            while (basic.Read())
            {
                ep.Add((string)basic["epi"]);

            }
            databaseConnection.Close();
        }
    }



    public class plan_page
    {
        public string[] name = new string[3];
        public string[] screen = new string[3];
        public string[] quality = new string[3];
        public string[] price = new string[3];
        public int selected = -1 ;
        public bool purch_text = false;
        internal void get_plan()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            string query = "SELECT * FROM `plan` order by price";
            //MessageBox.Show(query);
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60; ;

            databaseConnection.Open();
            MySqlDataReader basic = commandDatabase.ExecuteReader();
            if(basic.HasRows)
            {
                for(int i=0; i<3; i++)
                {
                    basic.Read();
                    name[i] = (string)basic["name"];
                    screen[i] = (string)basic["screen"];
                    quality[i] = (string)basic["quality"];
                   // price[i] = (string)basic["price"];
                }
            }
            else
            {
                MessageBox.Show("database error");
            }
            databaseConnection.Close();
        }

    }
    public class purchase_plan
    {
        string purchased_by, purchased_to; 
    }





}


