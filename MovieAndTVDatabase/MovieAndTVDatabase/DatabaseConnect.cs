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
            password = "qy98R6de3c340d";

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

        public void Insert()
        {
            string email = "cberg1@ksu.edu";
            string password = "password";
            DateTime dt = DateTime.Today;
            string start = dt.ToString("yyyy/MM/dd");
            dt.AddYears(1);
            string end = dt.ToString("yyyy/MM/dd");
            string accessMovies = "TRUE";
            string accessSeries = "TRUE";
            string query = String.Format("INERT INTO accounts (email,password,start,end,access_movie,access_series) VALUES ('{0}','{1}','{2}','{3}',{4},{5})", 
                email, password, start, end, accessMovies, accessSeries);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Update()
        {

        }

        public void Delete()
        {

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

        public bool SignUp(string email, string password)
        {
            DateTime dt = DateTime.Today;
            string start = dt.ToString("yyyy/MM/dd");
            dt.AddYears(1);
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
                }
                return true;
            }
            catch (MySqlException ex)
            {
                this.CloseConnection();
                return false;
            }
        }

        /*public List<string>[] Select()
        {
            string email = info[0];
            string query = String.Format("SELECT password FROM accounts where email='{0}'", email);

            List<string>[] result = new List<string>[info.Count];
            result[0] = new List<string>();
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    result[0].Add(rdr["password"] + "");
                }

                rdr.Close();
                this.CloseConnection();

                return result;
            }
            else
            {
                return result;
            }
        }*/

        public int Count()
        {
            return 0;
        }

        public void Backup()
        {

        }

        public void Restore()
        {

        }
    }
}
