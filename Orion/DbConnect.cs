using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Orion {
    class DbConnect {
        private readonly string Hostname = "db4free.net";
        private readonly string Port = "3306";
        private readonly string DBName = "oriondb";
        private readonly string Username = "oriondb";
        private readonly string Password = "%cBGkdk9^dG0*j98";
        public string MySQLConnectionString;
        MySqlConnection Conn;
        public DbConnect() {
            MySQLConnectionString = String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", Hostname, Port, DBName, Username, Password);
            Conn = new MySqlConnection(MySQLConnectionString);
            Conn.Open();
        }
        public MySqlDataReader ExecQuery(string command) {
            MySqlCommand cmd = new MySqlCommand { CommandText = command };
            return cmd.ExecuteReader();
        }
        public int ExecNonQuery(string command){
            MySqlCommand cmd = new MySqlCommand { CommandText = command };
            return cmd.ExecuteNonQuery();
        }
        ~DbConnect() {
            Conn.Close();
        }
    }
}
