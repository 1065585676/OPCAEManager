using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Softing.OPCToolbox;
using System.IO;
using System.Collections.Generic;


namespace CShapTest
{
    public partial class MainWindow : Form
    {
        MyAEServerManager myAEServerManager = null;
        MyOPCClientManager myOPCClientManager = null;

        Thread getMsgCount = null;
        bool isStopGetMsgThread = false;

        private SynchronizationContext _syncContext = null; //通知主UI更新

        public MainWindow()
        {
            InitializeComponent();

            _syncContext = SynchronizationContext.Current;

            if (File.Exists("./Config/Connect.config"))
            {
                string info = File.ReadAllText("./Config/Connect.config");
                string[] result = info.Split('@');
                if (result.Length == 5)
                {
                    AEServerIp.Text = result[0];
                    AEServerPort.Text = result[1];
                    OPCServerIp.Text = result[2];
                    ClassID.Text = result[3];
                    ProgramID.Text = result[4];
                }
            }
            else
            {
                //初始化 IP 输入框
                IPAddress[] ipadrlist = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress ipa in ipadrlist)
                {
                    if (ipa.AddressFamily == AddressFamily.InterNetwork)
                    {
                        AEServerIp.Text = ipa.ToString();
                        break;
                    }
                }
            }

            myAEServerManager = new MyAEServerManager(this);
            myOPCClientManager = new MyOPCClientManager(this);

            Startup.Enabled = true;
            Stop.Enabled = false;

            AlarmServerLight.BackColor = System.Drawing.Color.Orange;
            OPCServerLight.BackColor = System.Drawing.Color.Orange;
            DataCacheLight.BackColor = System.Drawing.Color.Green;

            if (!Directory.Exists("./Config"))
            {
                Directory.CreateDirectory("./Config");
            }
        }

        private void Startup_Click(object sender, EventArgs e)
        {
            Startup.Enabled = false;
            LogMsg.Clear();

            Thread startupThread = new Thread(StartupThread);
            startupThread.IsBackground = true;
            startupThread.Start();
        }

        private void StartupThread()
        {
            //_syncContext.Post(AppendTextToLogMsg, "StartupThread开启了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");

            try
            {
                isStopGetMsgThread = false;

                _syncContext.Post(AppendTextToLogMsg, "正在连接OPC服务器，请稍等...\n");
                myOPCClientManager.ConnectOPCServer();     //连接 OPCServer
                _syncContext.Post(AppendTextToLogMsg, "已连接OPC服务器");
                OPCServerLight.BackColor = System.Drawing.Color.Green;

                _syncContext.Post(AppendTextToLogMsg, "正在启动AE服务器，请稍等...\n");
                myAEServerManager.StartAEServer();      //启动 AEServer 
                _syncContext.Post(AppendTextToLogMsg, "已启动AE服务器：" + myAEServerManager.GetAEServerInfo() + "监听. \n");
                AlarmServerLight.BackColor = System.Drawing.Color.Green;

                _syncContext.Post(AppendTextToLogMsg, "正在启动消息监控线程，请稍等...\n");
                getMsgCount = new Thread(GetMsgCountInfo);
                getMsgCount.IsBackground = true;
                getMsgCount.Start();
                _syncContext.Post(AppendTextToLogMsg, "已启动消息监控线程.\n");

                _syncContext.Post(ButtonControl, "Startup:OFF");
                _syncContext.Post(ButtonControl, "Stop:ON");
            }
            catch (Exception ex)
            {
                _syncContext.Post(AppendTextToLogMsg, "启动出现异常:" + ex.Message + "\n");

                OPCServerLight.BackColor = System.Drawing.Color.Red;
                AlarmServerLight.BackColor = System.Drawing.Color.Red;

                Stop_Click(null, null);
            }

            //_syncContext.Post(AppendTextToLogMsg, "StartupThread退出了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");
        }

        private void GetMsgCountInfo()
        {
            //_syncContext.Post(AppendTextToLogMsg, "GetMsgCountInfo开启了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");

            string msg = string.Empty;
            while (!isStopGetMsgThread)
            {
                msg = MessageQueueTool.MESSAGE_TOTAL_COUNT + "@" + MessageQueueTool.Count() + "@" + MessageQueueTool.MESSAGE_SEND_TIME;
                _syncContext.Post(SetMsgCountInfo, msg);
                Thread.Sleep(1000);
            }

            //_syncContext.Post(AppendTextToLogMsg, "GetMsgCountInfo退出了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Thread stopThread = new Thread(StopThread);
            stopThread.IsBackground = true;
            stopThread.Start();
        }

