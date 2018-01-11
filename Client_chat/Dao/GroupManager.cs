using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Client_chat.Dao
{
    class GroupManager : DBManager
    {
        protected List<group> data;
        public GroupManager()
        {

        }

        protected override object Map(IDataRecord _record)
        {
            throw new NotImplementedException();
        }
    }
}
