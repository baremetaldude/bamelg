//
// Created by Eugeny Grishul.
//

package test;

import java.util.Formatter;

public class StringFormatting {
	private static final String _format = "http://somesite.com/page.bmlg?param1=%s&param2=%d&param3=%f&param4=%s&helloXSS=%b";

	public static int run() {
		int dataDependency = 0;

		Formatter formatter = new Formatter(); 
		StringBuilder builder = ( StringBuilder ) formatter.out();
		for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
			builder.delete( 0, builder.length() );
			formatter.format( _format, "item", 134, 55.8, "ololo", true );

			dataDependency += builder.charAt( 9 );
		}

		return dataDependency;
	}
}
