using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Client_chat.Dao
{


    class UserManager : DBManager
    {

        private List<User> data;

        public List<User> Data { get => data; set => data = value; }

        public UserManager()
        {
            data = new List<User>();
        }


        protected override object Map(IDataRecord _record)
        {
            return null;
        }
    }
}
