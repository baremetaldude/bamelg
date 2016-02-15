namespace BamelgForwarderSetup
{
    partial class EndpointProperties
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this._type = new System.Windows.Forms.TabControl();
			this._tabSerial = new System.Windows.Forms.TabPage();
			this._serialTable = new System.Windows.Forms.TableLayoutPanel();
			this._baudRate = new System.Windows.Forms.TextBox();
			this._lableStopBits = new System.Windows.Forms.Label();
			this._readIntervalTimeout = new System.Windows.Forms.TextBox();
			this._labelReadIntervalTimeout = new System.Windows.Forms.Label();
			this._path = new System.Windows.Forms.TextBox();
			this._labelBaudRate = new System.Windows.Forms.Label();
			this._labelParity = new System.Windows.Forms.Label();
			this._parity = new System.Windows.Forms.ComboBox();
			this._labelPath = new System.Windows.Forms.Label();
			this._stopBits = new System.Windows.Forms.ComboBox();
			this._tabTcpv4Client = new System.Windows.Forms.TabPage();
			this._tabTcpv4Server = new System.Windows.Forms.TabPage();
			this._toolTip = new System.Windows.Forms.ToolTip(this.components);
			this._tcpv4ClientTable = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this._labelEndpoint = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._type.SuspendLayout();
			this._tabSerial.SuspendLayout();
			this._serialTable.SuspendLayout();
			this._tabTcpv4Client.SuspendLayout();
			this._tcpv4ClientTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// _type
			// 
			this._type.Controls.Add(this._tabSerial);
			this._type.Controls.Add(this._tabTcpv4Client);
			this._type.Controls.Add(this._tabTcpv4Server);
			this._type.Dock = System.Windows.Forms.DockStyle.Fill;
			this._type.Location = new System.Drawing.Point(0, 0);
			this._type.Name = "_type";
			this._type.SelectedIndex = 0;
			this._type.Size = new System.Drawing.Size(259, 313);
			this._type.TabIndex = 0;
			// 
			// _tabSerial
			// 
			this._tabSerial.Controls.Add(this._serialTable);
			this._tabSerial.Location = new System.Drawing.Point(4, 22);
			this._tabSerial.Name = "_tabSerial";
			this._tabSerial.Padding = new System.Windows.Forms.Padding(3);
			this._tabSerial.Size = new System.Drawing.Size(251, 287);
			this._tabSerial.TabIndex = 0;
			this._tabSerial.Text = "Serial port";
			this._tabSerial.UseVisualStyleBackColor = true;
			// 
			// _serialTable
			// 
			this._serialTable.ColumnCount = 2;
			this._serialTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._serialTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._serialTable.Controls.Add(this._baudRate, 1, 2);
			this._serialTable.Controls.Add(this._lableStopBits, 0, 4);
			this._serialTable.Controls.Add(this._readIntervalTimeout, 1, 1);
			this._serialTable.Controls.Add(this._labelReadIntervalTimeout, 0, 1);
			this._serialTable.Controls.Add(this._path, 1, 0);
			this._serialTable.Controls.Add(this._labelBaudRate, 0, 2);
			this._serialTable.Controls.Add(this._labelParity, 0, 3);
			this._serialTable.Controls.Add(this._parity, 1, 3);
			this._serialTable.Controls.Add(this._labelPath, 0, 0);
			this._serialTable.Controls.Add(this._stopBits, 1, 4);
			this._serialTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this._serialTable.Location = new System.Drawing.Point(3, 3);
			this._serialTable.Name = "_serialTable";
			this._serialTable.RowCount = 6;
			this._serialTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._serialTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._serialTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._serialTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._serialTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._serialTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._serialTable.Size = new System.Drawing.Size(245, 281);
			this._serialTable.TabIndex = 0;
			// 
			// _baudRate
			// 
			this._baudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._baudRate.Location = new System.Drawing.Point(118, 55);
			this._baudRate.Name = "_baudRate";
			this._baudRate.Size = new System.Drawing.Size(124, 20);
			this._baudRate.TabIndex = 2;
			// 
			// _lableStopBits
			// 
			this._lableStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._lableStopBits.AutoSize = true;
			this._lableStopBits.Location = new System.Drawing.Point(3, 112);
			this._lableStopBits.Name = "_lableStopBits";
			this._lableStopBits.Size = new System.Drawing.Size(109, 13);
			this._lableStopBits.TabIndex = 6;
			this._lableStopBits.Text = "StopBits:";
			this._toolTip.SetToolTip(this._lableStopBits, "Default value comes from Device Manager");
			// 
			// _readIntervalTimeout
			// 
			this._readIntervalTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._readIntervalTimeout.Location = new System.Drawing.Point(118, 29);
			this._readIntervalTimeout.Name = "_readIntervalTimeout";
			this._readIntervalTimeout.Size = new System.Drawing.Size(124, 20);
			this._readIntervalTimeout.TabIndex = 1;
			// 
			// _labelReadIntervalTimeout
			// 
			this._labelReadIntervalTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelReadIntervalTimeout.AutoSize = true;
			this._labelReadIntervalTimeout.Location = new System.Drawing.Point(3, 32);
			this._labelReadIntervalTimeout.Name = "_labelReadIntervalTimeout";
			this._labelReadIntervalTimeout.Size = new System.Drawing.Size(109, 13);
			this._labelReadIntervalTimeout.TabIndex = 2;
			this._labelReadIntervalTimeout.Text = "ReadIntervalTimeout:";
			this._toolTip.SetToolTip(this._labelReadIntervalTimeout, "Path to serial device \\\\.\\COM6");
			// 
			// _path
			// 
			this._path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._path.Location = new System.Drawing.Point(118, 3);
			this._path.Name = "_path";
			this._path.Size = new System.Drawing.Size(124, 20);
			this._path.TabIndex = 0;
			// 
			// _labelBaudRate
			// 
			this._labelBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelBaudRate.AutoSize = true;
			this._labelBaudRate.Location = new System.Drawing.Point(3, 58);
			this._labelBaudRate.Name = "_labelBaudRate";
			this._labelBaudRate.Size = new System.Drawing.Size(109, 13);
			this._labelBaudRate.TabIndex = 3;
			this._labelBaudRate.Text = "BaudRate:";
			this._toolTip.SetToolTip(this._labelBaudRate, "Default value comes from Device Manager");
			// 
			// _labelParity
			// 
			this._labelParity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelParity.AutoSize = true;
			this._labelParity.Location = new System.Drawing.Point(3, 85);
			this._labelParity.Name = "_labelParity";
			this._labelParity.Size = new System.Drawing.Size(109, 13);
			this._labelParity.TabIndex = 5;
			this._labelParity.Text = "Parity:";
			this._toolTip.SetToolTip(this._labelParity, "Default value comes from Device Manager");
			// 
			// _parity
			// 
			this._parity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._parity.FormattingEnabled = true;
			this._parity.Items.AddRange(new object[] {
            "NOPARITY",
            "ODDPARITY",
            "EVENPARITY",
            "MARKPARITY",
            "SPACEPARITY"});
			this._parity.Location = new System.Drawing.Point(118, 81);
			this._parity.Name = "_parity";
			this._parity.Size = new System.Drawing.Size(124, 21);
			this._parity.TabIndex = 3;
			// 
			// _labelPath
			// 
			this._labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelPath.AutoSize = true;
			this._labelPath.Location = new System.Drawing.Point(3, 6);
			this._labelPath.Name = "_labelPath";
			this._labelPath.Size = new System.Drawing.Size(109, 13);
			this._labelPath.TabIndex = 0;
			this._labelPath.Text = "Path:";
			this._toolTip.SetToolTip(this._labelPath, "Path to serial device, e.g. \\\\.\\COM6");
			// 
			// _stopBits
			// 
			this._stopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._stopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._stopBits.FormattingEnabled = true;
			this._stopBits.Items.AddRange(new object[] {
            "ONESTOPBIT",
            "ONE5STOPBITS",
            "TWOSTOPBITS"});
			this._stopBits.Location = new System.Drawing.Point(118, 108);
			this._stopBits.Name = "_stopBits";
			this._stopBits.Size = new System.Drawing.Size(124, 21);
			this._stopBits.TabIndex = 4;
			// 
			// _tabTcpv4Client
			// 
			this._tabTcpv4Client.Controls.Add(this._tcpv4ClientTable);
			this._tabTcpv4Client.Location = new System.Drawing.Point(4, 22);
			this._tabTcpv4Client.Name = "_tabTcpv4Client";
			this._tabTcpv4Client.Padding = new System.Windows.Forms.Padding(3);
			this._tabTcpv4Client.Size = new System.Drawing.Size(251, 287);
			this._tabTcpv4Client.TabIndex = 1;
			this._tabTcpv4Client.Text = "TCPv4 client";
			this._tabTcpv4Client.UseVisualStyleBackColor = true;
			// 
			// _tabTcpv4Server
			// 
			this._tabTcpv4Server.Location = new System.Drawing.Point(4, 22);
			this._tabTcpv4Server.Name = "_tabTcpv4Server";
			this._tabTcpv4Server.Padding = new System.Windows.Forms.Padding(3);
			this._tabTcpv4Server.Size = new System.Drawing.Size(251, 287);
			this._tabTcpv4Server.TabIndex = 2;
			this._tabTcpv4Server.Text = "TCPv4 server";
			this._tabTcpv4Server.UseVisualStyleBackColor = true;
			// 
			// _tcpv4ClientTable
			// 
			this._tcpv4ClientTable.ColumnCount = 2;
			this._tcpv4ClientTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tcpv4ClientTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tcpv4ClientTable.Controls.Add(this.textBox1, 1, 2);
			this._tcpv4ClientTable.Controls.Add(this.textBox2, 1, 1);
			this._tcpv4ClientTable.Controls.Add(this.label2, 0, 1);
			this._tcpv4ClientTable.Controls.Add(this.textBox3, 1, 0);
			this._tcpv4ClientTable.Controls.Add(this.label3, 0, 2);
			this._tcpv4ClientTable.Controls.Add(this._labelEndpoint, 0, 0);
			this._tcpv4ClientTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tcpv4ClientTable.Location = new System.Drawing.Point(3, 3);
			this._tcpv4ClientTable.Name = "_tcpv4ClientTable";
			this._tcpv4ClientTable.RowCount = 6;
			this._tcpv4ClientTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tcpv4ClientTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tcpv4ClientTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tcpv4ClientTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tcpv4ClientTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tcpv4ClientTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tcpv4ClientTable.Size = new System.Drawing.Size(245, 281);
			this._tcpv4ClientTable.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(105, 55);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(137, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(105, 29);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(137, 20);
			this.textBox2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "KeepAliveTimeout:";
			this._toolTip.SetToolTip(this.label2, "Specifies the timeout with no activity until the first keep-alive packet is sent." +
        " Default is 2:00:00");
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox3.Location = new System.Drawing.Point(105, 3);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(137, 20);
			this.textBox3.TabIndex = 0;
			// 
			// _labelEndpoint
			// 
			this._labelEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelEndpoint.AutoSize = true;
			this._labelEndpoint.Location = new System.Drawing.Point(3, 6);
			this._labelEndpoint.Name = "_labelEndpoint";
			this._labelEndpoint.Size = new System.Drawing.Size(96, 13);
			this._labelEndpoint.TabIndex = 0;
			this._labelEndpoint.Text = "Endpoint:";
			this._toolTip.SetToolTip(this._labelEndpoint, "Endpoint to connect , e.g. 127.0.0.1:4010");
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "KeepAliveInterval:";
			this._toolTip.SetToolTip(this.label3, "Specifies the interval between when successive keep-alive packets are sent if no " +
        "acknowledgement is received. After 10 failed probes connection will be dropped");
			// 
			// EndpointProperties
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._type);
			this.Name = "EndpointProperties";
			this.Size = new System.Drawing.Size(259, 313);
			this._type.ResumeLayout(false);
			this._tabSerial.ResumeLayout(false);
			this._serialTable.ResumeLayout(false);
			this._serialTable.PerformLayout();
			this._tabTcpv4Client.ResumeLayout(false);
			this._tcpv4ClientTable.ResumeLayout(false);
			this._tcpv4ClientTable.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _type;
        private System.Windows.Forms.TabPage _tabSerial;
        private System.Windows.Forms.TabPage _tabTcpv4Client;
        private System.Windows.Forms.TabPage _tabTcpv4Server;
        private System.Windows.Forms.TableLayoutPanel _serialTable;
        private System.Windows.Forms.Label _labelPath;
        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.TextBox _path;
        private System.Windows.Forms.ComboBox _stopBits;
        private System.Windows.Forms.TextBox _baudRate;
        private System.Windows.Forms.Label _lableStopBits;
        private System.Windows.Forms.TextBox _readIntervalTimeout;
        private System.Windows.Forms.Label _labelReadIntervalTimeout;
        private System.Windows.Forms.Label _labelBaudRate;
        private System.Windows.Forms.Label _labelParity;
        private System.Windows.Forms.ComboBox _parity;
		private System.Windows.Forms.TableLayoutPanel _tcpv4ClientTable;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label _labelEndpoint;
	}
}
