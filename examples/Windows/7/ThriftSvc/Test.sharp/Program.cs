//
// Created by Eugeny Grishul
//
// See license at http://bamelg.com/license.txt
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using Example;
using Thrift.Protocol;
using Thrift.Transport;

namespace TestThrift {
	class Program {
		public const string PipeName = "bamelg.thrift.example";
		public const string PipeNameFramed = "bamelg.thrift.example.framed";

		static void Main( string[] args ) {
			using( var transport = new TFramedTransport( new TNamedPipeClientTransport( PipeName ) ) )
				transport.Open();

			using( var transport = new TFramedTransport( new TNamedPipeClientTransport( PipeName ) ) ) {
				transport.Open();

				transport.Write( new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 } ); // write trash
				transport.Flush();
			}

			using( var transport = new TNamedPipeClientTransport( PipeName ) ) { // non buffered transport generates a lot of small writes
				transport.Open();

				var client = new Svc2.Client( new TBinaryProtocol( transport ) );

				var result = client.ThrowException( 0 );
				Debug.Assert( result == 333 );
			}

			try {
				using( var transport = new TFramedTransport( new TNamedPipeClientTransport( PipeNameFramed ) ) ) {
					transport.Open();

					var client = new Svc2.Client( new TBinaryProtocol( transport ) );

					var result = client.ThrowException( 1 );
					Debug.Fail( "Should never reach" );
				}
			}
			catch( ExceptionWithMessage message ) {
				Debug.Assert( message.Text == "Exception message" );
			}

			try {
				using( var transport = new TFramedTransport( new TNamedPipeClientTransport( PipeNameFramed ) ) ) {
					transport.Open();

					var client = new Svc2.Client( new TBinaryProtocol( transport ) );

					var result = client.ThrowException( 2 );
					Debug.Fail( "Should never reach" );
				}
			}
			catch( ExceptionWithCode message ) {
				Debug.Assert( message.Code == 111 );
			}

			using( var transport = new TFramedTransport( new TNamedPipeClientTransport( PipeNameFramed ) ) ) {
				transport.Open();

				var client = new Svc2.Client( new TBinaryProtocol( transport ) );

				DoWork( client );
			}

			using( var pipe = new NamedPipeClientStream( ".", PipeName, PipeDirection.InOut, PipeOptions.None ) ) {
				pipe.Connect( 100 );

				var transport = new TStreamTransport( pipe, pipe );
				var client = new Svc2.Client( new TBinaryProtocol( new TBufferedTransport( transport, 8192 ) ) );

				DoWork( client );
			}

			using( var transport = new TFramedTransport( new TNamedPipeClientTransport( PipeNameFramed ) ) ) {
				transport.Open();

				var client = new Svc2.Client( new TBinaryProtocol( transport ) );

				DoWork( client );
			}
		}

		unsafe static void DoWork( Svc2.Client client ) {
			client.some_event( "Oneway RPC by C# app" );
			var r1 = client.echo( new Dictionary<string, string> { { "microsoft", "http://www.bing.com/maps/" } } );
			var r2 = client.add( 10, 30 );
			var r3 = client.echo2( new KVP() { Name = new byte[] { 1, 2 }, Value = new byte[] { 3, 4 } } );

			var dt = DateTime.UtcNow;
			client.log( *( long* ) &dt, new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, "Some message" );
		}
	}
}
