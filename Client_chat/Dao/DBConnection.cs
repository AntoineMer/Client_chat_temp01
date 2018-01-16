using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Security.Principal;

namespace Client_chat.Dao
{
    class DBConnection
    {
        private SqlConnection connection;
        protected SqlConnectionStringBuilder connectionString;
        protected SqlCommand command;
        protected SqlCommandBuilder commandBuilder;
        protected WindowsIdentity currentUser;
        private string initialCatalog = Properties.Settings.Default.InitialCatalog;
        private string userId = Properties.Settings.Default.UserID;
        private string dateSource = Properties.Settings.Default.DataSource;
        private string password = Properties.Settings.Default.Psswd;

        public SqlConnection Connection { get => connection; set => connection = value; }

        public DBConnection(/*string _initialCatalog, string _userId, string _dataSource, string _password*/)
        {
            //connectionString = new SqlConnectionStringBuilder();
            //connectionString.IntegratedSecurity = false;
            //connectionString.InitialCatalog = _initialCatalog;
            //connectionString.UserID = _userId;
            //connectionString.DataSource = _dataSource;
            //connectionString.Password = _password;
            //connection = new SqlConnection(connectionString.ConnectionString);
        }
        public void Connect()
        {
            connectionString = new SqlConnectionStringBuilder();
            connectionString.IntegratedSecurity = false;
            connectionString.InitialCatalog = initialCatalog;
            connectionString.UserID = userId;
            connectionString.DataSource = dateSource;
            connectionString.Password = password;
            Connection = new SqlConnection(connectionString.ConnectionString);
            Connection.Open();
   
        }
        public bool TestCon()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                return true;
            else
                return false;
        }

        public bool Open()
        {
                Connection.Open();
                if (TestCon())
                    return true;
                else
                    return false;
        }
        public void Close()
        {
            Connection.Close();
        }

        public SqlDataReader Query ()
        {
            command = new SqlCommand();
            command.Connection = Connection;
            return command.ExecuteReader();
        }
        public SqlDataReader FetchAll(string _table)
        {
            return null;
        }
    }
}
