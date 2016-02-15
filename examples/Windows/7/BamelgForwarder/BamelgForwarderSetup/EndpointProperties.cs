using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BamelgForwarderSetup {
	public partial class EndpointProperties : UserControl {
		public EndpointProperties() {
			InitializeComponent();

			_parity.SelectedIndex = 0;
			_stopBits.SelectedIndex = 0;
		}
	}
}
