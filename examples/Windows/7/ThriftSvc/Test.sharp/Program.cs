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
			using( var transport = new TFramedTransport( new TNamedPipeClientTransport( "bamelg.thrift.example" ) ) ) 
			using( var transport2 = new TFramedTransport( new TNamedPipeClientTransport( "bamelg.thrift.example" ) ) ) {
				transport.Open();
				transport2.Open();

				var client = new Svc2.Client( new TBinaryProtocol( transport ) );
				var client2 = new Svc2.Client( new TBinaryProtocol( transport2 ) );

				var r1 = client.echo( new Dictionary<string, string> { { "microsoft", "http://www.bing.com/maps/" } } );
				var r2 = client2.add( 10, 30 );
				var r3 = client.echo2( new KVP() { Name = new byte[] { 1, 2 }, Value = new byte[] { 3, 4 } } );
			}
		}
	}
}
