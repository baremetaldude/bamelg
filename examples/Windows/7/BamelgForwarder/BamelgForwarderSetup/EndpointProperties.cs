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

			_endpointType.SelectedIndex = 0;
		}

		private void _endpointType_SelectedIndexChanged( object sender, System.EventArgs e ) {
			var index = ( EndpointType ) _endpointType.SelectedIndex;

			while( _type.TabCount > 2 )
				_type.TabPages.RemoveAt( _type.TabCount - 1 );

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

		private EndpointInfo _cached;

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

		[DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
		public EndpointInfo StatsInfo {
			set {
				if( value == null ) return;

				if(_cached.BytesReaden != value.BytesReaden) _readenBytes.Text = value.BytesReaden?.ToString();
				if( _cached.PacketsReaden != value.PacketsReaden ) _readenPackets.Text = value.PacketsReaden?.ToString();
				if( _cached.ReconnectCount != value.ReconnectCount ) _reconnectCount.Text = value.ReconnectCount.ToString();
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
