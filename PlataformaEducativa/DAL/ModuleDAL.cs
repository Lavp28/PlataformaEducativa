/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 12:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Data;
using MySql.Data.MySqlClient;
using PlataformaEducativa.Models;
using System.Collections.Generic;

namespace PlataformaEducativa.DAL
{
    public partial class ModuleDAL
    {
        public static DataTable GetAllModules()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ModuleID, ModuleName_Es, ModuleName_En FROM Modules";
                var adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static List<Module> GetModulesList()
        {
            List<Module> list = new List<Module>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT ModuleID, ModuleName_Es, ModuleName_En FROM Modules";
                var cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Module
                        {
                            ModuleID = reader.GetInt32("ModuleID"),
                            Name_Es = reader.GetString("ModuleName_Es"),
                            Name_En = reader.GetString("ModuleName_En")
                        });
                    }
                }
            }
            return list;
        }

        public static bool AddModule(string nameEs, string nameEn)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Modules (ModuleName_Es, ModuleName_En) VALUES (@es, @en)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@es", nameEs);
                cmd.Parameters.AddWithValue("@en", nameEn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool UpdateModule(int id, string nameEs, string nameEn)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Modules SET ModuleName_Es = @es, ModuleName_En = @en WHERE ModuleID = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@es", nameEs);
                cmd.Parameters.AddWithValue("@en", nameEn);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool DeleteModule(int id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Modules WHERE ModuleID = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}