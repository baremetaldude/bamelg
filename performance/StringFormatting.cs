//
// Created by Eugeny Grishul.
//

using System;
using System.Text;

namespace Test {
	class StringFormatting {
		public static int Run() {
			int dataDependency = 0;

			var builder = new StringBuilder();
			for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
				builder.Length = 0;
				builder.AppendFormat( "http://somesite.com/page.bmlg?param1={0}&param2={1}&param3={2}&param4={3}&helloXSS={4}", "item", 134, 55.8, "ololo", true );

				dataDependency += builder[9];
			}

			return dataDependency;
		}
	}
}