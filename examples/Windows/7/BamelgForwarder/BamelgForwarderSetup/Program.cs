//
// Created by Eugeny Grishul
//
// See license at http://bamelg.com/license.txt
//

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Windows.Forms;

namespace BamelgForwarderSetup {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new Setup() );
		}
	}
}
