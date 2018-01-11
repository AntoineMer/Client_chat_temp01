using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_chat.Dao
{
    class group
    {
        int group_id;
        byte group_level;
        string group_name;

        public group()
        {

        }

        public int Group_id { get => group_id; set => group_id = value; }
        public byte Group_level { get => group_level; set => group_level = value; }
        public string Group_name { get => group_name; set => group_name = value; }
    }
}
