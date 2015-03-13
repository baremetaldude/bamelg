//
// Created by Eugeny Grishul.
//
package test;

import java.nio.file.*;

public class DirectoryGetFiles {

	public static int run() throws Throwable {
		int dataDependency = 0;
		String os = System.getProperty( "os.name" );

		Path path = Paths.get( os.contains( "Windows" ) ? "c:\\windows\\fonts" : "/usr/include" );
		for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i )
			try( DirectoryStream<Path> stream = Files.newDirectoryStream( path ) ) {
				for( Path entry : stream ) {
					if( Files.isDirectory( entry ) )
						continue;
					
					String fullPath = entry.toString();
					dataDependency += fullPath.length();
				}
			}

		return dataDependency;
	}
}
