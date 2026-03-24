namespace http_client
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_CloseServer = new ReaLTaiizor.Controls.MaterialButton();
            this.rtb_Receive = new System.Windows.Forms.RichTextBox();
            this.crownStatusStrip1 = new ReaLTaiizor.Controls.CrownStatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslb_connect = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_SendUTF8_toServer = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_SendASCII_toServer = new ReaLTaiizor.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ServerPort = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ServerIP = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SendToServer = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btn_ConnectServer = new ReaLTaiizor.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_StopServer = new ReaLTaiizor.Controls.MaterialButton();
            this.rtb_Receive_Server = new System.Windows.Forms.RichTextBox();
            this.crownStatusStrip2 = new ReaLTaiizor.Controls.CrownStatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_SendUTF8_ToClient = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_SendASCII_ToClient = new ReaLTaiizor.Controls.MaterialButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ClientPort = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ClientIP = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_SendToClient = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btn_StartServer = new ReaLTaiizor.Controls.MaterialButton();
            this.label10 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            label11 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.crownStatusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.crownStatusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            label11.Location = new System.Drawing.Point(844, 76);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(179, 46);
            label11.TabIndex = 31;
            label11.Text = "客户端在线列表：";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1134, 647);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btn_CloseServer);
            this.tabPage1.Controls.Add(this.rtb_Receive);
            this.tabPage1.Controls.Add(this.crownStatusStrip1);
            this.tabPage1.Controls.Add(this.btn_SendUTF8_toServer);
            this.tabPage1.Controls.Add(this.btn_SendASCII_toServer);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tb_ServerPort);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_ServerIP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_SendToServer);
            this.tabPage1.Controls.Add(this.btn_ConnectServer);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ImageKey = "客户端.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1126, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "客户端";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 45);
            this.label5.TabIndex = 15;
            this.label5.Text = "客户端";
            // 
            // btn_CloseServer
            // 
            this.btn_CloseServer.AutoSize = false;
            this.btn_CloseServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CloseServer.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_CloseServer.Depth = 0;
            this.btn_CloseServer.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CloseServer.HighEmphasis = true;
            this.btn_CloseServer.Icon = null;
            this.btn_CloseServer.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_CloseServer.Location = new System.Drawing.Point(548, 287);
            this.btn_CloseServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CloseServer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_CloseServer.Name = "btn_CloseServer";
            this.btn_CloseServer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_CloseServer.Size = new System.Drawing.Size(162, 52);
            this.btn_CloseServer.TabIndex = 14;
            this.btn_CloseServer.Text = "断开连接";
            this.btn_CloseServer.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_CloseServer.UseAccentColor = false;
            this.btn_CloseServer.UseVisualStyleBackColor = true;
            this.btn_CloseServer.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // rtb_Receive
            // 
            this.rtb_Receive.Location = new System.Drawing.Point(130, 78);
            this.rtb_Receive.Name = "rtb_Receive";
            this.rtb_Receive.Size = new System.Drawing.Size(250, 302);
            this.rtb_Receive.TabIndex = 13;
            this.rtb_Receive.Text = "";
            // 
            // crownStatusStrip1
            // 
            this.crownStatusStrip1.AutoSize = false;
            this.crownStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.crownStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownStatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.crownStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslb_connect});
            this.crownStatusStrip1.Location = new System.Drawing.Point(3, 557);
            this.crownStatusStrip1.Name = "crownStatusStrip1";
            this.crownStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.crownStatusStrip1.Size = new System.Drawing.Size(1120, 44);
            this.crownStatusStrip1.SizingGrip = false;
            this.crownStatusStrip1.TabIndex = 12;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 29);
            this.toolStripStatusLabel1.Text = "连接状态：";
            // 
            // tslb_connect
            // 
            this.tslb_connect.Name = "tslb_connect";
            this.tslb_connect.Size = new System.Drawing.Size(64, 29);
            this.tslb_connect.Text = "未连接";
            // 
            // btn_SendUTF8_toServer
            // 
            this.btn_SendUTF8_toServer.AutoSize = false;
            this.btn_SendUTF8_toServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SendUTF8_toServer.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_SendUTF8_toServer.Depth = 0;
            this.btn_SendUTF8_toServer.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SendUTF8_toServer.HighEmphasis = true;
            this.btn_SendUTF8_toServer.Icon = null;
            this.btn_SendUTF8_toServer.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_SendUTF8_toServer.Location = new System.Drawing.Point(548, 449);
            this.btn_SendUTF8_toServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SendUTF8_toServer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_SendUTF8_toServer.Name = "btn_SendUTF8_toServer";
            this.btn_SendUTF8_toServer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_SendUTF8_toServer.Size = new System.Drawing.Size(162, 52);
            this.btn_SendUTF8_toServer.TabIndex = 11;
            this.btn_SendUTF8_toServer.Text = "发送UTF-8码";
            this.btn_SendUTF8_toServer.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_SendUTF8_toServer.UseAccentColor = false;
            this.btn_SendUTF8_toServer.UseVisualStyleBackColor = true;
            this.btn_SendUTF8_toServer.Click += new System.EventHandler(this.btn_sendutf8_Click);
            // 
            // btn_SendASCII_toServer
            // 
            this.btn_SendASCII_toServer.AutoSize = false;
            this.btn_SendASCII_toServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SendASCII_toServer.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_SendASCII_toServer.Depth = 0;
            this.btn_SendASCII_toServer.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SendASCII_toServer.HighEmphasis = true;
            this.btn_SendASCII_toServer.Icon = null;
            this.btn_SendASCII_toServer.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_SendASCII_toServer.Location = new System.Drawing.Point(548, 385);
            this.btn_SendASCII_toServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SendASCII_toServer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_SendASCII_toServer.Name = "btn_SendASCII_toServer";
            this.btn_SendASCII_toServer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_SendASCII_toServer.Size = new System.Drawing.Size(162, 52);
            this.btn_SendASCII_toServer.TabIndex = 10;
            this.btn_SendASCII_toServer.Text = "发送ASCII码";
            this.btn_SendASCII_toServer.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_SendASCII_toServer.UseAccentColor = false;
            this.btn_SendASCII_toServer.UseVisualStyleBackColor = true;
            this.btn_SendASCII_toServer.Click += new System.EventHandler(this.btn_sendascii_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "端口：";
            // 
            // tb_ServerPort
            // 
            this.tb_ServerPort.AnimateReadOnly = false;
            this.tb_ServerPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_ServerPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_ServerPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_ServerPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_ServerPort.Depth = 0;
            this.tb_ServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ServerPort.HideSelection = true;
            this.tb_ServerPort.LeadingIcon = null;
            this.tb_ServerPort.Location = new System.Drawing.Point(503, 145);
            this.tb_ServerPort.MaxLength = 32767;
            this.tb_ServerPort.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_ServerPort.Name = "tb_ServerPort";
            this.tb_ServerPort.PasswordChar = '\0';
            this.tb_ServerPort.PrefixSuffixText = null;
            this.tb_ServerPort.ReadOnly = false;
            this.tb_ServerPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_ServerPort.SelectedText = "";
            this.tb_ServerPort.SelectionLength = 0;
            this.tb_ServerPort.SelectionStart = 0;
            this.tb_ServerPort.ShortcutsEnabled = true;
            this.tb_ServerPort.Size = new System.Drawing.Size(250, 48);
            this.tb_ServerPort.TabIndex = 8;
            this.tb_ServerPort.TabStop = false;
            this.tb_ServerPort.Text = "8080";
            this.tb_ServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ServerPort.TrailingIcon = null;
            this.tb_ServerPort.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "服务端IP:";
            // 
            // tb_ServerIP
            // 
            this.tb_ServerIP.AnimateReadOnly = false;
            this.tb_ServerIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_ServerIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_ServerIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_ServerIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_ServerIP.Depth = 0;
            this.tb_ServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ServerIP.HideSelection = true;
            this.tb_ServerIP.LeadingIcon = null;
            this.tb_ServerIP.Location = new System.Drawing.Point(503, 71);
            this.tb_ServerIP.MaxLength = 32767;
            this.tb_ServerIP.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_ServerIP.Name = "tb_ServerIP";
            this.tb_ServerIP.PasswordChar = '\0';
            this.tb_ServerIP.PrefixSuffixText = null;
            this.tb_ServerIP.ReadOnly = false;
            this.tb_ServerIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_ServerIP.SelectedText = "";
            this.tb_ServerIP.SelectionLength = 0;
            this.tb_ServerIP.SelectionStart = 0;
            this.tb_ServerIP.ShortcutsEnabled = true;
            this.tb_ServerIP.Size = new System.Drawing.Size(250, 48);
            this.tb_ServerIP.TabIndex = 6;
            this.tb_ServerIP.TabStop = false;
            this.tb_ServerIP.Text = "127.0.0.1";
            this.tb_ServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ServerIP.TrailingIcon = null;
            this.tb_ServerIP.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "发送数据：";
            // 
            // tb_SendToServer
            // 
            this.tb_SendToServer.AnimateReadOnly = false;
            this.tb_SendToServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_SendToServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_SendToServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_SendToServer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_SendToServer.Depth = 0;
            this.tb_SendToServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_SendToServer.HideSelection = true;
            this.tb_SendToServer.LeadingIcon = null;
            this.tb_SendToServer.Location = new System.Drawing.Point(130, 430);
            this.tb_SendToServer.MaxLength = 32767;
            this.tb_SendToServer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_SendToServer.Name = "tb_SendToServer";
            this.tb_SendToServer.PasswordChar = '\0';
            this.tb_SendToServer.PrefixSuffixText = null;
            this.tb_SendToServer.ReadOnly = false;
            this.tb_SendToServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_SendToServer.SelectedText = "";
            this.tb_SendToServer.SelectionLength = 0;
            this.tb_SendToServer.SelectionStart = 0;
            this.tb_SendToServer.ShortcutsEnabled = true;
            this.tb_SendToServer.Size = new System.Drawing.Size(250, 48);
            this.tb_SendToServer.TabIndex = 4;
            this.tb_SendToServer.TabStop = false;
            this.tb_SendToServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_SendToServer.TrailingIcon = null;
            this.tb_SendToServer.UseSystemPasswordChar = false;
            // 
            // btn_ConnectServer
            // 
            this.btn_ConnectServer.AutoSize = false;
            this.btn_ConnectServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ConnectServer.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ConnectServer.Depth = 0;
            this.btn_ConnectServer.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ConnectServer.HighEmphasis = true;
            this.btn_ConnectServer.Icon = null;
            this.btn_ConnectServer.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_ConnectServer.Location = new System.Drawing.Point(548, 223);
            this.btn_ConnectServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ConnectServer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_ConnectServer.Name = "btn_ConnectServer";
            this.btn_ConnectServer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_ConnectServer.Size = new System.Drawing.Size(162, 52);
            this.btn_ConnectServer.TabIndex = 3;
            this.btn_ConnectServer.Text = "连接服务端";
            this.btn_ConnectServer.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ConnectServer.UseAccentColor = false;
            this.btn_ConnectServer.UseVisualStyleBackColor = true;
            this.btn_ConnectServer.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "接收数据：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(label11);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_StopServer);
            this.tabPage2.Controls.Add(this.rtb_Receive_Server);
            this.tabPage2.Controls.Add(this.crownStatusStrip2);
            this.tabPage2.Controls.Add(this.btn_SendUTF8_ToClient);
            this.tabPage2.Controls.Add(this.btn_SendASCII_ToClient);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tb_ClientPort);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tb_ClientIP);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tb_SendToClient);
            this.tabPage2.Controls.Add(this.btn_StartServer);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.ImageKey = "服务器,服务端.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1126, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "服务端";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(847, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 256);
            this.listBox1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 45);
            this.label6.TabIndex = 29;
            this.label6.Text = "服务端";
            // 
            // btn_StopServer
            // 
            this.btn_StopServer.AutoSize = false;
            this.btn_StopServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_StopServer.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_StopServer.Depth = 0;
            this.btn_StopServer.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_StopServer.HighEmphasis = true;
            this.btn_StopServer.Icon = null;
            this.btn_StopServer.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_StopServer.Location = new System.Drawing.Point(543, 279);
            this.btn_StopServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_StopServer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_StopServer.Name = "btn_StopServer";
            this.btn_StopServer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_StopServer.Size = new System.Drawing.Size(162, 52);
            this.btn_StopServer.TabIndex = 28;
            this.btn_StopServer.Text = "关闭服务";
            this.btn_StopServer.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_StopServer.UseAccentColor = false;
            this.btn_StopServer.UseVisualStyleBackColor = true;
            // 
            // rtb_Receive_Server
            // 
            this.rtb_Receive_Server.Location = new System.Drawing.Point(130, 73);
            this.rtb_Receive_Server.Name = "rtb_Receive_Server";
            this.rtb_Receive_Server.Size = new System.Drawing.Size(250, 302);
            this.rtb_Receive_Server.TabIndex = 27;
            this.rtb_Receive_Server.Text = "";
            // 
            // crownStatusStrip2
            // 
            this.crownStatusStrip2.AutoSize = false;
            this.crownStatusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.crownStatusStrip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownStatusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.crownStatusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.crownStatusStrip2.Location = new System.Drawing.Point(3, 557);
            this.crownStatusStrip2.Name = "crownStatusStrip2";
            this.crownStatusStrip2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.crownStatusStrip2.Size = new System.Drawing.Size(1120, 44);
            this.crownStatusStrip2.SizingGrip = false;
            this.crownStatusStrip2.TabIndex = 26;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 29);
            this.toolStripStatusLabel2.Text = "服务状态：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(64, 29);
            this.toolStripStatusLabel3.Text = "未连接";
            // 
            // btn_SendUTF8_ToClient
            // 
            this.btn_SendUTF8_ToClient.AutoSize = false;
            this.btn_SendUTF8_ToClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SendUTF8_ToClient.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_SendUTF8_ToClient.Depth = 0;
            this.btn_SendUTF8_ToClient.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SendUTF8_ToClient.HighEmphasis = true;
            this.btn_SendUTF8_ToClient.Icon = null;
            this.btn_SendUTF8_ToClient.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_SendUTF8_ToClient.Location = new System.Drawing.Point(543, 447);
            this.btn_SendUTF8_ToClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SendUTF8_ToClient.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_SendUTF8_ToClient.Name = "btn_SendUTF8_ToClient";
            this.btn_SendUTF8_ToClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_SendUTF8_ToClient.Size = new System.Drawing.Size(162, 52);
            this.btn_SendUTF8_ToClient.TabIndex = 25;
            this.btn_SendUTF8_ToClient.Text = "发送UTF-8码";
            this.btn_SendUTF8_ToClient.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_SendUTF8_ToClient.UseAccentColor = false;
            this.btn_SendUTF8_ToClient.UseVisualStyleBackColor = true;
            // 
            // btn_SendASCII_ToClient
            // 
            this.btn_SendASCII_ToClient.AutoSize = false;
            this.btn_SendASCII_ToClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SendASCII_ToClient.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_SendASCII_ToClient.Depth = 0;
            this.btn_SendASCII_ToClient.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SendASCII_ToClient.HighEmphasis = true;
            this.btn_SendASCII_ToClient.Icon = null;
            this.btn_SendASCII_ToClient.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_SendASCII_ToClient.Location = new System.Drawing.Point(543, 383);
            this.btn_SendASCII_ToClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SendASCII_ToClient.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_SendASCII_ToClient.Name = "btn_SendASCII_ToClient";
            this.btn_SendASCII_ToClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_SendASCII_ToClient.Size = new System.Drawing.Size(162, 52);
            this.btn_SendASCII_ToClient.TabIndex = 24;
            this.btn_SendASCII_ToClient.Text = "发送ASCII码";
            this.btn_SendASCII_ToClient.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_SendASCII_ToClient.UseAccentColor = false;
            this.btn_SendASCII_ToClient.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "端口：";
            // 
            // tb_ClientPort
            // 
            this.tb_ClientPort.AnimateReadOnly = false;
            this.tb_ClientPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_ClientPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_ClientPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_ClientPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_ClientPort.Depth = 0;
            this.tb_ClientPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ClientPort.HideSelection = true;
            this.tb_ClientPort.LeadingIcon = null;
            this.tb_ClientPort.Location = new System.Drawing.Point(498, 137);
            this.tb_ClientPort.MaxLength = 32767;
            this.tb_ClientPort.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_ClientPort.Name = "tb_ClientPort";
            this.tb_ClientPort.PasswordChar = '\0';
            this.tb_ClientPort.PrefixSuffixText = null;
            this.tb_ClientPort.ReadOnly = false;
            this.tb_ClientPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_ClientPort.SelectedText = "";
            this.tb_ClientPort.SelectionLength = 0;
            this.tb_ClientPort.SelectionStart = 0;
            this.tb_ClientPort.ShortcutsEnabled = true;
            this.tb_ClientPort.Size = new System.Drawing.Size(250, 48);
            this.tb_ClientPort.TabIndex = 22;
            this.tb_ClientPort.TabStop = false;
            this.tb_ClientPort.Text = "8080";
            this.tb_ClientPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ClientPort.TrailingIcon = null;
            this.tb_ClientPort.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "客户端IP:";
            // 
            // tb_ClientIP
            // 
            this.tb_ClientIP.AnimateReadOnly = false;
            this.tb_ClientIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_ClientIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_ClientIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_ClientIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_ClientIP.Depth = 0;
            this.tb_ClientIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ClientIP.HideSelection = true;
            this.tb_ClientIP.LeadingIcon = null;
            this.tb_ClientIP.Location = new System.Drawing.Point(498, 63);
            this.tb_ClientIP.MaxLength = 32767;
            this.tb_ClientIP.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_ClientIP.Name = "tb_ClientIP";
            this.tb_ClientIP.PasswordChar = '\0';
            this.tb_ClientIP.PrefixSuffixText = null;
            this.tb_ClientIP.ReadOnly = false;
            this.tb_ClientIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_ClientIP.SelectedText = "";
            this.tb_ClientIP.SelectionLength = 0;
            this.tb_ClientIP.SelectionStart = 0;
            this.tb_ClientIP.ShortcutsEnabled = true;
            this.tb_ClientIP.Size = new System.Drawing.Size(250, 48);
            this.tb_ClientIP.TabIndex = 20;
            this.tb_ClientIP.TabStop = false;
            this.tb_ClientIP.Text = "127.0.0.1";
            this.tb_ClientIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ClientIP.TrailingIcon = null;
            this.tb_ClientIP.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "发送数据：";
            // 
            // tb_SendToClient
            // 
            this.tb_SendToClient.AnimateReadOnly = false;
            this.tb_SendToClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_SendToClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_SendToClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_SendToClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_SendToClient.Depth = 0;
            this.tb_SendToClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_SendToClient.HideSelection = true;
            this.tb_SendToClient.LeadingIcon = null;
            this.tb_SendToClient.Location = new System.Drawing.Point(130, 425);
            this.tb_SendToClient.MaxLength = 32767;
            this.tb_SendToClient.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_SendToClient.Name = "tb_SendToClient";
            this.tb_SendToClient.PasswordChar = '\0';
            this.tb_SendToClient.PrefixSuffixText = null;
            this.tb_SendToClient.ReadOnly = false;
            this.tb_SendToClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_SendToClient.SelectedText = "";
            this.tb_SendToClient.SelectionLength = 0;
            this.tb_SendToClient.SelectionStart = 0;
            this.tb_SendToClient.ShortcutsEnabled = true;
            this.tb_SendToClient.Size = new System.Drawing.Size(250, 48);
            this.tb_SendToClient.TabIndex = 18;
            this.tb_SendToClient.TabStop = false;
            this.tb_SendToClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_SendToClient.TrailingIcon = null;
            this.tb_SendToClient.UseSystemPasswordChar = false;
            // 
            // btn_StartServer
            // 
            this.btn_StartServer.AutoSize = false;
            this.btn_StartServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_StartServer.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_StartServer.Depth = 0;
            this.btn_StartServer.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_StartServer.HighEmphasis = true;
            this.btn_StartServer.Icon = null;
            this.btn_StartServer.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_StartServer.Location = new System.Drawing.Point(543, 215);
            this.btn_StartServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_StartServer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_StartServer.Name = "btn_StartServer";
            this.btn_StartServer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_StartServer.Size = new System.Drawing.Size(162, 52);
            this.btn_StartServer.TabIndex = 17;
            this.btn_StartServer.Text = "开启服务";
            this.btn_StartServer.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_StartServer.UseAccentColor = false;
            this.btn_StartServer.UseVisualStyleBackColor = true;
            this.btn_StartServer.Click += new System.EventHandler(this.btn_StartServer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "接收数据：";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "客户端.png");
            this.imageList1.Images.SetKeyName(1, "服务器,服务端.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 714);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "HTTP通讯";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.crownStatusStrip1.ResumeLayout(false);
            this.crownStatusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.crownStatusStrip2.ResumeLayout(false);
            this.crownStatusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton btn_ConnectServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_ServerPort;
        private System.Windows.Forms.Label label3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_ServerIP;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SendToServer;
        private ReaLTaiizor.Controls.MaterialButton btn_SendUTF8_toServer;
        private ReaLTaiizor.Controls.MaterialButton btn_SendASCII_toServer;
        private ReaLTaiizor.Controls.CrownStatusStrip crownStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslb_connect;
        private System.Windows.Forms.RichTextBox rtb_Receive;
        private ReaLTaiizor.Controls.MaterialButton btn_CloseServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ReaLTaiizor.Controls.MaterialButton btn_StopServer;
        private System.Windows.Forms.RichTextBox rtb_Receive_Server;
        private ReaLTaiizor.Controls.CrownStatusStrip crownStatusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private ReaLTaiizor.Controls.MaterialButton btn_SendUTF8_ToClient;
        private ReaLTaiizor.Controls.MaterialButton btn_SendASCII_ToClient;
        private System.Windows.Forms.Label label7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_ClientPort;
        private System.Windows.Forms.Label label8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_ClientIP;
        private System.Windows.Forms.Label label9;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_SendToClient;
        private ReaLTaiizor.Controls.MaterialButton btn_StartServer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
    }
}

