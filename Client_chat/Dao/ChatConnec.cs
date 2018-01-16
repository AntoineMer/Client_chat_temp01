using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChatClient;
using SimpleChatFrameManager;
using System.Net;

namespace Client_chat.Dao
{
    class ChatConnec
    {
        byte[] frame;
        public bool Connection()
        {
            Client.Init(600, 256);
            IPAddress iP = IPAddress.Parse(Properties.Settings.Default.ip);
            Client.EstablishConnection(iP, int.Parse(Properties.Settings.Default.port));
            frame = FrameManager.WrapFrame100(Properties.Settings.Default.login, User.Password_Hash(Properties.Settings.Default.passwd));
            if (Client.SendFrame(frame))
                return true;
            else return false;
            
        }

        //public bool verif (byte[] _connection)
        //{
        //    if (Client.SendFrame(_connection))
        //        return true;

        //    else
        //        return false;
        //}
        public void GetMessage(byte[] _frame, out string _moment, out string _time, out string _pseudo, out string _message)
        {
            FrameManager.UnwrapFrame10(_frame, out string moment, out string time, out string pseudo, out string message);
            _moment = moment;
            _time = time;
            _pseudo = pseudo;
            _message = message;
            

        }

        public void Send(string _message)
        {
            byte[] frame = FrameManager.WrapFrame110(_message);
            Client.SendFrame(frame);
        }
        public Dictionary<string, byte> GetUsers(byte[] _frame)
        {
                Dictionary<string, byte> users = new Dictionary<string, byte>();
                FrameManager.UnwrapFrame3(_frame, out users);
                return users;
        }
    }
}