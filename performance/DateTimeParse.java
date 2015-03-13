//
// Created by Eugeny Grishul.
//

package test;

import java.text.SimpleDateFormat;

public class DateTimeParse {
	public static int run() throws Throwable {
		int dataDependency = 0;

		SimpleDateFormat formatter1 = new SimpleDateFormat( "yyyy-MM-dd hh:mm:ss" );
		SimpleDateFormat formatter2 = new SimpleDateFormat( "dd.MM.yyyy hh:mm:ss" );

		for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
			dataDependency += ( int ) formatter1.parse( "2012-01-05 01:02:03" ).getSeconds();
			dataDependency += ( int ) formatter2.parse( "05.01.2012 01:02:03" ).getSeconds();
		}

		return dataDependency;
	}
}
