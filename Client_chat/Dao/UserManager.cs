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
        protected List<users> data;
        protected override object Map(IDataRecord _record)
        {
            return null;
        }
    }
}
