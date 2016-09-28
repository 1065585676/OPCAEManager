using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CShapTest
{
    class MyAEServerManager
    {
        private static byte[] AEMsgCache = new byte[1024];  //AE Server 和 Client 消息缓存
        private IPAddress ip;           //报警服务IP
        private int myProt;             //报警服务端口
        private static Socket serverSocket = null;     //报警服务监听 socket

        private Thread myThreadMain;
        Thread sendThread;
        bool isStopSendThread = false;

        private List<Socket> userList = new List<Socket>();            //存储 Client 列表

        private SynchronizationContext _syncContext = null; //通知主UI更新

        private MainWindow winForm = null;

        public MyAEServerManager(MainWindow P_winForm)
        {
            _syncContext = SynchronizationContext.Current;
            winForm = P_winForm;
        }

        public string GetAEServerInfo()
        {
            return serverSocket.LocalEndPoint.ToString();
        }

        public void StopAEServer()
        {
            isStopSendThread = true;
            while (sendThread != null && sendThread.ThreadState != ThreadState.Stopped) Thread.Sleep(1000);

            while (userList.Count > 0)
            {
                if (userList[0] != null)
                {
                    userList[0].Close();
                    userList[0] = null;
                }
                userList.RemoveAt(0);
            }

            if (serverSocket != null)
            {
                serverSocket.Close();
                serverSocket = null;
            }
        }

        public void StartAEServer()
        {
            try
            {
                isStopSendThread = false;

                ip = IPAddress.Parse(winForm.AEServerIp.Text);
                myProt = int.Parse(winForm.AEServerPort.Text);

                serverSocket = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );
                serverSocket.Bind(new IPEndPoint(ip, myProt));  //绑定IP地址：端口
                serverSocket.Listen(10);                        //设定最多10个排队连接请求

                //给客户端发送数据
                sendThread = new Thread(SendMessage);
                sendThread.IsBackground = true;
                sendThread.Start();

                myThreadMain = new Thread(ListenClientConnect);
                myThreadMain.IsBackground = true;
                myThreadMain.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ListenClientConnect()
        {
            //_syncContext.Post(SetLabelText, "ListenClientConnect开启了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");

            Socket clientSocket = null;
            while (true)
            {
                try
                {
                    clientSocket = serverSocket.Accept();
                }
                catch
                {
                    //当单击‘停止监听’或者退出此窗体时 AcceptTcpClient() 会产生异常
                    //因此可以利用此异常退出循环
                    break;
                }

                _syncContext.Post(SetLabelText, "客户端:" + clientSocket.RemoteEndPoint.ToString() + "连入." + "\n");//子线程中通过UI线程上下文更新UI

                clientSocket.Send(Encoding.UTF8.GetBytes("Server Say: 你好"));

                userList.Add(clientSocket);

                //接受客户端消息
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.IsBackground = true;
                receiveThread.Start(clientSocket);
            }

            //_syncContext.Post(SetLabelText, "ListenClientConnect关闭了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");
        }

        /// 接收消息  
        private void ReceiveMessage(object clientSocket)
        {
            //_syncContext.Post(SetLabelText, "ReceiveMessage开启了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");

            Socket myClientSocket = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    //通过clientSocket接收数据  
                    int receiveNumber = myClientSocket.Receive(AEMsgCache);
                    if (receiveNumber == 0) throw new Exception("No Data Receive.");
                    _syncContext.Post(SetLabelText, "接收客户端:" + myClientSocket.RemoteEndPoint.ToString() + "的消息:" + Encoding.UTF8.GetString(AEMsgCache, 0, receiveNumber) + "\n");//子线程中通过UI线程上下文更新UI
                }
                catch (Exception ex)
                {
                    try
                    {
                        _syncContext.Post(SetLabelText, "客户端:" + myClientSocket.RemoteEndPoint.ToString() + "出现异常:" + ex.Message + "\n");//子线程中通过UI线程上下文更新UI
                    }
                    catch { }
                    if (myClientSocket != null)
                    {
                        myClientSocket.Close();
                        myClientSocket = null;
                    }
                    userList.Remove(myClientSocket);
                    break;
                }
            }

            //_syncContext.Post(SetLabelText, "ReceiveMessage关闭了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");
        }

        /// 发送消息  
        private void SendMessage()
        {
           //_syncContext.Post(SetLabelText, "SendMessage开启了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");
 
            AEInfos tempInfo = null;
            string jsonMsg = string.Empty;
            while (!isStopSendThread)
            {
                if (userList.Count <= 0 || MessageQueueTool.Count() <= 0)
                {
                    Thread.Sleep(3000);
                    continue;
                }
                tempInfo = MessageQueueTool.DeMessage();
                jsonMsg = JsonConvert.SerializeObject(tempInfo, Formatting.Indented) + "\n";

                for (int i = 0; i < userList.Count; i++)
                {
                    try
                    {
                        userList[i].Send(Encoding.UTF8.GetBytes(jsonMsg));
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            _syncContext.Post(SetLabelText, "客户端:" + userList[i].RemoteEndPoint.ToString() + "出现异常:" + ex.Message + "\n");//子线程中通过UI线程上下文更新UI
                            userList[i].Close();
                        }
                        catch { }
                        userList.RemoveAt(i);
                        i--;
                    }
                }
            }

            //_syncContext.Post(SetLabelText, "SendMessage关闭了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");
        }

        private void SetLabelText(object text)
        {
            winForm.LogMsg.AppendText(text.ToString());
        }
    }
}
