//
// Created by Eugeny Grishul.
//

package test;

import java.text.SimpleDateFormat;

public class TimeSpanParse {
	public static int run() throws Throwable {
		int dataDependency = 0;
		SimpleDateFormat formatter1 = new SimpleDateFormat( "dd.hh:mm:ss" );

		for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i )
			dataDependency += ( int ) formatter1.parse( "1.13:30:00" ).getSeconds();

		return dataDependency;
	}
}
