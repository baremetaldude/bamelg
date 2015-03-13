#!/usr/local/bin/thrift --bamelg

namespace java org.example.thrift
namespace cpp org.example
namespace csharp Example
namespace py example
namespace php example
namespace perl Example
namespace rb ExampleThrift

struct KVP {
   1: required binary name,
   2: required binary value,
}

service Svc1 {
  i32 add( 1: i32 left, 2: i32 right ),
  list<string> get_strings(),
  map<string,string> echo(),
}

service Svc2 extends Svc1 {
  set<string> get_strings2(),
  KVP echo2( 1: KVP value ),
}
