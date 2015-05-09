using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace SocketDemo
{
    class Program
    {
        private static byte[] result = new byte[1024];
        private static int myProt = 8885; 
        static Socket serverSocket;
        static void Main(string[] args)
        { 
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(ip, myProt));
            serverSocket.Listen(10); 
            Console.WriteLine("启动监听{0}成功", serverSocket.LocalEndPoint.ToString()); 
            Thread myThread = new Thread(ListenClientConnect); 
            myThread.Start(); 
            Console.ReadLine();
        }

        /// <summary>  
        /// 监听客户端连接  
        /// </summary>
        static List<Socket> m_ClientSocketList = new List<Socket>();
        private static void ListenClientConnect()
        {
            while (true)
            {
                var socket = serverSocket.Accept();
                if (!m_ClientSocketList.Contains(socket))
                    m_ClientSocketList.Add(socket); 
                socket.Send(Encoding.UTF8.GetBytes("Connect to server!!!"));
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(socket);//创建客户端消息接受监听 线程
            }
        }

        /// <summary>  
        /// ReceiveMessage 
        /// </summary>  
        /// <param name="clientSocket"></param>
        private static void ReceiveMessage(object clientSocket)
        {
            Socket myClientSocket = (Socket)clientSocket;//接收到的socket对象
            while (true)
            {
                try
                {
                    //通过clientSocket接收数据  
                    int receiveNumber = myClientSocket.Receive(result);//获取socket对象的内容长度

                    Console.WriteLine("接收客户端{0}消息{1}", myClientSocket.RemoteEndPoint.ToString(), Encoding.ASCII.GetString(result, 0, receiveNumber));
                    string data = String.Format("\n{0}:{1}", myClientSocket.RemoteEndPoint.ToString(),Encoding.ASCII.GetString(result, 0, receiveNumber));
                    foreach(var csocket in m_ClientSocketList)
                    {
                        //try
                        //{
                            //if(!Equals(csocket,myClientSocket))
                             csocket.Send(Encoding.ASCII.GetBytes(data));//无需屏蔽自己
                        //}
                        //catch
                        //{ 
                        //    csocket.Shutdown(SocketShutdown.Both);//停止socket服务
                        //    csocket.Close();//关闭socket
                        //} 
                    } 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    m_ClientSocketList.Remove(myClientSocket);
                    myClientSocket.Shutdown(SocketShutdown.Both);//停止socket服务
                    myClientSocket.Close();//关闭socket
                    break;
                }
            }
        }
    }  
}
