using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BamelgForwarderSetup {
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
		public bool Trace;
	}

	class EndpointInfo {
		public string SerialPortPath;
		public int? SerialPortBaudRate;
		public ParityScheme? SerialPortParity;
	}

	public class ForwarderHttpApi {
		public string Server = "http://127.0.0.1:4015";

		public event Action OnStatusChanged;

		private string _status = "";
		public string Status {
			get { return _status; }
			set {
				if( _status == value ) return;
				_status = value;
				if( OnStatusChanged != null ) OnStatusChanged();
			}
		}

		public AppInfo GetAppInfo() {
			try {
				var wc = new WebClient();

				wc.BaseAddress = Server;
				var json = wc.DownloadString( "settings.json" );

				var result = JsonConvert.DeserializeObject<AppInfo>( json );
				Status = "";
				return result;
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}

			return null;
		}

		public void SetTrace( bool trace ) {
			try {
				var wc = new WebClient();

				wc.BaseAddress = Server;

				var result = wc.UploadString( "settings.json", $"Trace={trace}" );

				Status = "";
			}
			catch( Exception excpt ) {
				Status = excpt.Message;
			}
		}
	}
}
