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

        private void add_staff(string email)
        {

            string query = "SELECT count(*) as no FROM `user` WHERE Email = '" + email + "'";
            string check = count(query);


            if(check!="0")
            {
                error_message("This email is already registered");
                return; 
            }

            string s =  "SELECT count(*) as no FROM `user`";
            string username = count(s)+ RandomString(5);
            string pass = RandomString(12);

            query = "INSERT INTO `user` ( `User_name`, `Email`, `Password` ,`position`, `dp`) VALUES('" + username + "','" + email + "', '" + pass + "', 'Staff', 'default')";
            insert(query);


            string msg = "Your account is created as a staff. User name : "+ username+" and password : " +pass+". Change your username and password and also update your profile information";

            send_staff_noti(username,msg);
            send_email(email , msg);
        }

        private void add_to_staff(string user)
        {
        
            for (int i = 1; i <= 5; i++)
            {
                delete_sugge("sugge" + i.ToString());
            }

            string query = "SELECT count(*) as no FROM `user` WHERE User_name = '" + user + "'";
            string check = count(query);

            if (check == "0")
            {
                error_message("This username dosent exist");
                return;
            }

            string up = "UPDATE `user` SET `position` = 'staff' WHERE `user`.`User_name` = '"+user+"'";
            insert(up);

            string msg = "You are promoted as a staff";
            send_staff_noti(user, msg);
        }




    }
}
