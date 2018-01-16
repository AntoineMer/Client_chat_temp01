using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Client_chat.Dao
{

    [Serializable]
    class UserManager : DBManager
    {

        private List<User> data = new List<User>();
        public User user;
        public List<User> Data { get => data; set => data = value; }

        public UserManager()
        {
            data = new List<User>();
        }


        protected override object Map(IDataRecord _record)
        {
            return null;
        }

        public bool AddUser(string _login, DateTime _birthday, string _password, string _email)
        {
            
            user = new User();
            user.Login = _login;
            user.Passwd = _password;
            user.Birthday = _birthday;
            user.Email = _email;
            if (!data.Contains(user))
            {
                data.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
