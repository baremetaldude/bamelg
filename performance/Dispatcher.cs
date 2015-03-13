//
// Created by Eugeny Grishul.
//
// "StringFormat.exe" StringEncoding 100000 1
//

using System;
using System.Text;
using System.Threading;

namespace Test {
	class TestDispatcher {
		public static int IterationCount, ThreadCount;
		
		public static void Main() {
			var cmdLine = Environment.GetCommandLineArgs();
			if( cmdLine.Length < 4 ) { Console.WriteLine( "Not enough minerals!" ); return; }

			Func<int> method = null;
			switch( cmdLine[1] ) {
				case "StringFormatting": method = StringFormatting.Run; break;
				case "StringEncoding": method = StringEncoding.Run; break;
				case "StringFormatHardcoded": method = StringFormatHardcoded.Run; break;
				case "DateTimeParse": method = DateTimeParse.Run; break;
				case "TimeSpanParse": method = TimeSpanParse.Run; break;
				case "DirectoryGetFiles": method = DirectoryGetFiles.Run; break;
				case "MySQLParse": method = MySQLParse.Run; break;
					 
				default: Console.WriteLine( "Incorrect test name" ); return;
			}

			IterationCount = int.Parse( cmdLine[2] );
			ThreadCount = int.Parse( cmdLine[3] );

			if( ThreadCount == 1 )
				Environment.ExitCode = method();
			else {
				var threads = new Thread[ThreadCount];
				for( int i = 0; i < threads.Length; ++i ) { threads[i] = new Thread( data => method() ); threads[i].Start(); }
				foreach( var thread in threads ) thread.Join();
			}

			GC.Collect();
		}
	}
}