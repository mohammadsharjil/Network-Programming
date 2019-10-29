using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace GroupChatProject
{
    class SocketHelp
    {
        public static int SendVarData(Socket s, byte[] data)
        {
            try
            {
                
                int total = 0;
                int size = data.Length;
                int dataleft = size;
                int sent;
                byte[] datasize = new byte[4];
                datasize = BitConverter.GetBytes(size);
                sent = s.Send(datasize);
                while (total < size)
                {
                    sent = s.Send(data, total, dataleft, SocketFlags.None);
                    total += sent;
                    dataleft -= sent;
                }
                return total;
            }
            catch (Exception)
            {
            }
            return 0;
        }
        public static byte[] ReceiveVarData(Socket s)
        {
            try
            {
                int total = 0;
                int recv = 0;
                byte[] datasize = new byte[4];
                recv = s.Receive(datasize, 0, 4, 0);
                int size = BitConverter.ToInt32(datasize, 0);
                int dataleft = size;
                byte[] data = new byte[size];
                while (total < size)
                {
                    recv = s.Receive(data, total, dataleft, 0);
                    if (recv == 0)
                    {
                        data = Encoding.ASCII.GetBytes("exit ");
                        break;
                    }
                    total += recv;
                    dataleft -= recv;
                }
                return data;
            }
            catch (Exception)
            {}
            return null;
        }
    }
}
