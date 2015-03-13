//
// Created by Eugeny Grishul.
//

using System;

namespace Test {
	class StringFormatHardcoded {
		public static int Run() {
			int dataDependency = 0;
			string url;

			for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
				url = string.Format( "http://somesite.com/page.bmlg?param1={0}&param2={1}&param3={2}&param4={3}", "item", 134, 55.8, "ololo" );
				dataDependency += url[9];
			}

			return dataDependency;
		}
	}
}