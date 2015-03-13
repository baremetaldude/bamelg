//
// Created by $USER
//

using System;
using MySql.Data;
using System.IO;
using System.Net;
using MySql.Data.MySqlClient;

namespace Test {
	class MySQLParse {
		public static int Run() {
			var result = 0;

			string connStr = String.Format( "server={0};uid={1};pwd={2};database={3}", "192.168.3.127", "bamelg", "Lj.jUef5DQJxcZC353Do6s21p@", "Bamelg_Example" );
			var conn = new MySqlConnection( connStr );

			conn.Open();

			var row = new SomeData();

			for( int i = 0, max = TestDispatcher.IterationCount; i < max; ++i ) {
				var cmd = new MySqlCommand( "select * from SomeData", conn );
				using( var reader = cmd.ExecuteReader() )
					while( reader.Read() ) {
						row.id = ( int ) reader["id"];
						row.c0 = ( ulong ) reader["c0"] != 0;
						row.c1 = ( int ) reader["c1"];
						row.c2 = ( short ) reader["c2"];
						row.c3 = ( int ) ( decimal ) reader["c3"];
						row.c4 = ( int ) ( decimal ) reader["c4"];
						row.c5 = ( float ) reader["c5"];
						row.c6 = ( double ) reader["c6"];
						row.c7 = ( double ) reader["c7"];
						row.c8 = ( long ) reader["c8"];
						row.c9 = ( sbyte ) reader["c9"];
						row.c10 = ( int ) reader["c10"];
						row.c11 = ( int ) reader["c11"];
						row.c12 = ( double ) ( decimal ) reader["c12"];

						result += row.c2 + row.c10;
					}

			}
			return result;
		}
	}

	public struct SomeData {
		public int id;
		public bool c0 { get; set; }
		public int c1;
		public int c2;
		public int c3;
		public int c4;
		public float c5;
		public double c6;
		public double c7;
		public long c8;
		public int c9;
		public int c10;
		public int c11;
		public double c12;
		public char enum_value;
	}
}