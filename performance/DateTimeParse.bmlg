//
// Created by Eugeny Grishul.
//

using System;

namespace Test {
	class DateTimeParse {
		public static int Run() {
			int dataDependency = 0;

			for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
				dataDependency += ( int ) DateTime.Parse( "2012-01-05 01:02:03" ).Second;
				dataDependency += ( int ) DateTime.Parse( "05.01.2012 01:02:03" ).Second;
			}

			return dataDependency;
		}
	}
}