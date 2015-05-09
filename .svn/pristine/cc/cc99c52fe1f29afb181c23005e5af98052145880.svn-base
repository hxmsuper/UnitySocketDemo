using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class RTSocketTest : MonoBehaviour {

    private SocketClient client;
    string content = "";
    private Rect m_MessagePanelRect;
    private Vector2 scrollPosition = Vector2.zero;
	void Start () {
        float panelWidth = Screen.width/2-40;
        float panelHeight = Screen.height/2-40;
        m_MessagePanelRect = new Rect(Screen.width/2-panelWidth/2,Screen.height/2-panelHeight/2,panelWidth,panelHeight);
        client = new SocketClient("127.0.0.1", "8885");
        client.StartSocket();
	}
    void Window1(int id)
    {
        scrollPosition = GUI.BeginScrollView(new Rect(5, 5, m_MessagePanelRect.width-5, m_MessagePanelRect.height-40), scrollPosition, new Rect(0, 0, m_MessagePanelRect.width - 100, SocketClient.m_MessageList.Count*40));
        for (int i = 0; i < SocketClient.m_MessageList.Count; i++)
        {
            GUI.Label(new Rect(5,i*30,m_MessagePanelRect.width-50,40),SocketClient.m_MessageList[i].ToString());
        } 
        GUI.EndScrollView();
        content = GUI.TextField(new Rect(5, m_MessagePanelRect.height - 35,m_MessagePanelRect.width-110, 30), content);
        if (GUI.Button(new Rect(m_MessagePanelRect.width-105,m_MessagePanelRect.height-35,100,30),"Send"))
        {
            client.SendMessage(content);
            content = "";
        }
    }
	void OnGUI()
    { 
        m_MessagePanelRect = GUI.Window(0, m_MessagePanelRect, Window1, ""); 
    }
	void  OnDisable()
    { 
      client. StopConnect();
      client = null;
    }
}