        private void StopThread()
        {
            //_syncContext.Post(AppendTextToLogMsg, "StopThread开启了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");

            isStopGetMsgThread = true;

            _syncContext.Post(AppendTextToLogMsg, "正在停止消息监控线程，请稍等...\n");
            while (getMsgCount != null && getMsgCount.ThreadState != ThreadState.Stopped) Thread.Sleep(1000);
            _syncContext.Post(AppendTextToLogMsg, "已停止消息监控线程.\n");


            _syncContext.Post(AppendTextToLogMsg, "正在停止AE服务器，请稍等...\n");
            myAEServerManager.StopAEServer();
            _syncContext.Post(AppendTextToLogMsg, "已停止AE服务器.\n");
            AlarmServerLight.BackColor = System.Drawing.Color.Orange;


            _syncContext.Post(AppendTextToLogMsg, "正在停止OPC数据接收，请稍等...\n");
            myOPCClientManager.StopConnectedOPC();
            _syncContext.Post(AppendTextToLogMsg, "已停止OPC数据接收.\n");
            OPCServerLight.BackColor = System.Drawing.Color.Orange;


            _syncContext.Post(ButtonControl, "Startup:ON");
            _syncContext.Post(ButtonControl, "Stop:OFF");

            //_syncContext.Post(AppendTextToLogMsg, "StopThread退出了线程：" + Thread.CurrentThread.ManagedThreadId.ToString() + "\n");
        }

        //LogMsg窗口自动滚动到最后一行
        private void LogMsg_TextChanged(object sender, EventArgs e)
        {
            LogMsg.Select(LogMsg.Text.Length, 0);
            LogMsg.ScrollToCaret();
        }

        private void SetMsgCountInfo(object text)
        {
            //winForm.LogMsg.AppendText(text.ToString());
            string msg = text.ToString();
            string[] re = msg.Split('@');
            if (re.Length == 3)
            {
                MsgRecCount.Text = re[0];
                MsgCacheCount.Text = re[1];
                MsgSendTime.Text = re[2];

                //调整cache指示灯
                short dataCacheLight = short.Parse(MsgCacheCount.Text);
                if (dataCacheLight >= MessageQueueTool.MESSAGE_QUEUE_MAX_LENGTH * 0.8)
                {
                    DataCacheLight.BackColor = System.Drawing.Color.Red;
                }
                else if (dataCacheLight >= MessageQueueTool.MESSAGE_QUEUE_MAX_LENGTH * 0.5)
                {
                    DataCacheLight.BackColor = System.Drawing.Color.Orange;
                }
                else
                {
                    DataCacheLight.BackColor = System.Drawing.Color.Green;
                }

            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("保存当前配置信息？\n(右键点击‘应用’可删除配置文件)", "保存", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                string info = AEServerIp.Text + "@" + AEServerPort.Text + "@" + OPCServerIp.Text + "@" + ClassID.Text + "@" + ProgramID.Text;
                File.WriteAllText("./Config/Connect.config", info);
                MessageBox.Show("已保存配置信息！", "提示");
            }
        }

        private void Apply_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult result = MessageBox.Show("确定删除Config.plist？所有配置信息将删除！\n(此操作不可逆)", "重置", MessageBoxButtons.YesNo);
                if (result.Equals(DialogResult.Yes))
                {
                    File.Delete("./Config/Connect.config");
                    MessageBox.Show("已重置配置信息！", "提示");
                }
            }
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseManager lm = new LicenseManager();
            lm.ShowDialog(this);
        }


        private void AppendTextToLogMsg(object text)
        {
            LogMsg.AppendText(text.ToString());
        }

        private void ButtonControl(object operation)
        {
            string op = operation.ToString();
            if (op.Equals("Startup:ON"))
            {
                Startup.Enabled = true;
            }
            else if (op.Equals("Startup:OFF"))
            {
                Startup.Enabled = false;
            }
            else if (op.Equals("Stop:ON"))
            {
                Stop.Enabled = true;
            }
            else if (op.Equals("Stop:OFF"))
            {
                Stop.Enabled = false;
            }
        }
    }
}
