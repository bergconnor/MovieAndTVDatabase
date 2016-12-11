﻿using System;
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

        public string GetSubscriptionEnd(string email)
        {
            string query = String.Format("SELECT end " +
                             "FROM accounts " +
                             "WHERE email='{0}'", email);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string>[] result = new List<string>[1];
                result[0] = new List<string>();

                while (rdr.Read())
                {
                    result[0].Add(rdr["end"] + "");
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


        public List<string> GetGenres()
        {
            string query = String.Format("SELECT name " +
                                         "FROM genres");

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string>[] result = new List<string>[1];
                result[0] = new List<string>();

                while (rdr.Read())
                {
                    result[0].Add(rdr["name"] + "");
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

        public List<string>[] GetMovieDetails(string name)
        {
            try
            {
                string query = String.Format("SELECT homepage, description " +
                                             "FROM shows where name='{0}'", name);
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[1];
                    result[0] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["homepage"] + "");
                        result[1].Add(rdr["description"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    if (result[0].Count > 0 && result[1].Count > 0)
                    {
                        return result;
                    }
                }
                return null;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }

        public List<string> GetResults(string genre, string actor, string show, string type)
        {
            string genre2a = "join show_genre sg on s.id = sg.show_id join genres g on sg.genre_id = g.id ";
            string genre2b = String.Format("and g.name = '{0}'", genre);
            string actor2a = "join show_actor sa on s.id = sa.show_id join actors a  on sa.actor_id = a.id ";
            string actor2b = String.Format("and a.name like '%{0}%'", actor);
            string type2a = "";
            string type2b = "";

            if (actor == "")
            {
                actor2a = "";
                actor2b = "";
            }

            if (genre == "All Genres")
            {
                genre2a = "";
                genre2b = "";
            }

            switch (type)
            {
                case "Movies":
                    type2a = "join movies m on s.id = m.show_id";
                    type2b = "and m.show_id = s.id";
                    break;
                case "TV Shows":
                    type2a = "join series se on s.id = se.show_id";
                    type2b = "and se.show_id = s.id";
                    break;
            }

            string query = String.Format("SELECT distinct s.name " +
                                         "FROM shows s {0} {1} {2} " +
                                         "WHERE s.name like '%{3}%' {4} {5} {6} order by name",genre2a,actor2a,type2a,show,actor2b,genre2b,type2b);




            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string>[] result = new List<string>[1];
                result[0] = new List<string>();

                while (rdr.Read())
                {
                    result[0].Add(rdr["name"] + "");
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


        public string GetShowId(string name)
        {
            try
            {
                string query = String.Format("SELECT id FROM shows where name='{0}'", name);
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
            catch (MySqlException ex)
            {
                return "";
            }

        }

        public string getSingleUser(string email, string user)
        {
            string query = String.Format("SELECT u.id id " +
                                         "FROM users u " +
                                           "JOIN accounts a " +
                                             "ON a.id = u.account_id " +
                                         "WHERE email='{0}' and u.name = '{1}'", email, user);

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
            //return new List<string>();
            return "";
        }

        public void addHistory(string email, string userName, string showName)
        {

            string showId = GetShowId(showName);//"10";
            string date = "20161210";
            DateTime today = DateTime.Today;
            date = today.ToString("yyyy/MM/dd");
            string userId = getSingleUser(email, userName);

            try
            {
                string query = String.Format("insert into history(user_id, show_id, date) values({0}, {1}, '{2}')", userId, showId, date);
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteReader();
                    this.CloseConnection();
                }
                //return "";
            }

            catch (MySqlException ex)
            {
                //return "";
            }

        }

        public string GetShowId(string name)
        {
            try
            {
                string query = String.Format("SELECT id FROM shows where name='{0}'", name);
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
            catch (MySqlException ex)
            {
                return "";
            }
        }
        public string getSingleUser(string email, string user)
        {
            string query = String.Format("SELECT u.id id " +
                                         "FROM users u " +
                                           "JOIN accounts a " +
                                             "ON a.id = u.account_id " +
                                         "WHERE email='{0}' and u.name = '{1}'", email, user);
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
            //return new List<string>();
            return "";
        }
        public void addHistory(string email, string userName, string showName)
        {
            string showId = GetShowId(showName);//"10";
            string date = "20161210";
            DateTime today = DateTime.Today;
            date = today.ToString("yyyy/MM/dd");
            string userId = getSingleUser(email, userName);
            try
            {
                string query = String.Format("insert into history(user_id, show_id, date) values({0}, {1}, '{2}')", userId, showId, date);
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteReader();
                    this.CloseConnection();
                }
                //return "";
            }
            catch (MySqlException ex)
            {
                //return "";
            }
        }

        public void addFavorite(string email, string userName, string showName)
        {
            string showId = GetShowId(showName);//"10";
            string date = "20161210";
            DateTime today = DateTime.Today;
            date = today.ToString("yyyy/MM/dd");
            string userId = getSingleUser(email, userName);
            try
            {
                string query = String.Format("insert into favorites(user_id, show_id, date) values({0}, {1}, '{2}')", userId, showId, date);
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteReader();
                    this.CloseConnection();
                }
                //return "";
            }
            catch (MySqlException ex)
            {
                //return "";
            }
        }

        public List<string> GetFavorites(string userId)
        {
            string query = String.Format("select s.name name from favorites h " +
                                         "join shows s on s.id = h.show_id " +
                                         "where h.user_id = {0}", userId
                                         );

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[1];
                    result[0] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["name"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    if (result[0].Count > 0)
                    {
                        return result[0];
                    }
                }
                catch (MySqlException ex)
                {
                    return new List<string>();
                }

            }
            return new List<string>();
        }

        public string getSingleFavorit(string userId, string showName)
        {
            string query = String.Format("select s.name name from favorites h " +
                                         "join shows s on s.id = h.show_id " +
                                         "where h.user_id = {0} and name = '{1}'", userId, showName
                                         );

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[1];
                    result[0] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["name"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    if (result[0].Count > 0)
                    {
                        return result[0][0];
                    }
                }
                catch (MySqlException ex)
                {
                    return "";
                }

            }
            return "";
        }

        public string getSingleHistory(string userId, string showName)
        {
            string query = String.Format("select s.name name from history h " +
                                         "join shows s on s.id = h.show_id " +
                                         "where h.user_id = {0} and name = '{1}'", userId, showName
                                         );

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[1];
                    result[0] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["name"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    if (result[0].Count > 0)
                    {
                        return result[0][0];
                    }
                }
                catch (MySqlException ex)
                {
                    return "";
                }

            }
            return "";
        }

        public List<string> GetHistory(string userId)
        {
            string query = String.Format("select s.name name from history h " +
                                         "join shows s on s.id = h.show_id " +
                                         "where h.user_id = {0}", userId
                                         );

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[1];
                    result[0] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["name"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    if (result[0].Count > 0)
                    {
                        return result[0];
                    }
                }
                catch (MySqlException ex)
                {
                    return new List<string>();
                }

            }
            return new List<string>();
        }

    }
}
