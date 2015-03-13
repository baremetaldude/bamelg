//
// Created by Eugeny Grishul.
//

using System;
using System.Text;

namespace Test {
	class StringEncoding {
		private static string SourceString = "some lengthy string with many many words containing non-ansi characters like типа вот этих русских букв";

		public static int Run() {
			int dataDependency = 0;
			var result = new byte[200];

			for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
				var length = Encoding.UTF8.GetBytes( SourceString, 0, SourceString.Length, result, 0 );
				dataDependency += result[7] + result[27];
			}

			return dataDependency;
		}
	}
}