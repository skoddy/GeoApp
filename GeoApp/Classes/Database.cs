using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoApp
{
    public class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Database()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "geoquiz";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<GeoData> GetData(int max, string continent)
        {
            List<GeoData> list = new List<GeoData>();
            string opt = continent;
            string limit = "";
            opt = $" WHERE continentName = '{continent}'";


            if (continent == "All")
            {
                opt = "";
            }

            if (max > 0)
            {
                limit = $"LIMIT {max}";
            }
            string query = $"SELECT id, countryName, flag, capital, continentName FROM geodata {opt} ORDER BY RAND() {limit}";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(new GeoData(
                        dataReader.GetInt32(0),
                        dataReader.GetString(1),
                        dataReader.GetString(2),
                        dataReader.GetString(3),
                        dataReader.GetString(4)
                        ));
                }

                dataReader.Close();
                CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }

        public List<GeoData> GetFalseAnswers(int id, string continent)
        {
            List<GeoData> list = new List<GeoData>();
            string opt = continent;
            opt = $"AND continentName = '{continent}'";


            if (continent == "All")
            {
                opt = "";
            }

            string query = $"SELECT id, countryName, flag, capital, continentName FROM geodata WHERE id != {id} {opt} ORDER BY RAND()";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(new GeoData(
                        dataReader.GetInt32(0),
                        dataReader.GetString(1),
                        dataReader.GetString(2),
                        dataReader.GetString(3),
                        dataReader.GetString(4)
                        ));
                }

                dataReader.Close();
                CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }

        public void SignIn(string displayName, string password)
        {
            string query = $"SELECT id, display_name, password FROM user WHERE display_name = '{displayName}'";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader.GetString(1) == displayName && dataReader.GetString(2) == password)
                    {
                        User.Instance.Id = dataReader.GetInt32(0);
                        User.Instance.DisplayName = dataReader.GetString(1);
                        User.Instance.Authed = true;
                    }
                }

                dataReader.Close();
                CloseConnection();
            }
        }

        public void SignUp(string displayName, string password)
        {
            string query = $"INSERT INTO user VALUES(NULL, '{displayName}', '{password}', 0)";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand checkUserName = new MySqlCommand("SELECT COUNT(*) FROM user WHERE (display_name = @user)", connection);
                    checkUserName.Parameters.AddWithValue("@user", displayName);
                    int userExist = int.Parse(checkUserName.ExecuteScalar().ToString());

                    if (userExist > 0)
                    {
                        MessageBox.Show("Name schon vergeben.");
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Konto erstellt");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                CloseConnection();

            }
        }

        public void SaveHighscore()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string query = $"INSERT INTO highscore VALUES(NULL, '{User.Instance.Id}', '{User.Instance.Score}', '{date}')";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Punkte gespeichert");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                CloseConnection();
            }
        }

        public List<Highscore> GetHighscores(int id = 0)
        {
            List<Highscore> list = new List<Highscore>();
            string query;
            if (id == 0)
            {
                query = $"SELECT h.id, h.user_id, h.score, h.CreatedAt, u.display_name FROM highscore h, user u WHERE h.user_id = u.id ORDER BY h.score DESC";
            }
            else
            {
                query = $"SELECT h.id, h.user_id, h.score, h.CreatedAt, u.display_name FROM highscore h, user u WHERE h.user_id = u.id AND h.user_id = {id} ORDER BY h.score DESC";
            }

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(new Highscore(
                        dataReader.GetInt32(0),
                        dataReader.GetString(4),
                        dataReader.GetInt32(2),
                        dataReader.GetDateTime(3)
                        ));
                }

                dataReader.Close();
                CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
