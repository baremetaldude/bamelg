//
// Created by Eugeny Grishul
//
// See license at http://bamelg.com/license.txt
//

using System;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;

namespace BamelgForwarderSetup {
	public partial class EndpointProperties : UserControl {
		public EndpointProperties() {
			InitializeComponent();

			_parity.SelectedIndex = 0;
			_stopBits.SelectedIndex = 0;

			foreach( var item in typeof( EndpointType ).GetFields( System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static ) )
				_endpointType.Items.Add( item.Name );

			// _endpointType.SelectedIndex = 0;
			_endpointType.SelectedIndexChanged += _endpointType_SelectedIndexChanged;
		}

		private System.Windows.Forms.ToolTip _toolTip;

		internal void UpdateToolTip( ToolTip toolTip ) {
			_toolTip = toolTip;

			_toolTip.SetToolTip( _lableStopBits, "Default value comes from Device Manager" );
			_toolTip.SetToolTip( _labelReadIntervalTimeout, "Path to serial device \\\\.\\COM6" );
			_toolTip.SetToolTip( _labelBaudRate, "Default value comes from Device Manager" );
			_toolTip.SetToolTip( _labelParity, "Default value comes from Device Manager" );
			_toolTip.SetToolTip( _labelPath, "Path to serial device, e.g. \\\\.\\COM6" );
			_toolTip.SetToolTip( _writableLabel, "Is endpoint readable" );
			_toolTip.SetToolTip( _readableLabel, "Is endpoint writable" );
			_toolTip.SetToolTip( _holdLabel, "Try to keep endpoint alive" );
			_toolTip.SetToolTip( _nameLabel, "Endpoint name" );
			_toolTip.SetToolTip( _typeLabel, "Endpoint type" );
			_toolTip.SetToolTip( _labelReconnectCount, "Reconnect count" );
			_toolTip.SetToolTip( _labelReaden, "Total bytes readen" );
			_toolTip.SetToolTip( _labelPacketsReaden, "Less packets with more bytes minimizes transfer overheads" );
			_toolTip.SetToolTip( _labelTcpKeepAliveTimeout, "Specifies the timeout with no activity until the first keep-alive packet is sent" );
			_toolTip.SetToolTip( _labelTcpKeepAliveInterval, "Specifies the interval between when successive keep-alive packets are sent if no acknowledgement is received. After 10 failed probes connection will be dropped" );
			_toolTip.SetToolTip( _labelTcpv4Endpoint, "Endpoint to connect , e.g. 127.0.0.1:4010" );
			_toolTip.SetToolTip( _labelTcpv4ServerEndpoint, "Endpoint to connect , e.g. 127.0.0.1:4010" );
			_toolTip.SetToolTip( _labelTcpv6Endpoint, "Endpoint to connect , e.g. 127.0.0.1:4010" );
			_toolTip.SetToolTip( _labelTcpv6ServerEndpoint, "Endpoint to connect , e.g. 127.0.0.1:4010" );
			_toolTip.SetToolTip( _labelNamedPipeClientPath, "Endpoint to connect , e.g. \\\\.\\pipe\\LocalPipe or \\\\RemoteServer\\pipe\\RemotePipe" );
			_toolTip.SetToolTip( _labelNamedPiperServerPath, "Endpoint to connect , e.g. \\\\.\\pipe\\RelayPipe" );
			_toolTip.SetToolTip( _labelUdpv4Endpoint, "Endpoint to connect , e.g. 127.0.0.1:4010" );
		}

		private void _endpointType_SelectedIndexChanged( object sender, System.EventArgs e ) {
			var index = ( EndpointType ) _endpointType.SelectedIndex;

			_type.TabPages.Clear();
			_type.TabPages.Add( _tabSettings );
			_type.TabPages.Add( _tabStatistics );

			switch( index ) {
				case EndpointType.SerialPort: _type.TabPages.Add( _tabSerial ); break;
				case EndpointType.TCPv4: _type.TabPages.Add( _tabTcp ); _type.TabPages.Add( _tabTcpv4Client ); break;
				case EndpointType.TCPv4Server: _type.TabPages.Add( _tabTcp ); _type.TabPages.Add( _tabTcpv4Server ); break;
				case EndpointType.TCPv6: _type.TabPages.Add( _tabTcp ); _type.TabPages.Add( _tabTcpv6Client ); break;
				case EndpointType.TCPv6Server: _type.TabPages.Add( _tabTcp ); _type.TabPages.Add( _tabTcpv6Server ); break;
				case EndpointType.NamedPipe: _type.TabPages.Add( _tabNamedPipeClient ); break;
				case EndpointType.NamedPipeServer: _type.TabPages.Add( _tabNamedPipeServer ); break;
				case EndpointType.UDPv4: _type.TabPages.Add( _tabUdpv4 ); break;
			}
		}

		private EndpointInfo _cached = null;

