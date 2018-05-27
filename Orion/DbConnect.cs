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
            MySQLConnectionString = String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", Hostname, Port, DBName, Username, Password);
            Conn = new MySqlConnection(MySQLConnectionString);
            Conn.Open();
        }
        public MySqlDataReader ExecQuery(string command) {
            MySqlCommand cmd = new MySqlCommand(command, Conn);
            return cmd.ExecuteReader();
        }
        public int ExecNonQuery(string command){
            MySqlCommand cmd = new MySqlCommand(command, Conn);
            return cmd.ExecuteNonQuery();
        }
        ~DbConnect() { Conn.Close(); }
        static public string EscapeLikeValue(string value) {
            StringBuilder sb = new StringBuilder(value.Length);
            for (int i = 0; i < value.Length; i++) {
                char c = value[i];
                switch (c) {
                    case ']':
                    case '[':
                    case '%':
                    case '*':
                        sb.Append("[").Append(c).Append("]");
                        break;
                    case '\'':
                        sb.Append("''");
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString();
        }
    }
}
