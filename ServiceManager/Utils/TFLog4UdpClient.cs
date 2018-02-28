using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;

namespace TF.Windows
{
    public delegate void TFTlog4UDPEvent(string Msg);
    class TFLog4UdpClient
    {
        private string _ServerIP;
        private int _ServerPort;
        private int _LocalPort;
        private TFTlog4UDPEvent _OnMsg;
        private bool _Closed;
        //解析日志格式的正则表达式        
        //private readonly Regex m_log_re = new Regex(@"(^ .+? ) ( .+? )([\s\S]*)$");
        private Socket _SocketServer;
        //监听端口返回的socket 
        private EndPoint _SocketClient;
        //接受数据的客户端套接字信息        
        private byte[] _ReceiveBuf = new byte[65536];
        
        public TFLog4UdpClient(string ServerIP,int ServerPort,int LocalPort)
        {
            _ServerIP = ServerIP;
            _ServerPort = ServerPort;
            _LocalPort = LocalPort;
            
        }
    
        public string ServerIP
        {
            get { return _ServerIP;}
            set { _ServerIP = value; }
        }
        public int ServerPort
        {
            get { return _ServerPort; }
            set { _ServerPort = value; }
        }
        public int LocalPort
        {
            get { return _LocalPort; }
            set { _LocalPort = value; }
        }
        public TFTlog4UDPEvent OnMsg
        {
            get { return _OnMsg; }
            set { _OnMsg = value; }
        }
        public void Start()
        {
            _SocketServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint serverPoint = new IPEndPoint(IPAddress.Parse(ServerIP), _ServerPort);
            _SocketServer.Bind(serverPoint); //绑定udp指定端口             
            IPEndPoint clientPoint = new IPEndPoint(IPAddress.Any, 0);
            _SocketClient = (EndPoint)clientPoint;
            _Closed = false;
            //异步通讯方式接受udp数据          
            _SocketServer.BeginReceiveFrom(_ReceiveBuf, 0, _ReceiveBuf.Length, SocketFlags.None, ref _SocketClient, new AsyncCallback(ReceiveData), _SocketClient);           
        }

        private void ReceiveData(IAsyncResult ar)
        {
            int recv_len  = _SocketServer.EndReceiveFrom(ar, ref _SocketClient);
          
            //对接受的数据进行utf8转码         
            string recText = Encoding.UTF8.GetString(_ReceiveBuf, 0, recv_len);
            if (_OnMsg != null)
            {
                _OnMsg(recText);
            }

            if (_Closed) return;
            if (_SocketServer != null) //再次启动异步回调接受udp数据           
                _SocketServer.BeginReceiveFrom(_ReceiveBuf, 0, _ReceiveBuf.Length, SocketFlags.None, ref _SocketClient, new AsyncCallback(ReceiveData), _SocketClient);
        }

        public void Stop()
        {
            _Closed = true;

        }

       
    }
}
