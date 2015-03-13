//
// Created by Eugeny Grishul.
//
package test;

public class TestDispatcher {
    public static int IterationCount, ThreadCount;

    public static void main( String[] cmdLine ) throws Throwable {
	if( cmdLine.length < 3 ) {
	    System.out.println( "Not enough minerals!" );
	    return;
	}

	IterationCount = Integer.parseInt( cmdLine[1] );
	ThreadCount = Integer.parseInt( cmdLine[2] );
	int exitCode;

	switch( cmdLine[0] ) {
	    case "StringFormatting":
		exitCode = StringFormatting.run();
		break;
	    case "StringEncoding":
		exitCode = StringEncoding.run();
		break;
	    case "StringFormatHardcoded":
		exitCode = StringFormatHardcoded.run();
		break;
	    case "DateTimeParse":
		exitCode = DateTimeParse.run();
		break;
	    case "TimeSpanParse":
		exitCode = TimeSpanParse.run();
		break;
	    case "DirectoryGetFiles":
		exitCode = DirectoryGetFiles.run();
		break;
	    default:
		System.out.println( "Incorrect test name" );
		return;
	}

	System.exit( exitCode );
    }
}
