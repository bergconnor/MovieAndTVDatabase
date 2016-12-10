using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MovieAndTVDatabase
{
    class DatabaseConnect
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DatabaseConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "mysql.cis.ksu.edu";
            database = "cberg1";
            uid = "cberg1";
            password = "3c340d";

            string connString = "SERVER=" + server + ";" +
                                "DATABASE=" + database + ";" +
                                "UID=" + uid + ";" +
                                "PASSWORD=" + password + ";";
            conn = new MySqlConnection(connString);
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server. Contact administrator.");
                        break;
                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again.");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool CheckPassword(string email, string password)
        {
            string query = String.Format("SELECT password FROM accounts where email='{0}'", email);
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string>[] result = new List<string>[1];
                result[0] = new List<string>();

                while (rdr.Read())
                {
                    result[0].Add(rdr["password"] + "");
                }

                rdr.Close();
                this.CloseConnection();

                if (result[0].Count > 0)
                {
                    int cmp = String.Compare(password, result[0][0]);
                    if (cmp == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private int GetNumberOfUsers(string id)
        {
            string query = String.Format("SELECT count(*) count " +
                                         "FROM users u " +
                                           "JOIN accounts a " +
                                             "ON a.id = u.account_id " +
                                         "WHERE a.id = {0} " +
                                         "GROUP BY a.id", id);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string>[] result = new List<string>[1];
                result[0] = new List<string>();

                while (rdr.Read())
                {
                    result[0].Add(rdr["count"] + "");
                }

                rdr.Close();
                this.CloseConnection();

                if (result[0].Count > 0)
                {
                    return Convert.ToInt16(result[0][0]);
                }
            }
            return -1;
        }

        private string GetAccountID(string email)
        {
            string query = String.Format("SELECT id FROM accounts where email='{0}'", email);
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string>[] result = new List<string>[1];
                result[0] = new List<string>();

                while (rdr.Read())
                {
                    result[0].Add(rdr["id"] + "");
                }

                rdr.Close();
                this.CloseConnection();

                if (result[0].Count > 0)
                {
                    return result[0][0];
                }
            }
            return "";
        }

        public int SignUp(string name, string email, string password)
        {
            DateTime dt = DateTime.Today;
            string start = dt.ToString("yyyy/MM/dd");
            dt = dt.AddYears(1);
            string end = dt.ToString("yyyy/MM/dd");
            string accessMovies = "TRUE";
            string accessSeries = "TRUE";
            string query = String.Format("INSERT INTO accounts (email,password,start,end,access_movie,access_series) VALUES ('{0}','{1}','{2}','{3}',{4},{5})",
                email, password, start, end, accessMovies, accessSeries);
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return AddUser(name, email);
                }
            }
            catch (MySqlException ex)
            {
                this.CloseConnection();
                return 1;
            }
            return 2;
        }

        private List<int> getUserIDs()
        {
            string query = "SELECT id from users";
            List<int> ids = new List<int>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ids.Add(Convert.ToInt32(rdr["id"]));
                }

                rdr.Close();
                this.CloseConnection();
            }

            return ids;
        }

        public int AddUser(string name, string email)
        {
            Random rnd = new Random();
            List<int> user_ids = getUserIDs();
            string account_id = GetAccountID(email);

            int user_id;
            while (true)
            {
                user_id = rnd.Next(1, 10000);
                if (!user_ids.Contains(user_id))
                {
                    break;
                }
            }

            string query = String.Format("INSERT INTO users (id, name, account_id)" +
                                         "VALUES ({0},'{1}',{2})", user_id, name, account_id);
            try
            {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }
            }
            catch (MySqlException ex)
            {
                this.CloseConnection();
                return ex.Number;
            }
            return 0;
        }

        public int RemoveUser(string name, string email)
        {
            string id = GetAccountID(email);
            string query = String.Format("DELETE u " +
                                         "FROM users u " +
                                           "JOIN accounts a " +
                                             "ON a.id = u.account_id " +
                                         "WHERE a.email='{0}' " +
                                           "AND u.name='{1}'", email, name);

            try
            {
                if (GetNumberOfUsers(id) > 1)
                {
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                }
                else
                {
                    return 3;
                }
            }
            catch (MySqlException ex)
            {
                this.CloseConnection();
                return 4;
            }
            return 0;
        }

        public List<string> GetUsers(string email)
        {
            string query = String.Format("SELECT u.name user " +
                                         "FROM users u " +
                                           "JOIN accounts a " +
                                             "ON a.id = u.account_id " +
                                         "WHERE email='{0}'", email);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string>[] result = new List<string>[1];
                result[0] = new List<string>();

                while (rdr.Read())
                {
                    result[0].Add(rdr["user"] + "");
                }

                rdr.Close();
                this.CloseConnection();

                if (result[0].Count > 0)
                {
                    return result[0];
                }
            }
            return new List<string>();
        }

        public string GetShowLink(string name)
        {
            try
            {
                string query = String.Format("SELECT poster FROM shows where name='{0}'", name);
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[1];
                    result[0] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["poster"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    if (result[0].Count > 0)
                    {
                        return result[0][0];
                    }
                }
                return "";
            }
            catch (MySqlException ex)
            {
                return "";
            }
        }
    }
}
