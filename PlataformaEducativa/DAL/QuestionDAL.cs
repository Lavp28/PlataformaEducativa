/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 12:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using PlataformaEducativa.Models;

namespace PlataformaEducativa.DAL
{
    public partial class QuestionDAL
    {
        public static DataTable GetQuestionsByModule(int moduleId)
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT QuestionID, QuestionText_Es, QuestionText_En, ImagePath FROM Questions WHERE ModuleID = @mod";
                var adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@mod", moduleId);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static Question GetQuestionWithOptions(int questionId)
        {
            Question q = null;
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sqlQ = "SELECT QuestionID, ModuleID, QuestionText_Es, QuestionText_En, ImagePath FROM Questions WHERE QuestionID = @id";
                var cmdQ = new MySqlCommand(sqlQ, conn);
                cmdQ.Parameters.AddWithValue("@id", questionId);
                using (var reader = cmdQ.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        q = new Question();
                        q.QuestionID = reader.GetInt32("QuestionID");
                        q.ModuleID = reader.GetInt32("ModuleID");
                        q.Text_Es = reader.GetString("QuestionText_Es");
                        q.Text_En = reader.GetString("QuestionText_En");
                        q.ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString("ImagePath");
                    }
                }
                if (q != null)
                {
                    string sqlOpt = "SELECT OptionID, OptionText_Es, OptionText_En, IsCorrect FROM Options WHERE QuestionID = @id";
                    var cmdOpt = new MySqlCommand(sqlOpt, conn);
                    cmdOpt.Parameters.AddWithValue("@id", questionId);
                    using (var optReader = cmdOpt.ExecuteReader())
                    {
                        while (optReader.Read())
                        {
                            Option opt = new Option();
                            opt.OptionID = optReader.GetInt32("OptionID");
                            opt.QuestionID = questionId;
                            opt.Text_Es = optReader.GetString("OptionText_Es");
                            opt.Text_En = optReader.GetString("OptionText_En");
                            opt.IsCorrect = optReader.GetBoolean("IsCorrect");
                            q.Options.Add(opt);
                        }
                    }
                }
            }
            return q;
        }

        public static bool AddQuestion(int moduleId, string textEs, string textEn, string imagePath, List<Option> options)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    string sqlQ = "INSERT INTO Questions (ModuleID, QuestionText_Es, QuestionText_En, ImagePath) VALUES (@mod, @es, @en, @img)";
                    var cmdQ = new MySqlCommand(sqlQ, conn, transaction);
                    cmdQ.Parameters.AddWithValue("@mod", moduleId);
                    cmdQ.Parameters.AddWithValue("@es", textEs);
                    cmdQ.Parameters.AddWithValue("@en", textEn);
                    cmdQ.Parameters.AddWithValue("@img", string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath);
                    cmdQ.ExecuteNonQuery();
                    long questionId = cmdQ.LastInsertedId;

                    foreach (var opt in options)
                    {
                        string sqlOpt = "INSERT INTO Options (QuestionID, OptionText_Es, OptionText_En, IsCorrect) VALUES (@qid, @es, @en, @corr)";
                        var cmdOpt = new MySqlCommand(sqlOpt, conn, transaction);
                        cmdOpt.Parameters.AddWithValue("@qid", questionId);
                        cmdOpt.Parameters.AddWithValue("@es", opt.Text_Es);
                        cmdOpt.Parameters.AddWithValue("@en", opt.Text_En);
                        cmdOpt.Parameters.AddWithValue("@corr", opt.IsCorrect);
                        cmdOpt.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public static bool UpdateQuestion(int questionId, string textEs, string textEn, string imagePath, List<Option> options)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    string sqlQ = "UPDATE Questions SET QuestionText_Es = @es, QuestionText_En = @en, ImagePath = @img WHERE QuestionID = @id";
                    var cmdQ = new MySqlCommand(sqlQ, conn, transaction);
                    cmdQ.Parameters.AddWithValue("@es", textEs);
                    cmdQ.Parameters.AddWithValue("@en", textEn);
                    cmdQ.Parameters.AddWithValue("@img", string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath);
                    cmdQ.Parameters.AddWithValue("@id", questionId);
                    cmdQ.ExecuteNonQuery();

                    string delOpt = "DELETE FROM Options WHERE QuestionID = @id";
                    var cmdDel = new MySqlCommand(delOpt, conn, transaction);
                    cmdDel.Parameters.AddWithValue("@id", questionId);
                    cmdDel.ExecuteNonQuery();

                    foreach (var opt in options)
                    {
                        string sqlOpt = "INSERT INTO Options (QuestionID, OptionText_Es, OptionText_En, IsCorrect) VALUES (@qid, @es, @en, @corr)";
                        var cmdOpt = new MySqlCommand(sqlOpt, conn, transaction);
                        cmdOpt.Parameters.AddWithValue("@qid", questionId);
                        cmdOpt.Parameters.AddWithValue("@es", opt.Text_Es);
                        cmdOpt.Parameters.AddWithValue("@en", opt.Text_En);
                        cmdOpt.Parameters.AddWithValue("@corr", opt.IsCorrect);
                        cmdOpt.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public static bool DeleteQuestion(int questionId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Questions WHERE QuestionID = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", questionId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static List<int> GetUnansweredQuestions(int userId, int moduleId)
        {
            List<int> ids = new List<int>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT q.QuestionID FROM Questions q
                                 LEFT JOIN UserAttempts ua ON q.QuestionID = ua.QuestionID AND ua.UserID = @uid
                                 WHERE q.ModuleID = @mod AND ua.QuestionID IS NULL";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.Parameters.AddWithValue("@mod", moduleId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) ids.Add(reader.GetInt32(0));
                }
            }
            return ids;
        }

        public static bool HasUserAnsweredQuestion(int userId, int questionId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM UserAttempts WHERE UserID = @uid AND QuestionID = @qid";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.Parameters.AddWithValue("@qid", questionId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static bool RegisterAttempt(int userId, int questionId, bool wasCorrect)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Insertar el intento
                        string sqlAttempt = @"INSERT INTO UserAttempts (UserID, QuestionID, WasCorrect) 
                                              VALUES (@uid, @qid, @corr)";
                        using (var cmdAttempt = new MySqlCommand(sqlAttempt, conn, transaction))
                        {
                            cmdAttempt.Parameters.AddWithValue("@uid", userId);
                            cmdAttempt.Parameters.AddWithValue("@qid", questionId);
                            cmdAttempt.Parameters.AddWithValue("@corr", wasCorrect);
                            cmdAttempt.ExecuteNonQuery();
                        }

                        // 2. Llamar al procedimiento almacenado para actualizar estadísticas
                        string sqlUpdateStats = "CALL UpdateModuleStats(@uid, @qid, @corr)";
                        using (var cmdStats = new MySqlCommand(sqlUpdateStats, conn, transaction))
                        {
                            cmdStats.Parameters.AddWithValue("@uid", userId);
                            cmdStats.Parameters.AddWithValue("@qid", questionId);
                            cmdStats.Parameters.AddWithValue("@corr", wasCorrect);
                            cmdStats.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}