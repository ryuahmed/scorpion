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
        private void up()
        {

            if (upload.type == 0)
            {
                insert_content("Movie");

            }
            else
            {
                string cid = insert_content("TV");
                string sid = insert_season(cid);

                for(int i=0; i<upload.episode; i++)
                {
                    string e = "E";
                    if (i < 10)
                        e = "E0";
                    e = e + i.ToString();
                    insert_ep(sid,e);
                }


            }
            
        }
        private string insert_content(string t)
        {
            string s = "SELECT count(*) as no FROM `content`";
            string cid = "c" + count(s) + RandomString(5);
            string query;
            query = "INSERT INTO `content` (`name`, `id`, `type`, `release_date`, `poster`, `cover`) VALUES('" + upload.name + "', '" + cid + "', '"+t+"', '" + upload.rdate + "', '" + upload.pname + "', '" + upload.cname + "')";
            insert(query);
 
            upload.post.Save(over_controll.static_media_location + @"poster\"+upload.pname);
            upload.cover.Save(over_controll.static_media_location + @"cover\" + upload.cname);

            if(upload.genre_valid)
            {
                for (int i = 0; i < 3; i++)                       //genre
                {
                    query = "INSERT INTO `content_genres` (`c_id`, `genre`) VALUES('" + cid + "', '" + upload.genre[i] + "')";
                    insert(query);
                }
            }

            return cid; 
        }

        private string insert_season(string cid)
        {
            string type;

            if (upload.type == 1)
            {
                type = "S01";
            }
            else
            {
                if (upload.season < 10)
                    type = "S0" + upload.season.ToString();
                else
                    type = "S" + upload.season.ToString();
            }

            string s = "SELECT count(*) as no FROM `season`";
            string sid = "s" + count(s) + RandomString(5);

            string query;
            query = "INSERT INTO `season` (`id`, `no`, `noofep`, `release_date`, `poster`) VALUES('" + sid + "', '" + type + "', '" + upload.episode + "', '" + upload.rdate + "', '" + upload.pname + "')";
            insert(query);
            query = "INSERT INTO `tv_season` (`c_id`, `s_id`) VALUES('" + cid + "', '" + sid + "')";
            insert(query);
            return sid;

        }

        private void insert_ep(string sid,string ep)
        {
            string s = "SELECT count(*) as no FROM `episode`";
            string eid = "e" + count(s) + RandomString(5);

            string query;
            query = "INSERT INTO `episode` (`id`, `ep`, `link480`, `link720`, `link1080`) VALUES('" + eid + "', '" + ep + "', '480.mp4', '720.mp4', '1080.mp4')";
            insert(query);

            query = "INSERT INTO `season_ep` (`s_id`, `e_id`) VALUES('" + sid + "', '" + eid + "')";
            insert(query);
        }

    }
}
