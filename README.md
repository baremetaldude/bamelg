# Bamelg - bare metal language
See details at http://bamelg.com

Bamelg is component-oriented language similar to C# but designed for low-level purposes.

* Designed to be used by C++/C# experts
* Powerful type system
  * Primitive types 
    * bool, byte, sbyte, ushort, short, uint, int, ulong, long, float, double, <a href="http://bamelg.com/source/modules/BCL/System/Guid.bmlg">Guid</a>
      * Decimal, hexadecimal, binary literals
    * Big-endian and little-endian variants of primitive types - float/float_littleendian/float_bigendian etc.
  * Derived types - pointers, references, fixed arrays, dynamic arrays
  * String types - <a href="http://bamelg.com/source/modules/BCL/System/SbcsString.bmlg">SbcsString</a>, <a href="http://bamelg.com/source/modules/BCL/System/Utf8String.bmlg">Utf8String</a>, <a href="http://bamelg.com/source/modules/BCL/System/Utf16String.bmlg">Utf16String</a>, <a href="http://bamelg.com/source/modules/BCL/System/Utf32String.bmlg">Utf32String</a>
  * Enums, interfaces, functors, delegates 
* Rich language features
  * Properties, indexed properties, indexers, safe navigation
  * Automatic struct layout packing
  * Template structs/classes/interfaces/functors/delegates/methods
    * Full specialization support
  * Overloadable operators
  * Reflection, attributes
  * Events, Iterators, Extension methods
  * Lambda expressions
  * Assembly <a href="http://bamelg.com/source/modules/BCL/System/Numerics/Matrix4.bmlg">language</a> <a href="http://bamelg.com/source/modules/BCL/System/Numerics/Quaternion.bmlg">support</a>
  * Overflow checking intrinsics
  * Non-cdecl calling conventions support
  * Thread-local storage, fiber-local storage
* Bare-metal runtime
  * Fiber-based framework for IO-intensive tasks
    * High-perfromance HTTP server and Thrift RPC servers are provided
  * Flexible template collection types
    * Easy to use containers <a href="http://bamelg.com/source/modules/BCL/System/Collections/List.bmlg"><t>List</t></a>&lt;T&gt;, <a href="http://bamelg.com/source/modules/BCL/System/Collections/Dictionary.bmlg"><t>Dictionary</t></a>&lt;TKey, TValue&gt;, <a href="http://bamelg.com/source/modules/BCL/System/Collections/HashSet.bmlg"><t>HashSet</t></a>&lt;T&gt; etc.
    * High-volume containers <a href="http://bamelg.com/source/modules/BCL/System/Collections/PagedQueue.bmlg"><t>PagedQueue</t></a>&lt;T&gt;, <a href="http://bamelg.com/source/modules/BCL/System/Collections/PagedPool.bmlg"><t>PagedPool</t></a>&lt;T&gt;
  * No garbage collector with unexpected delays
    * Customizable atomic/non-atomic reference counting for class instances
  * No mix of languages in runtime library
    * All high-level and low-level code written entirely in Bamelg
  * Able to interop with any native libraries
    * <a href="http://bamelg.com/source/modules/Gtk/Platform/Linux/2.6/Platform/GtkApi.bmlg">GTK</a> bindings <a href="http://bamelg.com/source/modules/Gtk/Platform/Linux/2.6_-_X86_32/Platform/GtkApi.Interop.bmlg">x86</a> <a href="http://bamelg.com/source/modules/Gtk/Platform/Linux/2.6_-_X86_64/Platform/GtkApi.Interop.bmlg">x64</a>
    * <a href="http://bamelg.com/source/modules/Gdk/Platform/Linux/2.6/Platform/GdkApi.bmlg">GDK</a> bindings <a href="http://bamelg.com/source/modules/Gdk/Platform/Linux/2.6_-_X86_32/Platform/GdkApi.Interop.bmlg">x86</a> <a href="http://bamelg.com/source/modules/Gdk/Platform/Linux/2.6_-_X86_64/Platform/GdkApi.Interop.bmlg">x64</a>
    * <a href="http://bamelg.com/source/modules/Cairo/Platform/Linux/2.6/Platform/CairoApi.bmlg">Cairo</a> bindings <a href="http://bamelg.com/source/modules/Cairo/Platform/Linux/2.6_-_X86_32/Platform/CairoApi.Interop.bmlg">x86</a> <a href="http://bamelg.com/source/modules/Cairo/Platform/Linux/2.6_-_X86_64/Platform/CairoApi.Interop.bmlg">x64</a>
    * <a href="http://bamelg.com/source/modules/Zlib/Platform/Linux/2.6/Platform/ZlibApi.bmlg">Zlib</a> bindings <a href="http://bamelg.com/source/modules/Zlib/Platform/Linux/2.6_-_X86_32/Platform/ZlibApi.Interop.bmlg">x86</a> <a href="http://bamelg.com/source/modules/Zlib/Platform/Linux/2.6_-_X86_64/Platform/ZlibApi.Interop.bmlg">x64</a>
    * <a href="http://bamelg.com/source/modules/X/Platform/Linux/2.6/Platform/XApi.bmlg">X</a> bindings <a href="http://bamelg.com/source/modules/X/Platform/Linux/2.6_-_X86_32/Platform/XApi.Interop.bmlg">x86</a> <a href="http://bamelg.com/source/modules/X/Platform/Linux/2.6_-_X86_64/Platform/XApi.Interop.bmlg">x64</a>
    * <a href="http://bamelg.com/source/modules/BCL/Platform/Linux/2.6/Platform/LibcApi.bmlg">Linux libc API</a> bindings <a href="http://bamelg.com/source/modules/BCL/Platform/Linux/2.6_-_X86_32/Platform/LibcApi.Interop.bmlg">x86</a> <a href="http://bamelg.com/source/modules/BCL/Platform/Linux/2.6_-_X86_64/Platform/LibcApi.Interop.bmlg">x64</a>
    * <a href="http://bamelg.com/source/modules/BCL/Platform/FreeBSD/9.0/Platform/LibcApi.bmlg">FreeBSD libc API</a> bindings <a href="http://bamelg.com/source/modules/BCL/Platform/FreeBSD/9.0_-_X86_32/Platform/LibcApi.Interop.bmlg">x86</a> <a href="http://bamelg.com/source/modules/BCL/Platform/FreeBSD/9.0_-_X86_64/Platform/LibcApi.Interop.bmlg">x64</a>
    * <a href="http://bamelg.com/source/modules/BCL/Platform/Windows/7/Platform/Kernel32Api.bmlg">Windows kernel32 API</a> bindings <a href="http://bamelg.com/source/modules/BCL/Platform/Windows/7_-_X86_32/Platform/Kernel32Api.Interop.bmlg">x86</a> <a href="http://bamelg.com/source/modules/BCL/Platform/Windows/7_-_X86_64/Platform/Kernel32Api.Interop.bmlg">x64</a>
