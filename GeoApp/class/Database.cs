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

        public List<GeoData> GetData(int max, string continent = "")
        {
            List<GeoData> list = new List<GeoData>();
            string opt = continent;
            string limit = "";
            if (opt != "")
            {
                opt = $" WHERE continentName = '{continent}'";
            }

            if (opt == "All")
            {
                opt = "";
            }

            if (max > 0)
            {
                limit = $"LIMIT {max}";
            }
            string query = $"SELECT id, countryName, countryCode, capital, continentName FROM countries {opt} ORDER BY RAND() {limit}";

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

        public List<GeoData> GetFalseAnswers(int id, string continent = "")
        {
            List<GeoData> list = new List<GeoData>();
            string opt = continent;
            if (opt != "")
            {
                opt = $"AND continentName = '{continent}'";
            }

            if (opt == "All")
            {
                opt = "";
            }

            string query = $"SELECT id, countryName, countryCode, capital, continentName FROM countries WHERE id != {id} {opt} ORDER BY RAND()";

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
    }
}
