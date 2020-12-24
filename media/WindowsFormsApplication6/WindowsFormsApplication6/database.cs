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
        private MySqlConnection connstring()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=scorpio;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            return databaseConnection;
        }

        private string count(string query)
        {
           // MessageBox.Show(query);
            MySqlConnection databaseConnection = connstring();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string s = reader["no"].ToString();
                databaseConnection.Close();
                return s;
            }

            return "0";
        }

        private void insert(string query)
        {//
           // MessageBox.Show(query);

            MySqlConnection databaseConnection = connstring();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            databaseConnection.Open();
            commandDatabase.ExecuteReader();
            databaseConnection.Close();
        }

        private List<string> result(string query, string att)
        {
            //MessageBox.Show(query);
            List<string> res = new List<string>();
            MySqlConnection databaseConnection = connstring();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();

            while (reader.Read())
            {
                string s = reader[att].ToString();
                res.Add((string)reader[att]);
            }



            databaseConnection.Close();


            return res;

        }

        private MySqlDataReader result_table(string query)
        {
            List<string> res = new List<string>();
            MySqlConnection databaseConnection = connstring();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            databaseConnection.Close();

            return reader;

        }


    }

    
}
