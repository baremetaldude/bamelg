//
// Created by Eugeny Grishul.
//

using System;

namespace Test {
	class TimeSpanParse {
		public static int Run() {
			int dataDependency = 0;

			for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
				dataDependency += ( int ) TimeSpan.Parse( "1.13:30:00" ).Seconds;
			}

			return dataDependency;
		}
	}
}