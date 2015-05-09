using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace SocketDemo
{
    class Program
    {
        private static byte[] result = new byte[1024]; 
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(ip, 8885));
                Console.WriteLine("服务器连接成功");
                Thread thread = new Thread(GetSocketData);
                thread.Start(clientSocket);
            }
            catch
            {
                Console.WriteLine("服务器连接失败，回车退出");
                return;
            }
            while (true)
            {
                String content = Console.ReadLine();
                try
                {
                    SendMessage(clientSocket, content);
                }
                catch
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    break;
                }
            }

            Console.WriteLine("发送完毕，返回键退出");
            Console.ReadLine();
        }


        static void SendMessage(Socket sktObj, string content)
        {
            sktObj.Send(Encoding.UTF8.GetBytes(content));
        }
        static void GetSocketData(Object cclientSocket)
        {
            while (true)
            {
                int receiveLength = ((Socket)cclientSocket).Receive(result);//获取数据
                if (receiveLength > 0)
                {
                    Console.WriteLine("{0}", Encoding.UTF8.GetString(result, 0, receiveLength));
                }

            }
        }
    }
}
