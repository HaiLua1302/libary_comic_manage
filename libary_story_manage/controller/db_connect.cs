using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libary_story_manage.controller
{
    class db_connect
    {
        private MySqlConnection connection;

        public static String _connectionString = "SERVER = localhost ;" +
                                                 "DATABASE = dbtruyen;" +
                                                 "UID = root;" +
                                                 "PASSWORD='';";

        public static DataTable ExecuteQuery(String sql)
        {

            MySqlConnection connect = new MySqlConnection(_connectionString);
            MySqlCommand command = new MySqlCommand(sql, connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            connect.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }
        //lay id
        public static string get_valueSQL(String sql)
        {
            MySqlConnection connect = new MySqlConnection(_connectionString);
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.Connection = connect;
            connect.Open();
            string value = Convert.ToString(command.ExecuteScalar());
            connect.Close();
            return value;
        }
        //ExecuteNonQuery: Insert, Update, Delete
        public static bool ExecuteNonQuery(String sql)
        {
            bool kq;
            MySqlConnection connect = new MySqlConnection(_connectionString);
            connect.Open();
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            connect.Close();
            return kq;
        }
    }
}
