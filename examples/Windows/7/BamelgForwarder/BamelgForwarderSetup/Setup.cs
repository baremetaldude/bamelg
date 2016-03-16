//
// Created by Eugeny Grishul
//
// See license at http://bamelg.com/license.txt
//

using System;
using System.Linq;
using System.Collections.Generic;
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

			_statusText.Text = "";
			_endpoint1.Enabled = false;
			_endpoint2.Enabled = false;

			_statisticsTimer.Enabled = true;
			UpdateStatisticsStatus();
		}

		private async void Setup_Shown( object sender, EventArgs e ) {
			await UpdateAppSettings();
			await UpdateConnectors();
		}

		private async Task UpdateAppSettings() {
			var appInfo = await _client.GetAppInfo();
			if( appInfo == null ) return;

			_trace.Checked = appInfo.Trace;
			_traceTransfer.Checked = appInfo.TraceTransfer;
		}

		private async Task UpdateConnectors() {
			_connections.Items.Clear();

			var connectors = await _client.GetConnectors();
			foreach( var connector in connectors )
				_connections.Items.Add( connector );
		}

		private async void _trace_Click( object sender, EventArgs e ) {
			await _client.SetTrace( !_trace.Checked );
			await UpdateAppSettings();
		}

		private async void _traceTransfer_Click( object sender, EventArgs e ) {
			await _client.SetTraceTransfer( !_traceTransfer.Checked );
			await UpdateAppSettings();
		}

		private async void _add_Click( object sender, EventArgs e ) {
			await _client.AddConnector();
			await UpdateConnectors();
		}

		private async void _remove_Click( object sender, EventArgs e ) {
			if( _connections.SelectedItems?.Count == 0 ) return;

			await _client.RemoveConnector( _connections.SelectedItems[0].Text );
			await UpdateConnectors();
		}

		private async void _connections_AfterLabelEdit( object sender, LabelEditEventArgs e ) {
			if( _connections.SelectedItems?.Count == 0 ) return;

			var connector = _connections.Items[e.Item].Text;
			e.CancelEdit = !await _client.RenameConnector( connector, e.Label );
			await UpdateConnectors();
		}

		private async void _connections_KeyDown( object sender, KeyEventArgs e ) {
			if( e.KeyCode == Keys.F5 )
				await UpdateConnectors();
		}

		private async void _stop_Click( object sender, EventArgs e ) {
			await _client.Stop();
		}

		private async void _save_Click( object sender, EventArgs e ) {
			await _client.Save();
		}

		private async void _reload_Click( object sender, EventArgs e ) {
			await _client.Reload();
			await UpdateConnectors();
		}

		private async void _connections_SelectedIndexChanged( object sender, EventArgs e ) {
			if( _connections.SelectedItems.Count == 0 ) {
				_endpoint1.Info = null;
				_endpoint2.Info = null;

				return;
			}

			var connector = GetActiveConnector();

			var props0 = await _client.GetEndpointProperties( connector, 0 );
			var props1 = await _client.GetEndpointProperties( connector, 1 );

			_endpoint1.Info = props0;
			_endpoint2.Info = props1;
		}

		private string GetActiveConnector() {
			return _connections.SelectedItems[0].Text;
		}

		private void _revert_Click( object sender, EventArgs e ) {
			_endpoint1.Revert();
			_endpoint2.Revert();
		}

		private async void _apply_Click( object sender, EventArgs e ) {
			var props0 = _endpoint1.Info;
			var props1 = _endpoint2.Info;

			var connector = GetActiveConnector();

			await _client.SetEndpointProperties( connector, 0, props0 );
			await _client.SetEndpointProperties( connector, 1, props1 );
		}

		private async void _statisticsTimer_Tick( object sender, EventArgs e ) {
			if( _connections.SelectedItems.Count == 0 ) {
				_endpoint1.Info = null;
				_endpoint2.Info = null;

				return;
			}

			var connector = GetActiveConnector();

			var props0 = await _client.GetEndpointProperties( connector, 0 );
			var props1 = await _client.GetEndpointProperties( connector, 1 );

			_endpoint1.StatsInfo = props0;
			_endpoint2.StatsInfo = props1;
		}



		private void _updateStatistics_Click( object sender, EventArgs e ) {
			_statisticsTimer.Enabled = !_statisticsTimer.Enabled;
			UpdateStatisticsStatus();
		}

		private void UpdateStatisticsStatus() {
			_updateStatistics.Checked = _statisticsTimer.Enabled;
		}
	}
}
