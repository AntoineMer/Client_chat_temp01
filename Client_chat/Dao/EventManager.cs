using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_chat.Dao
{
    class EventManager : DBManager
    {
        protected List<@event> data;

        protected override object Map(IDataRecord _record)
        {
            throw new NotImplementedException();
        }
    }
}
