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


        private void get_mod_cover(string query, Control sub_subbody)
        {
            MySqlConnection databaseConnection = connstring();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader = commandDatabase.ExecuteReader();

            while (reader.Read())
            {

                add_mod_cover(reader["id"].ToString(), reader["cover"].ToString(), sub_subbody);
            }
            databaseConnection.Close();
        }
        private void add_mod_cover(string id,string cover , Control sub_subbody )
        {
            int x = (over_controll.av_body_size_x - 230) / 2;
            int y = (394 * (over_controll.av_body_size_x - 230) / 2400);
            int p = 10; 
            if(sub_subbody.Name.ToString()!= "sub_subbody")
            {
                x =( (over_controll.av_body_size_x - 400) / 5)-10;

                y = (100 * 1200) / (5 * 394) ;
                p = 5; 
            }

            Panel pic_container = new Panel()
            {
                Name = id,
                Size = new Size(x, y),
                BackColor = over_controll.color_background,
                Parent = sub_subbody,

            };
            sub_subbody.Controls.Add(pic_container);
            pic_container.BringToFront();
            // string s = reader[att].ToString();
            //res.Add((string)reader[att]);
            var pic = new PictureBox()
            {
                Name = id,
                Size = new Size(x , y ),
                Location = new Point(0, 0),
                Parent = pic_container,
                Anchor = (AnchorStyles.None),

            };
            pic_container.Controls.Add(pic);
            pic.BringToFront();


            string path = over_controll.static_media_location + @"cover\" + cover;
            pic.Image = new Bitmap(path);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            Panel panel_over_pic = new Panel()
            {
                Name = id,
                Size = new Size(x , y ),
                Location = new Point(0, 0),
                Parent = pic,
                BackColor = Color.Transparent,
            };

            pic.Controls.Add(panel_over_pic);
            panel_over_pic.BringToFront();


            if(sub_subbody.Name== "sub_subbody")
            {
                pic.Click += new EventHandler(mod_cover_click);
                pic.MouseHover += new EventHandler(contentpic_hover);
                pic.MouseLeave += new EventHandler(contentpic_leave);
                
                panel_over_pic.Click += new EventHandler(mod_cover_panel_click);
                panel_over_pic.MouseHover += new EventHandler(panel_over_pic_hover);
                panel_over_pic.MouseLeave += new EventHandler(panel_over_pic_leave);
            }
        

        }
        private void delete_all_mod_cover()
        {
            foreach (Control container in over_controll.active_sub_body.Controls)
            {
                if (container.Name == "sub_subbody")
                {
                    delete_all_child( container);
                }
            }
        }

     


        private int check_selected()
        {
            int i = 1; 
            foreach(Control con in over_controll.active_sub_body.Controls)
            {
                if(con.Name== "add_to_cover")
                {
                    foreach (Control count in con.Controls)
                    {
                        i++; 
                    }

                }
            }
           // MessageBox.Show(i.ToString());
            return i;
        }

        private void remove_mod_cover(string id)
        {
            foreach (Control con in over_controll.active_sub_body.Controls)
            {
                if (con.Name.ToString() == "add_to_cover")
                {
                    foreach (Control del in con.Controls)
                    {
                        if(del.Name.ToString()==id)
                        {
                            del.Dispose();
                        }
                    }

                }

            }
        }
    }
}
