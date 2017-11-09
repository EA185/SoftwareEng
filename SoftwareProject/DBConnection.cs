using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SoftwareProject
{
    class DBConnection
    {
        private static DBConnection _instance;

        private static string connectionString;

        private SqlConnection connectionToDB;

        private SqlDataAdapter dataAdapter;

        public static string ConnectionStr
        {
            set
            {
                connectionString = value;
            }
        }

        public static DBConnection GetDBConnectionInstance()
        {
            if (_instance == null)
                _instance = new DBConnection();

            return _instance;
        }

        public void OpenConnection()
        {
            connectionToDB = new SqlConnection(connectionString);

            connectionToDB.Open();
        }

        public void CloseConnection()
        {
            connectionToDB.Close();
        }

        public DataSet GetDataSet(string sqlStatement)
        {
            DataSet dataSet = new DataSet();

            OpenConnection();

            dataAdapter = new SqlDataAdapter(sqlStatement, connectionToDB);

            dataAdapter.Fill(dataSet);

            CloseConnection();

            return dataSet;
        }
        
    }
}