		public void Revert() {
			Info = _cached;
		}

		[DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public EndpointInfo Info {
			get {
				var result = new EndpointInfo();

				result.Type = ( EndpointType ) _endpointType.SelectedIndex;

				result.Name = _name.Text;
				result.IsReadable = _readable.Checked;
				result.IsWritable = _writable.Checked;
				result.IsHold = _hold.Checked;

				result.BytesReaden = ulong.Parse( _readenBytes.Text );
				result.PacketsReaden = string.IsNullOrEmpty( _readenPackets.Text ) ? default( int? ) : int.Parse( _readenPackets.Text );
				result.ReconnectCount = int.Parse( _reconnectCount.Text );

				result.SerialPortPath = _path.Text;
				result.SerialPortReadIntervalTimeout = string.IsNullOrEmpty( _readIntervalTimeout.Text ) ? default( int? ) : int.Parse( _readIntervalTimeout.Text );
				result.SerialPortBaudRate = string.IsNullOrEmpty( _baudRate.Text ) ? default( int? ) : int.Parse( _baudRate.Text );
				result.SerialPortParity = ( ParityScheme ) _parity.SelectedIndex;
				result.SerialPortStopBits = ( StopBitsValue ) _stopBits.SelectedIndex;

				result.TCPv4Endpoint = _tcpv4Endpoint.Text;
				result.TCPv4ServerEndpoint = _tcpv4ServerEndpoint.Text;

				result.TCPv6Endpoint = _tcpv6Endpoint.Text;
				result.TCPv6ServerEndpoint = _tcpv6ServerEndpoint.Text;

				result.NamedPipePath = _namedPipeClientPath.Text;
				result.NamedPipeServerPath = _namedPiperServerPath.Text;

				result.UDPv4Endpoint = _udpv4Endpoint.Text;

				result.TCPKeepAliveTimeout = TimeSpan.Parse( _tcpKeepAliveTimeout.Text );
				result.TCPKeepAliveInterval = TimeSpan.Parse( _tcpKeepAliveInterval.Text );

				return result;
			}
			set {
				_cached = value;

				Enabled = value != null;
				if( !Enabled ) return;

				_endpointType.SelectedIndex = ( int ) value.Type;

				_name.Text = value.Name;
				_readable.Checked = value.IsReadable ?? false;
				_writable.Checked = value.IsWritable ?? false;
				_hold.Checked = value.IsHold ?? false;

				_readenBytes.Text = value.BytesReaden?.ToString();
				_readenPackets.Text = value.PacketsReaden?.ToString();
				_reconnectCount.Text = value.ReconnectCount.ToString();

				_path.Text = value.SerialPortPath;
				_readIntervalTimeout.Text = value.SerialPortReadIntervalTimeout?.ToString();
				_baudRate.Text = value.SerialPortBaudRate?.ToString();
				_parity.SelectedIndex = ( int ) value.SerialPortParity;
				_stopBits.SelectedIndex = ( int ) value.SerialPortStopBits;

				_tcpv4Endpoint.Text = value.TCPv4Endpoint;
				_tcpv4ServerEndpoint.Text = value.TCPv4ServerEndpoint;
				_tcpv6Endpoint.Text = value.TCPv6Endpoint;
				_tcpv6ServerEndpoint.Text = value.TCPv6ServerEndpoint;

				_namedPipeClientPath.Text = value.NamedPipePath;
				_namedPiperServerPath.Text = value.NamedPipeServerPath;

				_udpv4Endpoint.Text = value.UDPv4Endpoint;

				_tcpKeepAliveTimeout.Text = value.TCPKeepAliveTimeout.ToString();
				_tcpKeepAliveInterval.Text = value.TCPKeepAliveInterval.ToString();
			}
		}

		public bool IsStatisticsShown {
			get { return _type.SelectedTab == _tabStatistics; }
		}

		[DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public EndpointInfo StatsInfo {
			set {
				if( value == null ) return;

				if( _cached == null )
					_cached = new EndpointInfo();

				if( _cached.BytesReaden != value.BytesReaden ) { _cached.BytesReaden = value.BytesReaden; _readenBytes.Text = value.BytesReaden?.ToString(); }
				if( _cached.PacketsReaden != value.PacketsReaden ) { _cached.PacketsReaden = value.PacketsReaden; _readenPackets.Text = value.PacketsReaden?.ToString(); }
				if( _cached.ReconnectCount != value.ReconnectCount ) { _cached.ReconnectCount = value.ReconnectCount; _reconnectCount.Text = value.ReconnectCount.ToString(); }
			}
		}

		private async void _path_DropDown( object sender, EventArgs e ) {
			var comPorts = await new ForwarderHttpApi().GetComPorts();
			var paths = comPorts.Select( x => x.Item1 ).ToArray();

			_path.Items.Clear();
			_path.Items.AddRange( paths );
		}
	}
}
