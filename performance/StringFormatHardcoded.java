//
// Created by Eugeny Grishul.
//

package test;

public class StringFormatHardcoded {
	public static int run() {
		int dataDependency = 0;

		for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
			String url = String.format( "http://somesite.com/page.bmlg?param1=%s&param2=%d&param3=%f&param4=%s&helloXSS=%b", "item", 134, 55.8, "ololo", true );

			dataDependency += url.charAt( 9 );
		}

		return dataDependency;
	}
}
