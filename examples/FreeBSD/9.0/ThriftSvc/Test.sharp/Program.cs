//
// Created by Eugeny Grishul
//
// See license at http://bamelg.com/license.txt
//

using System.Collections.Generic;

using Example;
using Thrift.Protocol;
using Thrift.Transport;

namespace TestThrift {
	class Program {
		static void Main( string[] args ) {
			using( var transport = new TSocket( "freebsdx86", 7070 ) ) {
				transport.Open();

				var client = new Svc2.Client( new TBinaryProtocol( new TFramedTransport( transport ) ) );

				var r1 = client.echo( new Dictionary<string, string> { { "microsoft", "http://www.bing.com/maps/" } } );
				var r2 = client.add( 10, 30 );
				var r3 = client.echo2( new KVP() { Name = new byte[] { 1, 2 }, Value = new byte[] { 3, 4 } } );
			}
		}
	}
}
