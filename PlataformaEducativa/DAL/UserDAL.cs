/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 12:42 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using PlataformaEducativa.Models;
using System.Security.Cryptography;
using System.Text;

namespace PlataformaEducativa.DAL
{
    public partial class UserDAL
    {
        public static User Authenticate(string username, string password)
        {
            string hashed = HashPassword(password);
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT UserID, Username, Role, Score FROM Users WHERE Username = @user AND PasswordHash = @hash";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@hash", hashed);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserID = reader.GetInt32("UserID"),
                            Username = reader.GetString("Username"),
                            Role = reader.GetString("Role"),
                            Score = reader.GetInt32("Score")
                        };
                    }
                }
            }
            return null;
        }

        public static bool CreateUser(string username, string password, string role)
        {
            string hashed = HashPassword(password);
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Users (Username, PasswordHash, Role, Score) VALUES (@user, @hash, @role, 0)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@hash", hashed);
                cmd.Parameters.AddWithValue("@role", role);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool UpdateScore(int userId, int newScore)
        {
            if (newScore < 0) newScore = 0;
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Users SET Score = @score WHERE UserID = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@score", newScore);
                cmd.Parameters.AddWithValue("@id", userId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static int GetUserScore(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT Score FROM Users WHERE UserID = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT UserID, Username, Role, Score FROM Users";
                var adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static bool DeleteUser(int userId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Users WHERE UserID = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes) builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
        
        public static bool UserExists(string username)
		{
   		 using (var conn = DatabaseHelper.GetConnection())
    		{
		        conn.Open();
		        string query = "SELECT COUNT(*) FROM Users WHERE Username = @user";
		        var cmd = new MySqlCommand(query, conn);
		        cmd.Parameters.AddWithValue("@user", username);
		        int count = Convert.ToInt32(cmd.ExecuteScalar());
		        return count > 0;
    		}
		}
    }
}
