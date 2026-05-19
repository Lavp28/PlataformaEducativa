/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 12:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace PlataformaEducativa
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=localhost;Database=PlataformaEducativa;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static void SetConnectionString(string server, string database, string user, string password)
        {
            connectionString = "Server=" + server + ";Database=" + database + ";Uid=" + user + ";Pwd=" + password + ";";
        }
    }
}