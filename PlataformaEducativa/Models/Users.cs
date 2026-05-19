/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 12:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace PlataformaEducativa.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }  // "Admin" o "Jugador"
        public int Score { get; set; }
    }
}