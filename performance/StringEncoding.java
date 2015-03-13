//
// Created by Eugeny Grishul.
//

package test;

public class StringEncoding {
	private static final String SourceString = "some lengthy string with many many words containing non-ansi characters like типа вот этих русских букв";

	public static int run() throws Throwable {
		int dataDependency = 0;

		for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
			byte[] result = SourceString.getBytes( "UTF-8" );
			dataDependency += result[7] + result[27];
		}

		return dataDependency;
	}
}
