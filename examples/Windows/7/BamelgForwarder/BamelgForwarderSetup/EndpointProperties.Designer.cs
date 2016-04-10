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
			System.Windows.Forms.TableLayoutPanel _tableSerial;
			System.Windows.Forms.TableLayoutPanel _settingsTable;
			System.Windows.Forms.TableLayoutPanel _tableStatistics;
			this._baudRate = new System.Windows.Forms.TextBox();
			this._lableStopBits = new System.Windows.Forms.Label();
			this._readIntervalTimeout = new System.Windows.Forms.TextBox();
			this._labelReadIntervalTimeout = new System.Windows.Forms.Label();
			this._labelBaudRate = new System.Windows.Forms.Label();
			this._labelParity = new System.Windows.Forms.Label();
			this._parity = new System.Windows.Forms.ComboBox();
			this._labelPath = new System.Windows.Forms.Label();
			this._stopBits = new System.Windows.Forms.ComboBox();
			this._path = new System.Windows.Forms.ComboBox();
			this._writable = new System.Windows.Forms.CheckBox();
			this._writableLabel = new System.Windows.Forms.Label();
			this._readable = new System.Windows.Forms.CheckBox();
			this._readableLabel = new System.Windows.Forms.Label();
			this._hold = new System.Windows.Forms.CheckBox();
			this._holdLabel = new System.Windows.Forms.Label();
			this._nameLabel = new System.Windows.Forms.Label();
			this._typeLabel = new System.Windows.Forms.Label();
			this._name = new System.Windows.Forms.TextBox();
			this._endpointType = new System.Windows.Forms.ComboBox();
			this._labelReconnectCount = new System.Windows.Forms.Label();
			this._reconnectCount = new System.Windows.Forms.TextBox();
			this._readenBytes = new System.Windows.Forms.TextBox();
			this._readenPackets = new System.Windows.Forms.TextBox();
			this._labelPacketsReaden = new System.Windows.Forms.Label();
			this._labelReaden = new System.Windows.Forms.Label();
			this._labelTcpKeepAliveTimeout = new System.Windows.Forms.Label();
			this._labelTcpKeepAliveInterval = new System.Windows.Forms.Label();
			this._labelTcpv4Endpoint = new System.Windows.Forms.Label();
			this._labelTcpv4ServerEndpoint = new System.Windows.Forms.Label();
			this._type = new System.Windows.Forms.TabControl();
			this._tabSettings = new System.Windows.Forms.TabPage();
			this._tabStatistics = new System.Windows.Forms.TabPage();
			this._tabTcp = new System.Windows.Forms.TabPage();
			this._tableTcp = new System.Windows.Forms.TableLayoutPanel();
			this._tcpKeepAliveInterval = new System.Windows.Forms.TextBox();
			this._tcpKeepAliveTimeout = new System.Windows.Forms.TextBox();
			this._tabSerial = new System.Windows.Forms.TabPage();
			this._tabTcpv4Client = new System.Windows.Forms.TabPage();
			this._tableTcpv4Client = new System.Windows.Forms.TableLayoutPanel();
			this._labelTcpv4BindAddress = new System.Windows.Forms.Label();
			this._tcpv4Endpoint = new System.Windows.Forms.TextBox();
			this._tcpv4BindAddress = new System.Windows.Forms.ComboBox();
			this._tabTcpv4Server = new System.Windows.Forms.TabPage();
			this._tableTcpv4Server = new System.Windows.Forms.TableLayoutPanel();
			this._tcpv4ServerEndpoint = new System.Windows.Forms.TextBox();
			this._tabTcpv6Client = new System.Windows.Forms.TabPage();
			this._tableTcpv6Client = new System.Windows.Forms.TableLayoutPanel();
			this._labelTcpv6BindAddress = new System.Windows.Forms.Label();
			this._tcpv6Endpoint = new System.Windows.Forms.TextBox();
			this._labelTcpv6Endpoint = new System.Windows.Forms.Label();
			this._tcpv6BindAddress = new System.Windows.Forms.ComboBox();
			this._tabTcpv6Server = new System.Windows.Forms.TabPage();
			this._tableTcpv6Server = new System.Windows.Forms.TableLayoutPanel();
			this._tcpv6ServerEndpoint = new System.Windows.Forms.TextBox();
			this._labelTcpv6ServerEndpoint = new System.Windows.Forms.Label();
			this._tabNamedPipeClient = new System.Windows.Forms.TabPage();
			this._tableNamedPipeClient = new System.Windows.Forms.TableLayoutPanel();
			this._namedPipeClientPath = new System.Windows.Forms.TextBox();
			this._labelNamedPipeClientPath = new System.Windows.Forms.Label();
			this._tabNamedPipeServer = new System.Windows.Forms.TabPage();
			this._tableNamedPipeServer = new System.Windows.Forms.TableLayoutPanel();
			this._namedPiperServerPath = new System.Windows.Forms.TextBox();
			this._labelNamedPiperServerPath = new System.Windows.Forms.Label();
			this._tabUdpv4 = new System.Windows.Forms.TabPage();
			this._tableUdpv4 = new System.Windows.Forms.TableLayoutPanel();
			this._labelUdpv4SendTo = new System.Windows.Forms.Label();
			this._udpv4ReadEndpoint = new System.Windows.Forms.TextBox();
			this._labelUdpv4ReadFrom = new System.Windows.Forms.Label();
			this._udpv4WriteEndpoint = new System.Windows.Forms.TextBox();
			this._labelUdpv4BindEndpoint = new System.Windows.Forms.Label();
			this._udpv4BindEndpoint = new System.Windows.Forms.TextBox();
			this._labelUdpv4MulticastInterface = new System.Windows.Forms.Label();
			this._udpv4MulticastInterface = new System.Windows.Forms.ComboBox();
			_tableSerial = new System.Windows.Forms.TableLayoutPanel();
			_settingsTable = new System.Windows.Forms.TableLayoutPanel();
			_tableStatistics = new System.Windows.Forms.TableLayoutPanel();
			_tableSerial.SuspendLayout();
			_settingsTable.SuspendLayout();
			_tableStatistics.SuspendLayout();
			this._type.SuspendLayout();
			this._tabSettings.SuspendLayout();
			this._tabStatistics.SuspendLayout();
			this._tabTcp.SuspendLayout();
			this._tableTcp.SuspendLayout();
			this._tabSerial.SuspendLayout();
			this._tabTcpv4Client.SuspendLayout();
			this._tableTcpv4Client.SuspendLayout();
			this._tabTcpv4Server.SuspendLayout();
			this._tableTcpv4Server.SuspendLayout();
			this._tabTcpv6Client.SuspendLayout();
			this._tableTcpv6Client.SuspendLayout();
			this._tabTcpv6Server.SuspendLayout();
			this._tableTcpv6Server.SuspendLayout();
			this._tabNamedPipeClient.SuspendLayout();
			this._tableNamedPipeClient.SuspendLayout();
			this._tabNamedPipeServer.SuspendLayout();
			this._tableNamedPipeServer.SuspendLayout();
			this._tabUdpv4.SuspendLayout();
			this._tableUdpv4.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tableSerial
			// 
			_tableSerial.ColumnCount = 2;
			_tableSerial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			_tableSerial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			_tableSerial.Controls.Add(this._baudRate, 1, 2);
			_tableSerial.Controls.Add(this._lableStopBits, 0, 4);
			_tableSerial.Controls.Add(this._readIntervalTimeout, 1, 1);
			_tableSerial.Controls.Add(this._labelReadIntervalTimeout, 0, 1);
			_tableSerial.Controls.Add(this._labelBaudRate, 0, 2);
			_tableSerial.Controls.Add(this._labelParity, 0, 3);
			_tableSerial.Controls.Add(this._parity, 1, 3);
			_tableSerial.Controls.Add(this._labelPath, 0, 0);
			_tableSerial.Controls.Add(this._stopBits, 1, 4);
			_tableSerial.Controls.Add(this._path, 1, 0);
			_tableSerial.Dock = System.Windows.Forms.DockStyle.Fill;
			_tableSerial.Location = new System.Drawing.Point(3, 3);
			_tableSerial.Name = "_tableSerial";
			_tableSerial.RowCount = 6;
			_tableSerial.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableSerial.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableSerial.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableSerial.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableSerial.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableSerial.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableSerial.Size = new System.Drawing.Size(245, 281);
			_tableSerial.TabIndex = 0;
			// 
			// _baudRate
			// 
			this._baudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._baudRate.Location = new System.Drawing.Point(118, 56);
			this._baudRate.Name = "_baudRate";
			this._baudRate.Size = new System.Drawing.Size(124, 20);
			this._baudRate.TabIndex = 2;
			// 
			// _lableStopBits
			// 
			this._lableStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._lableStopBits.AutoSize = true;
			this._lableStopBits.Location = new System.Drawing.Point(3, 113);
			this._lableStopBits.Name = "_lableStopBits";
			this._lableStopBits.Size = new System.Drawing.Size(109, 13);
			this._lableStopBits.TabIndex = 6;
			this._lableStopBits.Text = "StopBits:";
			// 
			// _readIntervalTimeout
			// 
			this._readIntervalTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._readIntervalTimeout.Location = new System.Drawing.Point(118, 30);
			this._readIntervalTimeout.Name = "_readIntervalTimeout";
			this._readIntervalTimeout.Size = new System.Drawing.Size(124, 20);
			this._readIntervalTimeout.TabIndex = 1;
			// 
			// _labelReadIntervalTimeout
			// 
			this._labelReadIntervalTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelReadIntervalTimeout.AutoSize = true;
			this._labelReadIntervalTimeout.Location = new System.Drawing.Point(3, 33);
			this._labelReadIntervalTimeout.Name = "_labelReadIntervalTimeout";
			this._labelReadIntervalTimeout.Size = new System.Drawing.Size(109, 13);
			this._labelReadIntervalTimeout.TabIndex = 2;
			this._labelReadIntervalTimeout.Text = "ReadIntervalTimeout:";
			// 
			// _labelBaudRate
			// 
			this._labelBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelBaudRate.AutoSize = true;
			this._labelBaudRate.Location = new System.Drawing.Point(3, 59);
			this._labelBaudRate.Name = "_labelBaudRate";
			this._labelBaudRate.Size = new System.Drawing.Size(109, 13);
			this._labelBaudRate.TabIndex = 3;
			this._labelBaudRate.Text = "BaudRate:";
			// 
			// _labelParity
			// 
			this._labelParity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelParity.AutoSize = true;
			this._labelParity.Location = new System.Drawing.Point(3, 86);
			this._labelParity.Name = "_labelParity";
			this._labelParity.Size = new System.Drawing.Size(109, 13);
			this._labelParity.TabIndex = 5;
			this._labelParity.Text = "Parity:";
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
			this._parity.Location = new System.Drawing.Point(118, 82);
			this._parity.Name = "_parity";
			this._parity.Size = new System.Drawing.Size(124, 21);
			this._parity.TabIndex = 3;
			// 
			// _labelPath
			// 
			this._labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelPath.AutoSize = true;
			this._labelPath.Location = new System.Drawing.Point(3, 7);
			this._labelPath.Name = "_labelPath";
			this._labelPath.Size = new System.Drawing.Size(109, 13);
			this._labelPath.TabIndex = 0;
			this._labelPath.Text = "Path:";
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
			this._stopBits.Location = new System.Drawing.Point(118, 109);
			this._stopBits.Name = "_stopBits";
			this._stopBits.Size = new System.Drawing.Size(124, 21);
			this._stopBits.TabIndex = 4;
			// 
			// _path
			// 
			this._path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._path.FormattingEnabled = true;
			this._path.Items.AddRange(new object[] {
            "NOPARITY",
            "ODDPARITY",
            "EVENPARITY",
            "MARKPARITY",
            "SPACEPARITY"});
			this._path.Location = new System.Drawing.Point(118, 3);
			this._path.Name = "_path";
			this._path.Size = new System.Drawing.Size(124, 21);
			this._path.TabIndex = 7;
			this._path.DropDown += new System.EventHandler(this._path_DropDown);
			// 
			// _settingsTable
			// 
			_settingsTable.ColumnCount = 2;
			_settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			_settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			_settingsTable.Controls.Add(this._writable, 1, 3);
			_settingsTable.Controls.Add(this._writableLabel, 0, 3);
			_settingsTable.Controls.Add(this._readable, 1, 2);
			_settingsTable.Controls.Add(this._readableLabel, 0, 2);
			_settingsTable.Controls.Add(this._hold, 1, 6);
			_settingsTable.Controls.Add(this._holdLabel, 0, 6);
			_settingsTable.Controls.Add(this._nameLabel, 0, 1);
			_settingsTable.Controls.Add(this._typeLabel, 0, 0);
			_settingsTable.Controls.Add(this._name, 1, 1);
			_settingsTable.Controls.Add(this._endpointType, 1, 0);
			_settingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
			_settingsTable.Location = new System.Drawing.Point(3, 3);
			_settingsTable.Name = "_settingsTable";
			_settingsTable.RowCount = 8;
			_settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_settingsTable.Size = new System.Drawing.Size(245, 281);
			_settingsTable.TabIndex = 2;
			// 
			// _writable
			// 
			this._writable.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._writable.AutoSize = true;
			this._writable.Location = new System.Drawing.Point(146, 76);
			this._writable.Name = "_writable";
			this._writable.Size = new System.Drawing.Size(15, 14);
			this._writable.TabIndex = 7;
			this._writable.UseVisualStyleBackColor = true;
			// 
			// _writableLabel
			// 
			this._writableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._writableLabel.AutoSize = true;
			this._writableLabel.Location = new System.Drawing.Point(3, 76);
			this._writableLabel.Name = "_writableLabel";
			this._writableLabel.Size = new System.Drawing.Size(56, 13);
			this._writableLabel.TabIndex = 6;
			this._writableLabel.Text = "Writable:";
			// 
			// _readable
			// 
			this._readable.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._readable.AutoSize = true;
			this._readable.Location = new System.Drawing.Point(146, 56);
			this._readable.Name = "_readable";
			this._readable.Size = new System.Drawing.Size(15, 14);
			this._readable.TabIndex = 5;
			this._readable.UseVisualStyleBackColor = true;
			// 
			// _readableLabel
			// 
			this._readableLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._readableLabel.AutoSize = true;
			this._readableLabel.Location = new System.Drawing.Point(3, 56);
			this._readableLabel.Name = "_readableLabel";
			this._readableLabel.Size = new System.Drawing.Size(56, 13);
			this._readableLabel.TabIndex = 3;
			this._readableLabel.Text = "Readable:";
			// 
			// _hold
			// 
			this._hold.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._hold.AutoSize = true;
			this._hold.Location = new System.Drawing.Point(146, 96);
			this._hold.Name = "_hold";
			this._hold.Size = new System.Drawing.Size(15, 14);
			this._hold.TabIndex = 4;
			this._hold.UseVisualStyleBackColor = true;
			// 
			// _holdLabel
			// 
			this._holdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._holdLabel.AutoSize = true;
			this._holdLabel.Location = new System.Drawing.Point(3, 96);
			this._holdLabel.Name = "_holdLabel";
			this._holdLabel.Size = new System.Drawing.Size(56, 13);
			this._holdLabel.TabIndex = 2;
			this._holdLabel.Text = "Hold:";
			// 
			// _nameLabel
			// 
			this._nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._nameLabel.AutoSize = true;
			this._nameLabel.Location = new System.Drawing.Point(3, 33);
			this._nameLabel.Name = "_nameLabel";
			this._nameLabel.Size = new System.Drawing.Size(56, 13);
			this._nameLabel.TabIndex = 0;
			this._nameLabel.Text = "Name:";
			// 
			// _typeLabel
			// 
			this._typeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._typeLabel.AutoSize = true;
			this._typeLabel.Location = new System.Drawing.Point(3, 7);
			this._typeLabel.Name = "_typeLabel";
			this._typeLabel.Size = new System.Drawing.Size(34, 13);
			this._typeLabel.TabIndex = 8;
			this._typeLabel.Text = "Type:";
			// 
			// _name
			// 
			this._name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._name.Location = new System.Drawing.Point(65, 30);
			this._name.Name = "_name";
			this._name.Size = new System.Drawing.Size(177, 20);
			this._name.TabIndex = 0;
			// 
			// _endpointType
			// 
			this._endpointType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._endpointType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._endpointType.FormattingEnabled = true;
			this._endpointType.Location = new System.Drawing.Point(65, 3);
			this._endpointType.Name = "_endpointType";
			this._endpointType.Size = new System.Drawing.Size(177, 21);
			this._endpointType.TabIndex = 9;
			// 
			// _tableStatistics
			// 
			_tableStatistics.ColumnCount = 2;
			_tableStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			_tableStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			_tableStatistics.Controls.Add(this._labelReconnectCount, 0, 0);
			_tableStatistics.Controls.Add(this._reconnectCount, 1, 0);
			_tableStatistics.Controls.Add(this._readenBytes, 1, 1);
			_tableStatistics.Controls.Add(this._readenPackets, 1, 7);
			_tableStatistics.Controls.Add(this._labelPacketsReaden, 0, 7);
			_tableStatistics.Controls.Add(this._labelReaden, 0, 1);
			_tableStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
			_tableStatistics.Location = new System.Drawing.Point(3, 3);
			_tableStatistics.Name = "_tableStatistics";
			_tableStatistics.RowCount = 9;
			_tableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			_tableStatistics.Size = new System.Drawing.Size(245, 281);
			_tableStatistics.TabIndex = 3;
			// 
			// _labelReconnectCount
			// 
			this._labelReconnectCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelReconnectCount.AutoSize = true;
			this._labelReconnectCount.Location = new System.Drawing.Point(3, 6);
			this._labelReconnectCount.Name = "_labelReconnectCount";
			this._labelReconnectCount.Size = new System.Drawing.Size(85, 13);
			this._labelReconnectCount.TabIndex = 0;
			this._labelReconnectCount.Text = "Reconnects:";
			// 
			// _reconnectCount
			// 
			this._reconnectCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._reconnectCount.Enabled = false;
			this._reconnectCount.Location = new System.Drawing.Point(94, 3);
			this._reconnectCount.Name = "_reconnectCount";
			this._reconnectCount.Size = new System.Drawing.Size(148, 20);
			this._reconnectCount.TabIndex = 0;
			// 
			// _readenBytes
			// 
			this._readenBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._readenBytes.Enabled = false;
			this._readenBytes.Location = new System.Drawing.Point(94, 29);
			this._readenBytes.Name = "_readenBytes";
			this._readenBytes.Size = new System.Drawing.Size(148, 20);
			this._readenBytes.TabIndex = 9;
			// 
			// _readenPackets
			// 
			this._readenPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._readenPackets.Enabled = false;
			this._readenPackets.Location = new System.Drawing.Point(94, 55);
			this._readenPackets.Name = "_readenPackets";
			this._readenPackets.Size = new System.Drawing.Size(148, 20);
			this._readenPackets.TabIndex = 11;
			// 
			// _labelPacketsReaden
			// 
			this._labelPacketsReaden.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._labelPacketsReaden.AutoSize = true;
			this._labelPacketsReaden.Location = new System.Drawing.Point(3, 58);
			this._labelPacketsReaden.Name = "_labelPacketsReaden";
			this._labelPacketsReaden.Size = new System.Drawing.Size(85, 13);
			this._labelPacketsReaden.TabIndex = 10;
			this._labelPacketsReaden.Text = "Packets readen:";
			// 
			// _labelReaden
			// 
			this._labelReaden.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._labelReaden.AutoSize = true;
			this._labelReaden.Location = new System.Drawing.Point(3, 32);
			this._labelReaden.Name = "_labelReaden";
			this._labelReaden.Size = new System.Drawing.Size(72, 13);
			this._labelReaden.TabIndex = 8;
			this._labelReaden.Text = "Bytes readen:";
			// 
			// _labelTcpKeepAliveTimeout
			// 
			this._labelTcpKeepAliveTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelTcpKeepAliveTimeout.AutoSize = true;
			this._labelTcpKeepAliveTimeout.Location = new System.Drawing.Point(3, 6);
			this._labelTcpKeepAliveTimeout.Name = "_labelTcpKeepAliveTimeout";
			this._labelTcpKeepAliveTimeout.Size = new System.Drawing.Size(98, 13);
			this._labelTcpKeepAliveTimeout.TabIndex = 2;
			this._labelTcpKeepAliveTimeout.Text = "Keep-Alive timeout:";
			// 
			// _labelTcpKeepAliveInterval
			// 
			this._labelTcpKeepAliveInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelTcpKeepAliveInterval.AutoSize = true;
			this._labelTcpKeepAliveInterval.Location = new System.Drawing.Point(3, 32);
			this._labelTcpKeepAliveInterval.Name = "_labelTcpKeepAliveInterval";
			this._labelTcpKeepAliveInterval.Size = new System.Drawing.Size(98, 13);
			this._labelTcpKeepAliveInterval.TabIndex = 3;
			this._labelTcpKeepAliveInterval.Text = "Keep-Alive interval:";
			// 
			// _labelTcpv4Endpoint
			// 
			this._labelTcpv4Endpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelTcpv4Endpoint.AutoSize = true;
			this._labelTcpv4Endpoint.Location = new System.Drawing.Point(3, 6);
			this._labelTcpv4Endpoint.Name = "_labelTcpv4Endpoint";
			this._labelTcpv4Endpoint.Size = new System.Drawing.Size(71, 13);
			this._labelTcpv4Endpoint.TabIndex = 0;
			this._labelTcpv4Endpoint.Text = "Endpoint:";
			// 
			// _labelTcpv4ServerEndpoint
			// 
			this._labelTcpv4ServerEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelTcpv4ServerEndpoint.AutoSize = true;
			this._labelTcpv4ServerEndpoint.Location = new System.Drawing.Point(3, 6);
			this._labelTcpv4ServerEndpoint.Name = "_labelTcpv4ServerEndpoint";
			this._labelTcpv4ServerEndpoint.Size = new System.Drawing.Size(52, 13);
			this._labelTcpv4ServerEndpoint.TabIndex = 0;
			this._labelTcpv4ServerEndpoint.Text = "Endpoint:";
			// 
			// _type
			// 
			this._type.Controls.Add(this._tabSettings);
			this._type.Controls.Add(this._tabStatistics);
			this._type.Controls.Add(this._tabTcp);
			this._type.Controls.Add(this._tabSerial);
			this._type.Controls.Add(this._tabTcpv4Client);
			this._type.Controls.Add(this._tabTcpv4Server);
			this._type.Controls.Add(this._tabTcpv6Client);
			this._type.Controls.Add(this._tabTcpv6Server);
			this._type.Controls.Add(this._tabNamedPipeClient);
			this._type.Controls.Add(this._tabNamedPipeServer);
			this._type.Controls.Add(this._tabUdpv4);
			this._type.Dock = System.Windows.Forms.DockStyle.Fill;
			this._type.Location = new System.Drawing.Point(0, 0);
			this._type.Name = "_type";
			this._type.SelectedIndex = 0;
			this._type.Size = new System.Drawing.Size(259, 313);
			this._type.TabIndex = 0;
			// 
			// _tabSettings
			// 
			this._tabSettings.Controls.Add(_settingsTable);
			this._tabSettings.Location = new System.Drawing.Point(4, 22);
			this._tabSettings.Name = "_tabSettings";
			this._tabSettings.Padding = new System.Windows.Forms.Padding(3);
			this._tabSettings.Size = new System.Drawing.Size(251, 287);
			this._tabSettings.TabIndex = 3;
			this._tabSettings.Text = "Settings";
			this._tabSettings.UseVisualStyleBackColor = true;
			// 
			// _tabStatistics
			// 
			this._tabStatistics.Controls.Add(_tableStatistics);
			this._tabStatistics.Location = new System.Drawing.Point(4, 22);
			this._tabStatistics.Name = "_tabStatistics";
			this._tabStatistics.Padding = new System.Windows.Forms.Padding(3);
			this._tabStatistics.Size = new System.Drawing.Size(251, 287);
			this._tabStatistics.TabIndex = 4;
			this._tabStatistics.Text = "Statistics";
			this._tabStatistics.UseVisualStyleBackColor = true;
			// 
			// _tabTcp
			// 
			this._tabTcp.Controls.Add(this._tableTcp);
			this._tabTcp.Location = new System.Drawing.Point(4, 22);
			this._tabTcp.Name = "_tabTcp";
			this._tabTcp.Size = new System.Drawing.Size(251, 287);
			this._tabTcp.TabIndex = 5;
			this._tabTcp.Text = "TCP";
			this._tabTcp.UseVisualStyleBackColor = true;
			// 
			// _tableTcp
			// 
			this._tableTcp.ColumnCount = 2;
			this._tableTcp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableTcp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableTcp.Controls.Add(this._tcpKeepAliveInterval, 1, 1);
			this._tableTcp.Controls.Add(this._tcpKeepAliveTimeout, 1, 0);
			this._tableTcp.Controls.Add(this._labelTcpKeepAliveTimeout, 0, 0);
			this._tableTcp.Controls.Add(this._labelTcpKeepAliveInterval, 0, 1);
			this._tableTcp.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableTcp.Location = new System.Drawing.Point(0, 0);
			this._tableTcp.Name = "_tableTcp";
			this._tableTcp.RowCount = 5;
			this._tableTcp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcp.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tableTcp.Size = new System.Drawing.Size(251, 287);
			this._tableTcp.TabIndex = 2;
			// 
			// _tcpKeepAliveInterval
			// 
			this._tcpKeepAliveInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._tcpKeepAliveInterval.Location = new System.Drawing.Point(107, 29);
			this._tcpKeepAliveInterval.Name = "_tcpKeepAliveInterval";
			this._tcpKeepAliveInterval.Size = new System.Drawing.Size(141, 20);
			this._tcpKeepAliveInterval.TabIndex = 2;
			// 
			// _tcpKeepAliveTimeout
			// 
			this._tcpKeepAliveTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._tcpKeepAliveTimeout.Location = new System.Drawing.Point(107, 3);
			this._tcpKeepAliveTimeout.Name = "_tcpKeepAliveTimeout";
			this._tcpKeepAliveTimeout.Size = new System.Drawing.Size(141, 20);
			this._tcpKeepAliveTimeout.TabIndex = 1;
			// 
			// _tabSerial
			// 
			this._tabSerial.Controls.Add(_tableSerial);
			this._tabSerial.Location = new System.Drawing.Point(4, 22);
			this._tabSerial.Name = "_tabSerial";
			this._tabSerial.Padding = new System.Windows.Forms.Padding(3);
			this._tabSerial.Size = new System.Drawing.Size(251, 287);
			this._tabSerial.TabIndex = 0;
			this._tabSerial.Text = "Serial port";
			this._tabSerial.UseVisualStyleBackColor = true;
			// 
			// _tabTcpv4Client
			// 
			this._tabTcpv4Client.Controls.Add(this._tableTcpv4Client);
			this._tabTcpv4Client.Location = new System.Drawing.Point(4, 22);
			this._tabTcpv4Client.Name = "_tabTcpv4Client";
			this._tabTcpv4Client.Padding = new System.Windows.Forms.Padding(3);
			this._tabTcpv4Client.Size = new System.Drawing.Size(251, 287);
			this._tabTcpv4Client.TabIndex = 1;
			this._tabTcpv4Client.Text = "TCPv4 client";
			this._tabTcpv4Client.UseVisualStyleBackColor = true;
			// 
			// _tableTcpv4Client
			// 
			this._tableTcpv4Client.ColumnCount = 2;
			this._tableTcpv4Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableTcpv4Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableTcpv4Client.Controls.Add(this._labelTcpv4BindAddress, 0, 5);
			this._tableTcpv4Client.Controls.Add(this._tcpv4Endpoint, 1, 0);
			this._tableTcpv4Client.Controls.Add(this._labelTcpv4Endpoint, 0, 0);
			this._tableTcpv4Client.Controls.Add(this._tcpv4BindAddress, 1, 5);
			this._tableTcpv4Client.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableTcpv4Client.Location = new System.Drawing.Point(3, 3);
			this._tableTcpv4Client.Name = "_tableTcpv4Client";
			this._tableTcpv4Client.RowCount = 7;
			this._tableTcpv4Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tableTcpv4Client.Size = new System.Drawing.Size(245, 281);
			this._tableTcpv4Client.TabIndex = 1;
			// 
			// _labelTcpv4BindAddress
			// 
			this._labelTcpv4BindAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelTcpv4BindAddress.AutoSize = true;
			this._labelTcpv4BindAddress.Location = new System.Drawing.Point(3, 33);
			this._labelTcpv4BindAddress.Name = "_labelTcpv4BindAddress";
			this._labelTcpv4BindAddress.Size = new System.Drawing.Size(71, 13);
			this._labelTcpv4BindAddress.TabIndex = 1;
			this._labelTcpv4BindAddress.Text = "Bind address:";
			// 
			// _tcpv4Endpoint
			// 
			this._tcpv4Endpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._tcpv4Endpoint.Location = new System.Drawing.Point(80, 3);
			this._tcpv4Endpoint.Name = "_tcpv4Endpoint";
			this._tcpv4Endpoint.Size = new System.Drawing.Size(162, 20);
			this._tcpv4Endpoint.TabIndex = 0;
			// 
			// _tcpv4BindAddress
			// 
			this._tcpv4BindAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._tcpv4BindAddress.FormattingEnabled = true;
			this._tcpv4BindAddress.Location = new System.Drawing.Point(80, 29);
			this._tcpv4BindAddress.Name = "_tcpv4BindAddress";
			this._tcpv4BindAddress.Size = new System.Drawing.Size(162, 21);
			this._tcpv4BindAddress.TabIndex = 2;
			this._tcpv4BindAddress.DropDown += new System.EventHandler(this._tcpv4BindAddress_DropDown);
			// 
			// _tabTcpv4Server
			// 
			this._tabTcpv4Server.Controls.Add(this._tableTcpv4Server);
			this._tabTcpv4Server.Location = new System.Drawing.Point(4, 22);
			this._tabTcpv4Server.Name = "_tabTcpv4Server";
			this._tabTcpv4Server.Padding = new System.Windows.Forms.Padding(3);
			this._tabTcpv4Server.Size = new System.Drawing.Size(251, 287);
			this._tabTcpv4Server.TabIndex = 2;
			this._tabTcpv4Server.Text = "TCPv4 server";
			this._tabTcpv4Server.UseVisualStyleBackColor = true;
			// 
			// _tableTcpv4Server
			// 
			this._tableTcpv4Server.ColumnCount = 2;
			this._tableTcpv4Server.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableTcpv4Server.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableTcpv4Server.Controls.Add(this._tcpv4ServerEndpoint, 1, 0);
			this._tableTcpv4Server.Controls.Add(this._labelTcpv4ServerEndpoint, 0, 0);
			this._tableTcpv4Server.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableTcpv4Server.Location = new System.Drawing.Point(3, 3);
			this._tableTcpv4Server.Name = "_tableTcpv4Server";
			this._tableTcpv4Server.RowCount = 6;
			this._tableTcpv4Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv4Server.Size = new System.Drawing.Size(245, 281);
			this._tableTcpv4Server.TabIndex = 2;
			// 
			// _tcpv4ServerEndpoint
			// 
			this._tcpv4ServerEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._tcpv4ServerEndpoint.Location = new System.Drawing.Point(61, 3);
			this._tcpv4ServerEndpoint.Name = "_tcpv4ServerEndpoint";
			this._tcpv4ServerEndpoint.Size = new System.Drawing.Size(181, 20);
			this._tcpv4ServerEndpoint.TabIndex = 0;
			// 
			// _tabTcpv6Client
			// 
			this._tabTcpv6Client.Controls.Add(this._tableTcpv6Client);
			this._tabTcpv6Client.Location = new System.Drawing.Point(4, 22);
			this._tabTcpv6Client.Name = "_tabTcpv6Client";
			this._tabTcpv6Client.Padding = new System.Windows.Forms.Padding(3);
			this._tabTcpv6Client.Size = new System.Drawing.Size(251, 287);
			this._tabTcpv6Client.TabIndex = 6;
			this._tabTcpv6Client.Text = "TCPv6 client";
			this._tabTcpv6Client.UseVisualStyleBackColor = true;
			// 
			// _tableTcpv6Client
			// 
			this._tableTcpv6Client.ColumnCount = 2;
			this._tableTcpv6Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableTcpv6Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableTcpv6Client.Controls.Add(this._labelTcpv6BindAddress, 0, 5);
			this._tableTcpv6Client.Controls.Add(this._tcpv6Endpoint, 1, 0);
			this._tableTcpv6Client.Controls.Add(this._labelTcpv6Endpoint, 0, 0);
			this._tableTcpv6Client.Controls.Add(this._tcpv6BindAddress, 1, 5);
			this._tableTcpv6Client.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableTcpv6Client.Location = new System.Drawing.Point(3, 3);
			this._tableTcpv6Client.Name = "_tableTcpv6Client";
			this._tableTcpv6Client.RowCount = 7;
			this._tableTcpv6Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Client.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tableTcpv6Client.Size = new System.Drawing.Size(245, 281);
			this._tableTcpv6Client.TabIndex = 3;
			// 
			// _labelTcpv6BindAddress
			// 
			this._labelTcpv6BindAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelTcpv6BindAddress.AutoSize = true;
			this._labelTcpv6BindAddress.Location = new System.Drawing.Point(3, 33);
			this._labelTcpv6BindAddress.Name = "_labelTcpv6BindAddress";
			this._labelTcpv6BindAddress.Size = new System.Drawing.Size(71, 13);
			this._labelTcpv6BindAddress.TabIndex = 1;
			this._labelTcpv6BindAddress.Text = "Bind address:";
			// 
			// _tcpv6Endpoint
			// 
			this._tcpv6Endpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._tcpv6Endpoint.Location = new System.Drawing.Point(80, 3);
			this._tcpv6Endpoint.Name = "_tcpv6Endpoint";
			this._tcpv6Endpoint.Size = new System.Drawing.Size(162, 20);
			this._tcpv6Endpoint.TabIndex = 0;
			// 
			// _labelTcpv6Endpoint
			// 
			this._labelTcpv6Endpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelTcpv6Endpoint.AutoSize = true;
			this._labelTcpv6Endpoint.Location = new System.Drawing.Point(3, 6);
			this._labelTcpv6Endpoint.Name = "_labelTcpv6Endpoint";
			this._labelTcpv6Endpoint.Size = new System.Drawing.Size(71, 13);
			this._labelTcpv6Endpoint.TabIndex = 0;
			this._labelTcpv6Endpoint.Text = "Endpoint:";
			// 
			// _tcpv6BindAddress
			// 
			this._tcpv6BindAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._tcpv6BindAddress.FormattingEnabled = true;
			this._tcpv6BindAddress.Location = new System.Drawing.Point(80, 29);
			this._tcpv6BindAddress.Name = "_tcpv6BindAddress";
			this._tcpv6BindAddress.Size = new System.Drawing.Size(162, 21);
			this._tcpv6BindAddress.TabIndex = 2;
			this._tcpv6BindAddress.DropDown += new System.EventHandler(this._tcpv6BindAddress_DropDown);
			// 
			// _tabTcpv6Server
			// 
			this._tabTcpv6Server.Controls.Add(this._tableTcpv6Server);
			this._tabTcpv6Server.Location = new System.Drawing.Point(4, 22);
			this._tabTcpv6Server.Name = "_tabTcpv6Server";
			this._tabTcpv6Server.Padding = new System.Windows.Forms.Padding(3);
			this._tabTcpv6Server.Size = new System.Drawing.Size(251, 287);
			this._tabTcpv6Server.TabIndex = 7;
			this._tabTcpv6Server.Text = "TCPv6 server";
			this._tabTcpv6Server.UseVisualStyleBackColor = true;
			// 
			// _tableTcpv6Server
			// 
			this._tableTcpv6Server.ColumnCount = 2;
			this._tableTcpv6Server.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableTcpv6Server.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableTcpv6Server.Controls.Add(this._tcpv6ServerEndpoint, 1, 0);
			this._tableTcpv6Server.Controls.Add(this._labelTcpv6ServerEndpoint, 0, 0);
			this._tableTcpv6Server.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableTcpv6Server.Location = new System.Drawing.Point(3, 3);
			this._tableTcpv6Server.Name = "_tableTcpv6Server";
			this._tableTcpv6Server.RowCount = 6;
			this._tableTcpv6Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Server.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableTcpv6Server.Size = new System.Drawing.Size(245, 281);
			this._tableTcpv6Server.TabIndex = 3;
			// 
			// _tcpv6ServerEndpoint
			// 
			this._tcpv6ServerEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._tcpv6ServerEndpoint.Location = new System.Drawing.Point(61, 3);
			this._tcpv6ServerEndpoint.Name = "_tcpv6ServerEndpoint";
			this._tcpv6ServerEndpoint.Size = new System.Drawing.Size(181, 20);
			this._tcpv6ServerEndpoint.TabIndex = 0;
			// 
			// _labelTcpv6ServerEndpoint
			// 
			this._labelTcpv6ServerEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelTcpv6ServerEndpoint.AutoSize = true;
			this._labelTcpv6ServerEndpoint.Location = new System.Drawing.Point(3, 6);
			this._labelTcpv6ServerEndpoint.Name = "_labelTcpv6ServerEndpoint";
			this._labelTcpv6ServerEndpoint.Size = new System.Drawing.Size(52, 13);
			this._labelTcpv6ServerEndpoint.TabIndex = 0;
			this._labelTcpv6ServerEndpoint.Text = "Endpoint:";
			// 
			// _tabNamedPipeClient
			// 
			this._tabNamedPipeClient.Controls.Add(this._tableNamedPipeClient);
			this._tabNamedPipeClient.Location = new System.Drawing.Point(4, 22);
			this._tabNamedPipeClient.Name = "_tabNamedPipeClient";
			this._tabNamedPipeClient.Padding = new System.Windows.Forms.Padding(3);
			this._tabNamedPipeClient.Size = new System.Drawing.Size(251, 287);
			this._tabNamedPipeClient.TabIndex = 8;
			this._tabNamedPipeClient.Text = "NamedPipe client";
			this._tabNamedPipeClient.UseVisualStyleBackColor = true;
			// 
			// _tableNamedPipeClient
			// 
			this._tableNamedPipeClient.ColumnCount = 2;
			this._tableNamedPipeClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableNamedPipeClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableNamedPipeClient.Controls.Add(this._namedPipeClientPath, 1, 0);
			this._tableNamedPipeClient.Controls.Add(this._labelNamedPipeClientPath, 0, 0);
			this._tableNamedPipeClient.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableNamedPipeClient.Location = new System.Drawing.Point(3, 3);
			this._tableNamedPipeClient.Name = "_tableNamedPipeClient";
			this._tableNamedPipeClient.RowCount = 6;
			this._tableNamedPipeClient.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeClient.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeClient.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeClient.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeClient.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeClient.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeClient.Size = new System.Drawing.Size(245, 281);
			this._tableNamedPipeClient.TabIndex = 3;
			// 
			// _namedPipeClientPath
			// 
			this._namedPipeClientPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._namedPipeClientPath.Location = new System.Drawing.Point(41, 3);
			this._namedPipeClientPath.Name = "_namedPipeClientPath";
			this._namedPipeClientPath.Size = new System.Drawing.Size(201, 20);
			this._namedPipeClientPath.TabIndex = 0;
			// 
			// _labelNamedPipeClientPath
			// 
			this._labelNamedPipeClientPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelNamedPipeClientPath.AutoSize = true;
			this._labelNamedPipeClientPath.Location = new System.Drawing.Point(3, 6);
			this._labelNamedPipeClientPath.Name = "_labelNamedPipeClientPath";
			this._labelNamedPipeClientPath.Size = new System.Drawing.Size(32, 13);
			this._labelNamedPipeClientPath.TabIndex = 0;
			this._labelNamedPipeClientPath.Text = "Path:";
			// 
			// _tabNamedPipeServer
			// 
			this._tabNamedPipeServer.Controls.Add(this._tableNamedPipeServer);
			this._tabNamedPipeServer.Location = new System.Drawing.Point(4, 22);
			this._tabNamedPipeServer.Name = "_tabNamedPipeServer";
			this._tabNamedPipeServer.Padding = new System.Windows.Forms.Padding(3);
			this._tabNamedPipeServer.Size = new System.Drawing.Size(251, 287);
			this._tabNamedPipeServer.TabIndex = 9;
			this._tabNamedPipeServer.Text = "NamedPipe server";
			this._tabNamedPipeServer.UseVisualStyleBackColor = true;
			// 
			// _tableNamedPipeServer
			// 
			this._tableNamedPipeServer.ColumnCount = 2;
			this._tableNamedPipeServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableNamedPipeServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableNamedPipeServer.Controls.Add(this._namedPiperServerPath, 1, 0);
			this._tableNamedPipeServer.Controls.Add(this._labelNamedPiperServerPath, 0, 0);
			this._tableNamedPipeServer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableNamedPipeServer.Location = new System.Drawing.Point(3, 3);
			this._tableNamedPipeServer.Name = "_tableNamedPipeServer";
			this._tableNamedPipeServer.RowCount = 6;
			this._tableNamedPipeServer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeServer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeServer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeServer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeServer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeServer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableNamedPipeServer.Size = new System.Drawing.Size(245, 281);
			this._tableNamedPipeServer.TabIndex = 3;
			// 
			// _namedPiperServerPath
			// 
			this._namedPiperServerPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._namedPiperServerPath.Location = new System.Drawing.Point(41, 3);
			this._namedPiperServerPath.Name = "_namedPiperServerPath";
			this._namedPiperServerPath.Size = new System.Drawing.Size(201, 20);
			this._namedPiperServerPath.TabIndex = 0;
			// 
			// _labelNamedPiperServerPath
			// 
			this._labelNamedPiperServerPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelNamedPiperServerPath.AutoSize = true;
			this._labelNamedPiperServerPath.Location = new System.Drawing.Point(3, 6);
			this._labelNamedPiperServerPath.Name = "_labelNamedPiperServerPath";
			this._labelNamedPiperServerPath.Size = new System.Drawing.Size(32, 13);
			this._labelNamedPiperServerPath.TabIndex = 0;
			this._labelNamedPiperServerPath.Text = "Path:";
			// 
			// _tabUdpv4
			// 
			this._tabUdpv4.Controls.Add(this._tableUdpv4);
			this._tabUdpv4.Location = new System.Drawing.Point(4, 22);
			this._tabUdpv4.Name = "_tabUdpv4";
			this._tabUdpv4.Padding = new System.Windows.Forms.Padding(3);
			this._tabUdpv4.Size = new System.Drawing.Size(251, 287);
			this._tabUdpv4.TabIndex = 10;
			this._tabUdpv4.Text = "UDPv4";
			this._tabUdpv4.UseVisualStyleBackColor = true;
			// 
			// _tableUdpv4
			// 
			this._tableUdpv4.ColumnCount = 2;
			this._tableUdpv4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableUdpv4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableUdpv4.Controls.Add(this._labelUdpv4BindEndpoint, 0, 0);
			this._tableUdpv4.Controls.Add(this._udpv4BindEndpoint, 1, 0);
			this._tableUdpv4.Controls.Add(this._udpv4MulticastInterface, 1, 1);
			this._tableUdpv4.Controls.Add(this._labelUdpv4SendTo, 0, 4);
			this._tableUdpv4.Controls.Add(this._udpv4WriteEndpoint, 1, 4);
			this._tableUdpv4.Controls.Add(this._udpv4ReadEndpoint, 1, 3);
			this._tableUdpv4.Controls.Add(this._labelUdpv4ReadFrom, 0, 3);
			this._tableUdpv4.Controls.Add(this._labelUdpv4MulticastInterface, 0, 1);
			this._tableUdpv4.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableUdpv4.Location = new System.Drawing.Point(3, 3);
			this._tableUdpv4.Name = "_tableUdpv4";
			this._tableUdpv4.RowCount = 6;
			this._tableUdpv4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableUdpv4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableUdpv4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableUdpv4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableUdpv4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableUdpv4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tableUdpv4.Size = new System.Drawing.Size(245, 281);
			this._tableUdpv4.TabIndex = 4;
			// 
			// _labelUdpv4SendTo
			// 
			this._labelUdpv4SendTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelUdpv4SendTo.AutoSize = true;
			this._labelUdpv4SendTo.Location = new System.Drawing.Point(3, 85);
			this._labelUdpv4SendTo.Name = "_labelUdpv4SendTo";
			this._labelUdpv4SendTo.Size = new System.Drawing.Size(96, 13);
			this._labelUdpv4SendTo.TabIndex = 1;
			this._labelUdpv4SendTo.Text = "Send to:";
			// 
			// _udpv4ReadEndpoint
			// 
			this._udpv4ReadEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._udpv4ReadEndpoint.Location = new System.Drawing.Point(105, 56);
			this._udpv4ReadEndpoint.Name = "_udpv4ReadEndpoint";
			this._udpv4ReadEndpoint.Size = new System.Drawing.Size(137, 20);
			this._udpv4ReadEndpoint.TabIndex = 0;
			// 
			// _labelUdpv4ReadFrom
			// 
			this._labelUdpv4ReadFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelUdpv4ReadFrom.AutoSize = true;
			this._labelUdpv4ReadFrom.Location = new System.Drawing.Point(3, 59);
			this._labelUdpv4ReadFrom.Name = "_labelUdpv4ReadFrom";
			this._labelUdpv4ReadFrom.Size = new System.Drawing.Size(96, 13);
			this._labelUdpv4ReadFrom.TabIndex = 0;
			this._labelUdpv4ReadFrom.Text = "Read from:";
			// 
			// _udpv4WriteEndpoint
			// 
			this._udpv4WriteEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._udpv4WriteEndpoint.Location = new System.Drawing.Point(105, 82);
			this._udpv4WriteEndpoint.Name = "_udpv4WriteEndpoint";
			this._udpv4WriteEndpoint.Size = new System.Drawing.Size(137, 20);
			this._udpv4WriteEndpoint.TabIndex = 2;
			// 
			// _labelUdpv4BindEndpoint
			// 
			this._labelUdpv4BindEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelUdpv4BindEndpoint.AutoSize = true;
			this._labelUdpv4BindEndpoint.Location = new System.Drawing.Point(3, 6);
			this._labelUdpv4BindEndpoint.Name = "_labelUdpv4BindEndpoint";
			this._labelUdpv4BindEndpoint.Size = new System.Drawing.Size(96, 13);
			this._labelUdpv4BindEndpoint.TabIndex = 3;
			this._labelUdpv4BindEndpoint.Text = "Endpoint:";
			// 
			// _udpv4BindEndpoint
			// 
			this._udpv4BindEndpoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._udpv4BindEndpoint.Location = new System.Drawing.Point(105, 3);
			this._udpv4BindEndpoint.Name = "_udpv4BindEndpoint";
			this._udpv4BindEndpoint.Size = new System.Drawing.Size(137, 20);
			this._udpv4BindEndpoint.TabIndex = 4;
			// 
			// _labelUdpv4MulticastInterface
			// 
			this._labelUdpv4MulticastInterface.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._labelUdpv4MulticastInterface.AutoSize = true;
			this._labelUdpv4MulticastInterface.Location = new System.Drawing.Point(3, 33);
			this._labelUdpv4MulticastInterface.Name = "_labelUdpv4MulticastInterface";
			this._labelUdpv4MulticastInterface.Size = new System.Drawing.Size(96, 13);
			this._labelUdpv4MulticastInterface.TabIndex = 5;
			this._labelUdpv4MulticastInterface.Text = "Multicast interface:";
			// 
			// _udpv4MulticastInterface
			// 
			this._udpv4MulticastInterface.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._udpv4MulticastInterface.FormattingEnabled = true;
			this._udpv4MulticastInterface.Location = new System.Drawing.Point(105, 29);
			this._udpv4MulticastInterface.Name = "_udpv4MulticastInterface";
			this._udpv4MulticastInterface.Size = new System.Drawing.Size(137, 21);
			this._udpv4MulticastInterface.TabIndex = 6;
			this._udpv4MulticastInterface.DropDown += new System.EventHandler(this._udpv4MulticastInterface_DropDown);
			// 
			// EndpointProperties
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._type);
			this.Name = "EndpointProperties";
			this.Size = new System.Drawing.Size(259, 313);
			_tableSerial.ResumeLayout(false);
			_tableSerial.PerformLayout();
			_settingsTable.ResumeLayout(false);
			_settingsTable.PerformLayout();
			_tableStatistics.ResumeLayout(false);
			_tableStatistics.PerformLayout();
			this._type.ResumeLayout(false);
			this._tabSettings.ResumeLayout(false);
			this._tabStatistics.ResumeLayout(false);
			this._tabTcp.ResumeLayout(false);
			this._tableTcp.ResumeLayout(false);
			this._tableTcp.PerformLayout();
			this._tabSerial.ResumeLayout(false);
			this._tabTcpv4Client.ResumeLayout(false);
			this._tableTcpv4Client.ResumeLayout(false);
			this._tableTcpv4Client.PerformLayout();
			this._tabTcpv4Server.ResumeLayout(false);
			this._tableTcpv4Server.ResumeLayout(false);
			this._tableTcpv4Server.PerformLayout();
			this._tabTcpv6Client.ResumeLayout(false);
			this._tableTcpv6Client.ResumeLayout(false);
			this._tableTcpv6Client.PerformLayout();
			this._tabTcpv6Server.ResumeLayout(false);
			this._tableTcpv6Server.ResumeLayout(false);
			this._tableTcpv6Server.PerformLayout();
			this._tabNamedPipeClient.ResumeLayout(false);
			this._tableNamedPipeClient.ResumeLayout(false);
			this._tableNamedPipeClient.PerformLayout();
			this._tabNamedPipeServer.ResumeLayout(false);
			this._tableNamedPipeServer.ResumeLayout(false);
			this._tableNamedPipeServer.PerformLayout();
			this._tabUdpv4.ResumeLayout(false);
			this._tableUdpv4.ResumeLayout(false);
			this._tableUdpv4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _type;
        private System.Windows.Forms.TabPage _tabSerial;
        private System.Windows.Forms.TabPage _tabTcpv4Client;
        private System.Windows.Forms.TabPage _tabTcpv4Server;
        private System.Windows.Forms.Label _labelPath;
        private System.Windows.Forms.ComboBox _stopBits;
        private System.Windows.Forms.TextBox _baudRate;
        private System.Windows.Forms.Label _lableStopBits;
        private System.Windows.Forms.TextBox _readIntervalTimeout;
        private System.Windows.Forms.Label _labelReadIntervalTimeout;
        private System.Windows.Forms.Label _labelBaudRate;
        private System.Windows.Forms.Label _labelParity;
        private System.Windows.Forms.ComboBox _parity;
		private System.Windows.Forms.TableLayoutPanel _tableTcpv4Client;
		private System.Windows.Forms.TextBox _tcpv4Endpoint;
		private System.Windows.Forms.ComboBox _path;
		private System.Windows.Forms.TabPage _tabSettings;
		private System.Windows.Forms.CheckBox _writable;
		private System.Windows.Forms.Label _writableLabel;
		private System.Windows.Forms.CheckBox _readable;
		private System.Windows.Forms.Label _holdLabel;
		private System.Windows.Forms.TextBox _name;
		private System.Windows.Forms.Label _readableLabel;
		private System.Windows.Forms.Label _nameLabel;
		private System.Windows.Forms.CheckBox _hold;
		private System.Windows.Forms.Label _typeLabel;
		private System.Windows.Forms.ComboBox _endpointType;
		private System.Windows.Forms.TabPage _tabStatistics;
		private System.Windows.Forms.TextBox _reconnectCount;
		private System.Windows.Forms.TextBox _readenBytes;
		private System.Windows.Forms.TabPage _tabTcp;
		private System.Windows.Forms.TableLayoutPanel _tableTcp;
		private System.Windows.Forms.TextBox _tcpKeepAliveInterval;
		private System.Windows.Forms.TextBox _tcpKeepAliveTimeout;
		private System.Windows.Forms.TableLayoutPanel _tableTcpv4Server;
		private System.Windows.Forms.TextBox _tcpv4ServerEndpoint;
		private System.Windows.Forms.TabPage _tabTcpv6Client;
		private System.Windows.Forms.TableLayoutPanel _tableTcpv6Client;
		private System.Windows.Forms.TextBox _tcpv6Endpoint;
		private System.Windows.Forms.Label _labelTcpv6Endpoint;
		private System.Windows.Forms.TabPage _tabTcpv6Server;
		private System.Windows.Forms.TableLayoutPanel _tableTcpv6Server;
		private System.Windows.Forms.TextBox _tcpv6ServerEndpoint;
		private System.Windows.Forms.Label _labelTcpv6ServerEndpoint;
		private System.Windows.Forms.TabPage _tabNamedPipeClient;
		private System.Windows.Forms.TableLayoutPanel _tableNamedPipeClient;
		private System.Windows.Forms.TextBox _namedPipeClientPath;
		private System.Windows.Forms.Label _labelNamedPipeClientPath;
		private System.Windows.Forms.TabPage _tabNamedPipeServer;
		private System.Windows.Forms.TableLayoutPanel _tableNamedPipeServer;
		private System.Windows.Forms.TextBox _namedPiperServerPath;
		private System.Windows.Forms.Label _labelNamedPiperServerPath;
		private System.Windows.Forms.TextBox _readenPackets;
		private System.Windows.Forms.TabPage _tabUdpv4;
		private System.Windows.Forms.TableLayoutPanel _tableUdpv4;
		private System.Windows.Forms.TextBox _udpv4ReadEndpoint;
		private System.Windows.Forms.Label _labelUdpv4ReadFrom;
		private System.Windows.Forms.Label _labelReconnectCount;
		private System.Windows.Forms.Label _labelPacketsReaden;
		private System.Windows.Forms.Label _labelReaden;
		private System.Windows.Forms.Label _labelTcpv4Endpoint;
		private System.Windows.Forms.Label _labelTcpv4ServerEndpoint;
		private System.Windows.Forms.Label _labelTcpKeepAliveTimeout;
		private System.Windows.Forms.Label _labelTcpKeepAliveInterval;
		private System.Windows.Forms.Label _labelTcpv4BindAddress;
		private System.Windows.Forms.Label _labelTcpv6BindAddress;
		private System.Windows.Forms.ComboBox _tcpv4BindAddress;
		private System.Windows.Forms.ComboBox _tcpv6BindAddress;
		private System.Windows.Forms.Label _labelUdpv4SendTo;
		private System.Windows.Forms.TextBox _udpv4WriteEndpoint;
		private System.Windows.Forms.Label _labelUdpv4BindEndpoint;
		private System.Windows.Forms.TextBox _udpv4BindEndpoint;
		private System.Windows.Forms.ComboBox _udpv4MulticastInterface;
		private System.Windows.Forms.Label _labelUdpv4MulticastInterface;
	}
}
