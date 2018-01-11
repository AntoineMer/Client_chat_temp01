using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_chat.Dao
{
    class @event
    {
        private DateTime event_date;
        private int event_id;
        private string ip_address, login, message, message_type;

        public @event ()
        {

        }

        public DateTime Event_date { get => event_date; set => event_date = value; }
        public int Event_id { get => event_id; set => event_id = value; }
        public string Login { get => login; set => login = value; }
        public string Ip_address { get => ip_address; set => ip_address = value; }
    }
}
