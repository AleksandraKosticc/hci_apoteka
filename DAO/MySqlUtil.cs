using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DAO
{
    static class MySqlUtil
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlHciApoteka"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void Close(MySqlConnection conn)
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public static void Close(MySqlDataReader reader)
        {
            if (reader != null)
            {
                reader.Close();
            }
        }

        public static void Close(MySqlDataReader reader, MySqlConnection conn)
        {
            Close(reader);
            Close(conn);
        }
    }
}