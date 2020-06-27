using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuanLyCLBVoThuat
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "185.27.134.10";
            int port = 3306;
            string database = "epiz_25095001_astro";
            string username = "epiz_25095001";
            string password = "J5OewZnQujU";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}