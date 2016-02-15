using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BamelgForwarderSetup {
	public partial class Setup : Form {
		ForwarderHttpApi _client = new ForwarderHttpApi();

		public Setup() {
			InitializeComponent();

			_client.OnStatusChanged += () => {
				_statusText.Text = _client.Status;
			};
		}

		private void _registryReload_Click( object sender, EventArgs e ) {

		}

		private void Setup_Shown( object sender, EventArgs e ) {
			UpdateAppSettings();
		}

		private void UpdateAppSettings() {
			var appInfo = _client.GetAppInfo();
			if( appInfo == null ) return;

			_trace.Checked = appInfo.Trace;
		}

		private void _trace_Click( object sender, EventArgs e ) {
			_client.SetTrace( !_trace.Checked );
			UpdateAppSettings();
		}
	}
}
