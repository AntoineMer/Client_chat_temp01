using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client_chat.Dao;
using System.Data;
using System.Data.SqlClient;

namespace Client_chat
{
    abstract class DBManager
    {
        protected List<object> data;
        protected DBConnection DBConnection;
        protected string tableName;
        protected string tablePk;

        abstract protected object Map(IDataRecord _record);
        protected List<T> Execute<T>(SqlDataReader _reader)
        {
            return null;
        }
       public List<T> FetchAll<T>()
        {
            return null;
        }
        public List<T> Query<T>(string _query)
        {
            return null;
        }
        public T Find<T>(string _searchPattern)
        {
            return default(T);
        }
        public List<T> FindAll<T>(string _searchColumn, string _searchPattern)
        {
            return null;
        }
    }
}
