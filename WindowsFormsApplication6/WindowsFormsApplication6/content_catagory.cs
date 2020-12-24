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
        private void get_trending()
        {

            int n = 12;
            string[] week_factor = new string[n];
            DateTime[] week = new DateTime[n + 1];
            int thisweek = (n) * 7;
            double initial = 1, increaseby = 0.00, diff = 0.0;

            for (int i = n - 1; i >= 0; i--)
            {

                week[i + 1] = over_controll.today.AddDays(-thisweek);
                thisweek = thisweek - 7;

                week_factor[i] = (initial + diff).ToString();
                increaseby = increaseby + 0.05;
                diff = diff + increaseby;
            }
            week[0] = over_controll.today.AddDays(-thisweek);

            string query = "";
            string[] big = new string[n];

            for (int i = 0; i < n; i++)
            {
                big[i] = " SELECT content.id , season.poster ,hit*(hot_content.value/100)*" + week_factor[i] + " as hit from season JOIN hit_season join  tv_season join content join hot_content WHERE tv_season.c_id=content.id and content.id =hot_content.c_id and tv_season.s_id= season.id and season.id = hit_season.s_id and season.release_date >'" + week[i + 1].ToString("yyyy-MM-dd") + "' and season.release_date <='" + week[i].ToString("yyyy-MM-dd") + "' ";
                big[i] = big[i] + " UNION SELECT content.id , poster ,hit*(hot_content.value/100)*" + week_factor[i] + 1 + " as hit from content JOIN hit_content join hot_content WHERE content.id =hot_content.c_id and content.id = hit_content.c_id and type ='Movie' and release_date >'" + week[i + 1].ToString("yyyy-MM-dd") + "' and release_date <='" + week[i].ToString("yyyy-MM-dd") + "' ";
            }

            query = big[0];
            for (int i = 1; i < n; i++)
            {
                query = query + " UNION " + big[i];
            }

            query = query + " ORDER by hit desc ";
            get_poster(query);

        }
        private void get_suggestion()
        {

            //





            //suggestion er query 






            //
            get_recent_added();
        }

        private void get_similliar(string id ,string a, string b, string c)
        {
            string query = "SELECT content.id ,content.poster as poster, genre, count(*) as no FROM content join content_genres where content.id = content_genres.c_id and content.id !='"+id+"' and(content_genres.genre = '" + a+ "' OR content_genres.genre = '" + b + "' Or content_genres.genre = '" + c + "') GROUP by content.id ORDER by no DESC ";

            get_poster(query);

        }


        private void get_coming()
        {
            string thismonth = over_controll.today.ToString("yyyy-MM");
            string query = "SELECT content.id ,content.poster as poster,hot_content.value as v FROM content join hot_content WHERE type = 'Movie' and content.id = hot_content.c_id and content.release_date like  '" + thismonth + "%' and content.release_date > '" + over_controll.today + "' UNION SELECT content.id ,season.poster as poster,hot_content.value as v FROM content join hot_content join season join tv_season WHERE content.id = hot_content.c_id and content.id = tv_season.c_id and tv_season.s_id = season.id and season.release_date like   '" + thismonth + "%' and season.release_date > '" + over_controll.today + "' ORDER by  v DESC";
            get_poster(query);
        }
        private void get_recent_added()
        {
            string today = over_controll.today.ToString("yyyy-MM-dd");      
            string query = "SELECT id as id ,poster as poster ,release_date as r FROM content WHERE type = 'Movie'and release_date < '" + today + "' UNION SELECT content.id as id ,season.poster as poster,season.release_date as r FROM content join season join tv_season WHERE content.id = tv_season.c_id and tv_season.s_id = season.id and season.release_date < '" + today + "' order by r DESC";
            //MessageBox.Show(query);

            get_poster(query);
        }

        private void get_filter_result()
        {
            string query = "";
            string movie = "";
            string tv = "";
            movie = "select poster,id from content where type ='Movie'";
            tv = "select season.poster as poster,content.id as id from content join tv_season join season join info_series where content.id = info_series.c_id and content.id = tv_season.c_id and tv_season.s_id=season.id";


            if(result_search.country!="")
            {
                tv = tv + " and info_series.country = '" + result_search.country + "'";
            }
            if (result_search.lang != "")
            {
                tv = tv + " and info_series.language = '" + result_search.lang + "'";
            }
            if(result_search.betn)
            {
                tv = tv +" and season.release_date >= '"+result_search.from+"-01-01' and season.release_date <= '"+result_search.to+"-31-31'";
            }
            if (result_search.on_this)
            {
                tv = tv + " and season.release_date like '" + result_search.from + "%'";
            }
            if (result_search.after)
            {
                tv = tv + " and season.release_date >= '" + result_search.from + "-01-01'";
            }
            if (result_search.before)
            {
                tv = tv + " and season.release_date <= '" + result_search.from + "-01-01'";
            }


            if (result_search.type == 0)
            {
                query = movie;
            }
            if (result_search.type == 1)
            {
                query = tv;
            }


            if (result_search.type==2)
            {
                query = movie + " UNION " + tv;
            }

            //MessageBox.Show(query);
            get_poster(query);

        }


        private void get_poster(string query)
        {
            result_search.id.Clear();
            result_search.poster.Clear();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result_search.poster.Add(over_controll.static_media_location + @"poster\" + ((string)reader["poster"]));
                        result_search.id.Add((string)reader["id"]);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                databaseConnection.Close();
            }
        }

    }
}
