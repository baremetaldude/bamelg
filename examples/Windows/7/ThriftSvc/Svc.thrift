#!/usr/local/bin/thrift --bamelg

namespace java org.example.thrift
namespace cpp org.example
namespace csharp Example
namespace py example
namespace php example
namespace perl Example
namespace rb ExampleThrift

typedef i64 System_DateTime ( bamelg.builtin = "System.DateTime" )
typedef i64 System_TimeSpan ( bamelg.builtin = "System.TimeSpan" )
typedef binary System_Guid ( bamelg.builtin = "System.Guid" )

struct KVP {
   1: required binary name,
   2: required binary value,
}

union UVP {
   1: binary name,
   2: binary value,
}

exception ExceptionWithMessage {
  1: string Text;
}

exception ExceptionWithCode {
  1: i32 Code;
}

service Svc1 {
  i32 add( 1: i32 left, 2: i32 right ) throws ( 1: ExceptionWithMessage excpt ),
  list<string> get_strings(),
  map<string,string> echo( 1: map<string,string> value ),
  oneway void some_event( 1: string text ),
  oneway void log( 1: System_DateTime date, 2: System_Guid id, 3: string text ),
  oneway void ts( 1: list<System_TimeSpan> span ),
}

service Svc2 extends Svc1 {
  set<string> get_strings2(),
  KVP echo2( 1: KVP value ),
  i32 ThrowException( 1: i32 value ) throws ( 1: ExceptionWithMessage excpt, 2: ExceptionWithCode ec ),
}
