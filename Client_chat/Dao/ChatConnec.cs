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
        public static byte[] Connection()
        {

                Client.Init(600, 256);
                IPAddress iP = IPAddress.Parse("192.168.221.171");
                Client.EstablishConnection(iP, 9009);
                byte[] frame = FrameManager.WrapFrame100("Antoine", "vamvam");
                return frame;
       }
        public static byte[] GetFrame()
        {
            byte[] frame;
            Client.GetFrame(out frame);
            return frame;
        }
    }
}
