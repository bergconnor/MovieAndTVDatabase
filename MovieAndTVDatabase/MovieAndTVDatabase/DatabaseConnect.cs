using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MovieAndTVDatabase
{
    public class DatabaseConnect
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
            string query = String.Format("INSERT INTO accounts (email,password,start,end) VALUES ('{0}','{1}','{2}','{3}')",
                email, password, start, end);
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

                return result[0];
            }
            return null;
        }

        public List<string>[] GetUserIDs(string email)
        {
            string query = String.Format("SELECT u.name, u.id " +
                                         "FROM users u " +
                                           "JOIN accounts a " +
                                             "ON a.id = u.account_id " +
                                         "WHERE email='{0}'", email);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string>[] result = new List<string>[2];
                result[0] = new List<string>();
                result[1] = new List<string>();

                while (rdr.Read())
                {
                    result[0].Add(rdr["name"] + "");
                    result[1].Add(rdr["id"] + "");
                }

                rdr.Close();
                this.CloseConnection();

                return result;
            }
            return null;
        }

        public List<string>[] GetMembershipInfo(string email)
        {
            string query = String.Format("SELECT date(start) start, " +
                                         "date(end) end, " +
                                         "subscription_length(start) membership " +
                                         "FROM accounts " +
                                         "WHERE email='{0}'", email);
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[3];
                    result[0] = new List<string>();
                    result[1] = new List<string>();
                    result[2] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["start"] + "");
                        result[1].Add(rdr["end"] + "");
                        result[2].Add(rdr["membership"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    return result;
                }
            }
            catch (MySqlException ex)
            {
                this.CloseConnection();
                return null;
            }
            return null;
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

        public string GetShowLink(string id)
        {
            try
            {
                string query = String.Format("SELECT poster FROM shows where id='{0}'", id);
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

        public string[] GetMovieDetails(string id)
        {
            try
            {
                string query = String.Format("SELECT display_name(name) name, homepage, description " +
                                             "FROM shows where id='{0}'", id);
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    string[] result = new string[3];

                    while (rdr.Read())
                    {
                        result[0] = (rdr["name"] + "");
                        result[1] = (rdr["homepage"] + "");
                        result[2] = (rdr["description"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    if (result.Length > 0)
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

        public List<string>[] GetResults(string genre, string actor, string show, string type)
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

            string query = String.Format("SELECT display_name(s.name) as name, s.id " +
                                         "FROM shows s {0} {1} {2} " +
                                         "WHERE s.name like sanitize_search('{3}') {4} {5} {6} order by s.name",genre2a,actor2a,type2a,show,actor2b,genre2b,type2b);
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[2];
                    result[0] = new List<string>();
                    result[1] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["name"] + "");
                        result[1].Add(rdr["id"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    return result;
                }
            }
            catch (MySqlException ex)
            {
                this.CloseConnection();
                return null;
            }
            return null;
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

        public void addHistory(string email, string userName, string showId)
        {
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
            }

            catch (MySqlException ex) { }

        }

        public void addFavorite(string email, string userName, string showId)
        {
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
                this.CloseConnection();
                //return "";
            }
        }

        public void removeFavorite(string email, string userName, string showId)
        {
            string date = "20161210";
            DateTime today = DateTime.Today;
            date = today.ToString("yyyy/MM/dd");
            string userId = getSingleUser(email, userName);
            try
            {
                string query = String.Format("delete from favorites where user_id = {0} and show_id = {1} ", userId, showId);
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
                this.CloseConnection();
                //return "";
            }
        }

        public List<string> GetFavorites(string userId)
        {
            string query = String.Format("select s.name name from favorites h " +
                                         "join shows s on s.id = h.show_id " +
                                         "where h.user_id = {0}", userId
                                         );

            try
            {
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


            }

            catch (MySqlException ex)
            {
                this.CloseConnection();
                return new List<string>();
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

        public string getSingleFavorit(string userId, string showId)
        {
            string query = String.Format("select s.name name from favorites h " +
                                         "join shows s on s.id = h.show_id " +
                                         "where h.user_id = {0} and s.id = '{1}'", userId, showId
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

        public List<string> GetActors(string id)
        {
            string query = String.Format("SELECT a.name name " +
                                         "FROM actors a " +
                                           "JOIN show_actor sa " +
                                             "ON sa.actor_id = a.id " +
                                           "JOIN shows s " +
                                             "ON s.id = sa.show_id " +
                                         "WHERE s.id={0}", id);

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

        public List<string> GetShowGenres(string id)
        {
            string query = String.Format("SELECT g.name name " +
                                         "FROM genres g " +
                                           "JOIN show_genre sg " +
                                             "ON sg.genre_id = g.id " +
                                           "JOIN shows s " +
                                             "ON s.id = sg.show_id " +
                                         "WHERE s.id={0}", id);

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

        public string MovieTVShow(string id)
        {

            string query = String.Format("SELECT distinct s.name " +
                                         "FROM shows s " +
                                            "JOIN movies m " + 
                                                "ON s.id = m.show_id " +
                                         "WHERE s.id = {0}", id);

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
                    return "Movie";
                }
            }

            return "TV Show";
        }

        public string GetChannel(string id)
        {
            try
            {
                string query = String.Format("SELECT se.channel FROM series se JOIN shows s on s.id = se.show_id  WHERE s.id={0}", id);



                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    string result= "";
                    while (rdr.Read())
                    {
                        result = (rdr["channel"] + "");
                    }
                    rdr.Close();
                    this.CloseConnection();
                    return result;
                }
                return "";
            }
            catch (MySqlException ex)
            {
                return "";
            }
        }

        public int GetSeason(string id)
        {
            string query = String.Format("SELECT num " +
                                         "FROM seasons " +
                                         "WHERE show_id = {0}", id);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int result = 0;

                while (rdr.Read())
                {
                    result = Convert.ToInt32(rdr["num"] + "");
                }

                rdr.Close();
                this.CloseConnection();

                if (result > 0)
                {
                    return result;
                }
            }
            return 0;
        }

        public List<string>[] GetEpisode(string id, string season)
        {
            string query = String.Format("SELECT num, air_date, name " +
                                         "FROM episodes " +
                                         "WHERE show_id = {0} and season_num = {1}", id,season);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string>[] results = new List<string>[3];
                results[0] = new List<string>();
                results[1] = new List<string>();
                results[2] = new List<string>();

                while (rdr.Read())
                {
                    results[0].Add(rdr["num"] + "");
                    results[1].Add(rdr["air_date"] + "");
                    results[2].Add(rdr["name"] + "");
                }

                rdr.Close();
                this.CloseConnection();

                return results;
            }
            return null;
        }

        public string GetETitle(string id, string episode)
        {
            string query = String.Format("SELECT name " +
                                         "FROM episodes " +
                                         "WHERE show_id = {0} and num = {1}", id, episode);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                string result = "";

                while (rdr.Read())
                {
                    result = (rdr["name"] + "");
                }

                rdr.Close();
                this.CloseConnection();
                
                    return result;

            }
            return "";
        }


        public List<string>[] GetFavoriteGenres(string user_id)
        {
            string query = String.Format("select x.genre_id as genre_id, count(*) count " +
                                         "from (select * from vfavorites " +
                                               "where user_id = {0}) x " +
                                         "group by x.genre_id " +
                                         "order by count desc", user_id);

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[2];
                    result[0] = new List<string>();
                    result[1] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["genre_id"] + "");
                        result[1].Add(rdr["count"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    return result;
                }
                catch (MySqlException ex)
                {
                    this.CloseConnection();
                    return null;
                }

            }
            return null;
        }

        public List<string>[] GetRecommendations(string email, string user, int max)
        {
            List<string>[] users = GetUserIDs(email);
            int index = users[0].IndexOf(user);
            string userID = users[1][index];
            List<string>[] genres = GetFavoriteGenres(userID);

            string query = "select display_name(a.name) name, a.id id from ";
            string join = "(select s.id, s.name " +
                          "from shows s " +
                              "join show_genre sg " +
                                "on sg.show_id = s.id " +
                              "join genres g " +
                                "on g.id = sg.genre_id " +
                          "where g.id = {0}) {1} ";

            char letter = 'a';
            int limit = Math.Min(genres[0].Count, max);

            for (int i = 0; i < limit; i++)
            {
                query += String.Format(join, genres[0][i], letter);
                if ( i > 0)
                {
                    query += String.Format("on {0}.id = {1}.id ", letter, (char)(letter - 1));
                }
                query += "join ";
                letter++;
            }
            query = query.Remove(query.Length - 5);
            query += "order by name";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<string>[] result = new List<string>[2];
                    result[0] = new List<string>();
                    result[1] = new List<string>();

                    while (rdr.Read())
                    {
                        result[0].Add(rdr["name"] + "");
                        result[1].Add(rdr["id"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    return result;
                }
                catch (MySqlException ex)
                {
                    this.CloseConnection();
                    return null;
                }

            }
            return null;
        }

        public void RenewSubscription(string email)
        {
            string account_id = GetAccountID(email);
            DateTime dt = DateTime.Today.AddYears(1);
            string end = dt.ToString("yyyy-MM-dd");
            string query = String.Format("update accounts " +
                                         "set end = '{0}' " +
                                         "where id = {1}", end, account_id);
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
            }
        }

        public bool CheckExpired(string email)
        {
            DateTime dt = DateTime.Today;
            string today = dt.ToString("yyyy-MM-dd");
            string end = GetMembershipInfo(email)[1][0];
            string query = String.Format("select datediff('{0}', curdate()) expired", end);

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
                        result[0].Add(rdr["expired"] + "");
                    }

                    rdr.Close();
                    this.CloseConnection();

                    if (Convert.ToInt32(result[0][0]) < 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    this.CloseConnection();
                    return false;
                }

            }
            return false;
        }

        public void UpdateSubscription(string email)
        {   
            string account_id = GetAccountID(email);
            string end = GetMembershipInfo(email)[1][0];
            DateTime dt = Convert.ToDateTime(end).AddYears(1);
            end = dt.ToString("yyyy-MM-dd");
            string query = String.Format("update accounts " +
                                         "set end = '{0}' " +
                                         "where id = {1}", end, account_id);
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
            }
        }
    }
}
