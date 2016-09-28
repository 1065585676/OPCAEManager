namespace CShapTest
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AEServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AEServerIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClassID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProgramID = new System.Windows.Forms.TextBox();
            this.OPCServerIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataCacheLight = new System.Windows.Forms.Label();
            this.OPCServerLight = new System.Windows.Forms.Label();
            this.AlarmServerLight = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MsgSendTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MsgCacheCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MsgRecCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LogMsg = new System.Windows.Forms.RichTextBox();
            this.Apply = new System.Windows.Forms.Button();
            this.Startup = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AEServerPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AEServerIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "监听服务";
            // 
            // AEServerPort
            // 
            this.AEServerPort.Location = new System.Drawing.Point(356, 26);
            this.AEServerPort.Name = "AEServerPort";
            this.AEServerPort.Size = new System.Drawing.Size(134, 20);
            this.AEServerPort.TabIndex = 3;
            this.AEServerPort.Text = "8885";
            this.AEServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号：";
            // 
            // AEServerIp
            // 
            this.AEServerIp.Location = new System.Drawing.Point(80, 26);
            this.AEServerIp.Name = "AEServerIp";
            this.AEServerIp.Size = new System.Drawing.Size(134, 20);
            this.AEServerIp.TabIndex = 1;
            this.AEServerIp.Text = "172.16.17.87";
            this.AEServerIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "报警服务IP：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClassID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ProgramID);
            this.groupBox2.Controls.Add(this.OPCServerIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 92);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPC服务";
            // 
            // ClassID
            // 
            this.ClassID.Location = new System.Drawing.Point(318, 23);
            this.ClassID.Name = "ClassID";
            this.ClassID.Size = new System.Drawing.Size(171, 20);
            this.ClassID.TabIndex = 14;
            this.ClassID.Text = "Yokogawa.ExaopcAECS1.1";
            this.ClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ClassID：";
            // 
            // ProgramID
            // 
            this.ProgramID.Location = new System.Drawing.Point(82, 60);
            this.ProgramID.Name = "ProgramID";
            this.ProgramID.Size = new System.Drawing.Size(406, 20);
            this.ProgramID.TabIndex = 12;
            this.ProgramID.Text = "C14D1500-D13A-11D2-93B9-0060B067C684";
            this.ProgramID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OPCServerIp
            // 
            this.OPCServerIp.Location = new System.Drawing.Point(82, 23);
            this.OPCServerIp.Name = "OPCServerIp";
            this.OPCServerIp.Size = new System.Drawing.Size(134, 20);
            this.OPCServerIp.TabIndex = 10;
            this.OPCServerIp.Text = "172.16.17.51";
            this.OPCServerIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "程序ID：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP地址：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Controls.Add(this.radioButton9);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(12, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 91);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据解析";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(301, 62);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(49, 17);
            this.radioButton6.TabIndex = 30;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "导入";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(246, 62);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(49, 17);
            this.radioButton7.TabIndex = 29;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "空格";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(191, 62);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(49, 17);
            this.radioButton8.TabIndex = 28;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "分号";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(136, 62);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(49, 17);
            this.radioButton9.TabIndex = 27;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "逗号";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(84, 62);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(46, 17);
            this.radioButton10.TabIndex = 26;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "TAB";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "消息分隔符：";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(301, 28);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(49, 17);
            this.radioButton5.TabIndex = 24;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "导入";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(246, 28);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 17);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "空格";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(191, 28);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 17);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "分号";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(136, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "逗号";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(84, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TAB";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "字段分隔符：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataCacheLight);
            this.groupBox4.Controls.Add(this.OPCServerLight);
            this.groupBox4.Controls.Add(this.AlarmServerLight);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.MsgSendTime);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.MsgCacheCount);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.MsgRecCount);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(505, 128);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "通道状态";
            // 
            // DataCacheLight
            // 
            this.DataCacheLight.AutoSize = true;
            this.DataCacheLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DataCacheLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataCacheLight.Location = new System.Drawing.Point(405, 98);
            this.DataCacheLight.Name = "DataCacheLight";
            this.DataCacheLight.Size = new System.Drawing.Size(21, 15);
            this.DataCacheLight.TabIndex = 30;
            this.DataCacheLight.Text = "    ";
            // 
            // OPCServerLight
            // 
            this.OPCServerLight.AutoSize = true;
            this.OPCServerLight.BackColor = System.Drawing.Color.Lime;
            this.OPCServerLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OPCServerLight.Location = new System.Drawing.Point(405, 63);
            this.OPCServerLight.Name = "OPCServerLight";
            this.OPCServerLight.Size = new System.Drawing.Size(21, 15);
            this.OPCServerLight.TabIndex = 29;
            this.OPCServerLight.Text = "    ";
            // 
            // AlarmServerLight
            // 
            this.AlarmServerLight.AutoSize = true;
            this.AlarmServerLight.BackColor = System.Drawing.Color.Lime;
            this.AlarmServerLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlarmServerLight.Location = new System.Drawing.Point(405, 28);
            this.AlarmServerLight.Name = "AlarmServerLight";
            this.AlarmServerLight.Size = new System.Drawing.Size(21, 15);
            this.AlarmServerLight.TabIndex = 28;
            this.AlarmServerLight.Text = "    ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(295, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "数据缓冲使用状态：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(285, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "OPC服务器连接状态：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "报警服务器连接状态：";
            // 
            // MsgSendTime
            // 
            this.MsgSendTime.Location = new System.Drawing.Point(91, 95);
            this.MsgSendTime.Name = "MsgSendTime";
            this.MsgSendTime.ReadOnly = true;
            this.MsgSendTime.Size = new System.Drawing.Size(134, 20);
            this.MsgSendTime.TabIndex = 24;
            this.MsgSendTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "发送时间：";
            // 
            // MsgCacheCount
            // 
            this.MsgCacheCount.Location = new System.Drawing.Point(91, 60);
            this.MsgCacheCount.Name = "MsgCacheCount";
            this.MsgCacheCount.ReadOnly = true;
            this.MsgCacheCount.Size = new System.Drawing.Size(134, 20);
            this.MsgCacheCount.TabIndex = 22;
            this.MsgCacheCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "缓存消息数量：";
            // 
            // MsgRecCount
            // 
            this.MsgRecCount.Location = new System.Drawing.Point(91, 25);
            this.MsgRecCount.Name = "MsgRecCount";
            this.MsgRecCount.ReadOnly = true;
            this.MsgRecCount.Size = new System.Drawing.Size(134, 20);
            this.MsgRecCount.TabIndex = 20;
            this.MsgRecCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "消息接收数量：";
            // 
            // LogMsg
            // 
            this.LogMsg.Location = new System.Drawing.Point(12, 422);
            this.LogMsg.Name = "LogMsg";
            this.LogMsg.ReadOnly = true;
            this.LogMsg.Size = new System.Drawing.Size(505, 142);
            this.LogMsg.TabIndex = 5;
            this.LogMsg.Text = "";
            this.LogMsg.TextChanged += new System.EventHandler(this.LogMsg_TextChanged);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(148, 570);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 34);
            this.Apply.TabIndex = 6;
            this.Apply.Text = "应用";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            this.Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Apply_MouseUp);
            // 
            // Startup
            // 
            this.Startup.Location = new System.Drawing.Point(229, 570);
            this.Startup.Name = "Startup";
            this.Startup.Size = new System.Drawing.Size(75, 34);
            this.Startup.TabIndex = 0;
            this.Startup.Text = "启动";
            this.Startup.UseVisualStyleBackColor = true;
            this.Startup.Click += new System.EventHandler(this.Startup_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(310, 570);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 34);
            this.Stop.TabIndex = 8;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 611);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Startup);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.LogMsg);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据采集 设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Startup;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MsgSendTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MsgCacheCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MsgRecCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label AlarmServerLight;
        private System.Windows.Forms.Label DataCacheLight;
        private System.Windows.Forms.Label OPCServerLight;
        internal System.Windows.Forms.RichTextBox LogMsg;
        internal System.Windows.Forms.TextBox AEServerIp;
        internal System.Windows.Forms.TextBox AEServerPort;
        internal System.Windows.Forms.TextBox OPCServerIp;
        internal System.Windows.Forms.TextBox ClassID;
        internal System.Windows.Forms.TextBox ProgramID;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

