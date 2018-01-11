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
        protected SqlConnection connection;
        protected SqlConnectionStringBuilder connectionString;
        protected SqlCommand command;
        protected SqlCommandBuilder commandBuilder;
        protected WindowsIdentity currentUser;
        


        public DBConnection(string _initialCatalog, string _userId, string _dataSource, string _password)
        {
            connectionString = new SqlConnectionStringBuilder();
            connectionString.IntegratedSecurity = false;
            connectionString.InitialCatalog = _initialCatalog;
            connectionString.UserID = _userId;
            connectionString.DataSource = _dataSource;
            connectionString.Password = _password;
            connection = new SqlConnection(connectionString.ConnectionString);
        }

        public bool TestCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                return true;
            else
                return false;
        }

        public void Open()
        {
     
                connection.OpenAsync();
            
        }
        public void Close()
        {
            connection.Close();
        }

        public SqlDataReader Query ()
        {
            command = new SqlCommand();
            command.Connection = connection;
            return command.ExecuteReader();
        }
        public SqlDataReader FetchAll(string _table)
        {
            return null;
        }
    }
}
