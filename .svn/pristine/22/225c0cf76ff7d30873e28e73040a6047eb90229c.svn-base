using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets; 
using System.Text;
using System.Threading;
public class SocketClient
{

    private string m_ServerIP = "";
    private string m_ServerPort = "";

    private static Socket clientSocket;
    private static byte[] result = new byte[1024];
    public static List<string> m_MessageList = new List<string>();
    public SocketClient(string ip, string port)
    {
        m_ServerIP = ip;
        m_ServerPort = port;
    }

    public void StartSocket()
    {
        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        try
        {
            clientSocket.Connect(m_ServerIP, int.Parse(m_ServerPort));
            Debug.Log("Server connect success");
            //Thread thread = new Thread(GetSocketData);
            //thread.Start();
            //Loom.RunAsync(GetSocketData); 
            SocketThread.RunAsync(GetSocketData);
        }
        catch
        {
            Debug.Log("ServerConnect Failed");
            return;
        }
    }
 
   
    public void StopConnect()
    { 
        clientSocket.Close();
    }
    public void SendMessage(string content)
    {
        try
        {

            clientSocket.Send(Encoding.UTF8.GetBytes(content));
        }
        catch
        {
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
    }
    static void GetSocketData()
    {
        while (true)
        {
            int receiveLength = clientSocket.Receive(result);//获取数据
            if (receiveLength > 0)
            {
                string data = Encoding.UTF8.GetString(result, 0, receiveLength);
                m_MessageList.Add(data);
                Debug.Log(data);
                //Console.WriteLine("{0}", );
            }

        }
    }
}
     
