using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_chat.Dao
{
    class users
    {
        public const string SALT;
        private DateTime birthday, registered;
        private string email, gender, passwd;
        private int group_id, login;
        private group user_group;
        private string security_token;

        public users()
        {

        }

        public DateTime Birthday { get => Birthday; set => Birthday = value; }
        public DateTime Birthday1 { get => birthday; set => birthday = value; }
        public string Email { get => email; set => email = value; }
        public int Group_id { get => group_id; set => group_id = value; }
        public string Passwd { get => passwd; }
        public int Login { get => login; set => login = value; }
        internal group User_group { get => user_group; set => user_group = value; }

        public bool Auth(string _temp)
        {
            return false;
        }
    }
}
