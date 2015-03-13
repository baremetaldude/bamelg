//
// Created by Eugeny Grishul.
//

using System;

namespace Test {
	class DirectoryGetFiles {
		public static int Run() {
			int dataDependency = 0;

			for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
#if MONO
				foreach( var entry in System.IO.Directory.GetFiles( @"/usr/include" ) ) {
#else
				foreach( var entry in System.IO.Directory.EnumerateFiles( @"c:\Windows\fonts" ) ) {
#endif
					dataDependency += entry.Length;
				}
			}

			return dataDependency;
		}
	}
}