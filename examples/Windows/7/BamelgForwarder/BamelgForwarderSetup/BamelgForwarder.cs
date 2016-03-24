//
// Created by Eugeny Grishul
//
// See license at http://bamelg.com/license.txt
//

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BamelgForwarderSetup {
	public enum EndpointType {
		SerialPort,      // Serial port, SerialPortPath = \\.\COM1
		TCPv4,           // TCP v4 client, TCPv4Endpoint = 127.0.0.1:4010
		TCPv4Server,     // TCP v4 server, TCPv4ServerEndpoint = 0.0.0.0:4010
		TCPv6,           // TCP v6 client, TCPv6Endpoint = [::1]:2346
		TCPv6Server,     // TCP v6 server, TCPv6ServerEndpoint = [::1]:2346
		UDPv4,           // UDP v4 client, UDPv4Endpoint = 127.0.0.1:4010
		NamedPipe,       // Named pipe client, NamedPipePath = \\.\pipe\PipeName
		NamedPipeServer, // Named pipe, NamedPipeServerPath = \\.\pipe\PipeName
	}

	public enum ParityScheme : byte {
		NOPARITY = 0,
		ODDPARITY = 1,
		EVENPARITY = 2,
		MARKPARITY = 3,
		SPACEPARITY = 4,
	}

	public enum StopBitsValue : byte {
		ONESTOPBIT = 0,
		ONE5STOPBITS = 1,
		TWOSTOPBITS = 2,
	}

	public class AppInfo {
		public bool Trace, TraceTransfer;
	}

	public class EndpointInfo {
		public string Name;
		public EndpointType Type;
		public string SerialPortPath;
		public int? SerialPortBaudRate;
		public int? SerialPortReadIntervalTimeout;
		public ParityScheme? SerialPortParity;
		public StopBitsValue SerialPortStopBits;
		public int ReconnectCount;
		public bool? IsReadable;
		public bool? IsWritable;
		public bool? IsAlive;
		public int? PacketsReaden;
		public ulong? BytesReaden;


		public string TCPv4Endpoint;
		public TimeSpan TCPKeepAliveInterval;
		public TimeSpan TCPKeepAliveTimeout;

		// @}

		// @{ TCPv4Server settings
		public string TCPv4ServerEndpoint;
		// @}

		// @{ TCPv6 settings
		public string TCPv6Endpoint;
		// @}

		// @{ TCPv6Server settings
		public string TCPv6ServerEndpoint;
		// @}

		// @{ UDPv4 settings
		public string UDPv4Endpoint;
		public string UDPv4RemoteEndpoint;
		// @}

		public string NamedPipePath;
		public string NamedPipeServerPath;

		public NameValueCollection ToNameValueCollection() { // automapper unable to map object to NameValueCollection and vice versa
			var result = new NameValueCollection();

			//foreach( var member in GetType().GetFields( BindingFlags.Instance | BindingFlags.Public ) ) {
			//	var value = member.GetValue( this );
			//	if( value == null ) continue;

			//	result.Add( member.Name, value.ToString() );
			//}

			result.Add( nameof( Name ), Name );
			result.Add( nameof( Type ), Type.ToString() );
			result.Add( nameof( SerialPortPath ), SerialPortPath );
			result.Add( nameof( SerialPortBaudRate ), SerialPortBaudRate?.ToString() );
			result.Add( nameof( SerialPortReadIntervalTimeout ), SerialPortReadIntervalTimeout?.ToString() );
			result.Add( nameof( SerialPortParity ), SerialPortParity?.ToString() );
			result.Add( nameof( SerialPortStopBits ), SerialPortStopBits.ToString() );
			// result.Add( nameof( ReconnectCount ), ReconnectCount.ToString() );
			result.Add( nameof( IsReadable ), IsReadable?.ToString() );
			result.Add( nameof( IsWritable ), IsWritable?.ToString() );
			// result.Add( nameof( IsAlive ), IsAlive?.ToString() );
			// result.Add( nameof( PacketsReaden ), PacketsReaden?.ToString() );
			// result.Add( nameof( BytesReaden ), BytesReaden?.ToString() );

			result.Add( nameof( TCPv4Endpoint ), TCPv4Endpoint );
			result.Add( nameof( TCPKeepAliveInterval ), TCPKeepAliveInterval.ToString() );
			result.Add( nameof( TCPKeepAliveTimeout ), TCPKeepAliveTimeout.ToString() );

			result.Add( nameof( TCPv4ServerEndpoint ), TCPv4ServerEndpoint );

			result.Add( nameof( TCPv6Endpoint ), TCPv6Endpoint );

			result.Add( nameof( TCPv6ServerEndpoint ), TCPv6ServerEndpoint );

			result.Add( nameof( UDPv4Endpoint ), UDPv4Endpoint );
			result.Add( nameof( UDPv4RemoteEndpoint ), UDPv4RemoteEndpoint );

			result.Add( nameof( NamedPipePath ), NamedPipePath );
			result.Add( nameof( NamedPipeServerPath ), NamedPipeServerPath );

			return result;
		}
	}

	public class ForwarderHttpApi {
		private WebClient NewClient {
			get { return new WebClient() { BaseAddress = Server }; }
		}

		public string Server;

		public event Action OnStatusChanged;

		public ForwarderHttpApi() {
			Server = "http://127.0.0.1:4015";
		}

		private string _status = "";
		public string Status {
			get { return _status; }
			set {
				if( _status == value ) return;
				_status = value;
				if( OnStatusChanged != null ) OnStatusChanged();
			}
		}

		public async Task<AppInfo> GetAppInfo() {
			try {
				var json = await NewClient.DownloadStringTaskAsync( "app/settings" );

				var result = JsonConvert.DeserializeObject<AppInfo>( json );
				return result;
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}

			return null;
		}

		public async Task<List<Tuple<string, string>>> GetComPorts() {
			try {
				var json = await NewClient.DownloadStringTaskAsync( "app/serial_ports" );

				var result = JsonConvert.DeserializeObject<List<Tuple<string, string>>>( json );
				return result;
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}

			return null;
		}

		public async Task<List<string>> GetConnectors() {
			try {
				var json = await NewClient.DownloadStringTaskAsync( $"app/connectors" );
				var result = JsonConvert.DeserializeObject<List<string>>( json );

				return result;
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}

			return null;
		}

		public async Task SetTrace( bool value ) {
			try {
				var post = new NameValueCollection();
				post.Add( nameof( AppInfo.Trace ), value.ToString() );

				var result = await NewClient.UploadValuesTaskAsync( $"app/settings", post );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}
		}

		public async Task SetTraceTransfer( bool value ) {
			try {
				var post = new NameValueCollection();
				post.Add( nameof( AppInfo.TraceTransfer ), value.ToString() );

				var result = await NewClient.UploadValuesTaskAsync( $"app/settings", post );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}
		}

		public async Task AddConnector() {
			try {
				var post = new NameValueCollection();
				post.Add( "name", Guid.NewGuid().ToString() );

				var result = await NewClient.UploadValuesTaskAsync( "connector/add", post );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}
		}

		public async Task RemoveConnector( string value ) {
			try {
				var post = new NameValueCollection();
				post.Add( "name", value );

				var result = await NewClient.UploadValuesTaskAsync( "connector/remove", post );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}
		}

		public async Task<bool> RenameConnector( string name, string newName ) {
			try {
				var post = new NameValueCollection();
				post.Add( "name", name );
				post.Add( "value", newName );

				var result = await NewClient.UploadValuesTaskAsync( "connector/rename", post );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
				return false;
			}

			return true;
		}

		public async Task Stop() {
			try {
				var result = await NewClient.UploadValuesTaskAsync( "app/exit", new NameValueCollection() );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}
		}

		public async Task Save() {
			try {
				var result = await NewClient.UploadValuesTaskAsync( "app/save", new NameValueCollection() );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}
		}

		public async Task Reload() {
			try {
				var result = await NewClient.UploadValuesTaskAsync( "app/reload", new NameValueCollection() );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}
		}

		public async Task<EndpointInfo> GetEndpointProperties( string name, int id ) {
			try {
				var parameters = new NameValueCollection();
				parameters.Add( "connector", name );

				var client = NewClient;
				client.QueryString = parameters;

				var json = await client.DownloadStringTaskAsync( $"endpoint/{id}/properties" );
				return JsonConvert.DeserializeObject<EndpointInfo>( json );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}

			return null;
		}

		public async Task SetEndpointProperties( string name, int id, EndpointInfo props0, bool defer ) {
			var post = props0.ToNameValueCollection();
			try {
				post.Add( "connector", name );
				if( defer ) post.Add( "defer", "" );

				var result = await NewClient.UploadValuesTaskAsync( $"endpoint/{id}/properties", post );
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}
		}
	}
}
