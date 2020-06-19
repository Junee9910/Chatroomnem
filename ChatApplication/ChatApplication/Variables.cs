using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    class Variables
    {
        public static TcpClient tcpclnt;
        public static Stream stm;

        public static string nickName;

        public static PublicChat puC;
    }
}
