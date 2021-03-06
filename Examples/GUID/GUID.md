
GUID Resources, C# Related documentation, other interesting citations, and example code
====

### References
* https://en.wikipedia.org/wiki/Universally_unique_identifier
  * "A universally unique identifier (UUID) is a 128-bit number used to identify information in computer systems. The term globally unique identifier (GUID) is also used. "
* [A brief history of the UUID](https://segment.com/blog/a-brief-history-of-the-uuid/)


* [RFC-4122: A Universally Unique IDentifier (UUID) URN Namespace](https://tools.ietf.org/html/rfc4122)
  * See Section 4.1.3 [(source)](https://social.msdn.microsoft.com/Forums/vstudio/en-US/4956142a-0a5d-4f1e-b102-93a3eea1b5d5/does-guidnewguid-produce-uuid-version-4-according-to-rfc4122?forum=netfxbcl)
    * "The version number is in the most significant 4 bits of the time stamp (bits 4 through 7 of the time_hi_and_version field)." - ?



### Microsoft Documentation
* SQL Server Data Types and ADO.NET [Comparing GUID and uniqueidentifier Values](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql/comparing-guid-and-uniqueidentifier-values)
  * "The globally unique identifier (GUID) data type in SQL Server is represented by the uniqueidentifier data type, which stores a 16-byte binary value. A GUID is a binary number, and its main use is as an identifier that must be unique in a network that has many computers at many sites. GUIDs can be generated by calling the Transact-SQL NEWID function, and is guaranteed to be unique throughout the world."
  * "Because GUIDs values are long and obscure, they are not meaningful for users. ```If randomly generated GUIDs are used for key values and you insert a lot of rows, you get random I/O into your indexes, which can negatively impact performance. GUIDs are also relatively large when compared to other data types. In general we recommend using GUIDs only for very narrow scenarios for which no other data type is suitable.```"

* C# [GUid Struct](https://docs.microsoft.com/en-us/dotnet/api/system.guid?view=netframework-4.7.2)
  * "A GUID is a 128-bit integer (16 bytes) that can be used across all computers and networks wherever a unique identifier is required. Such an identifier has a very low probability of being duplicated."

* C# [Guid.NewGuid Method](https://docs.microsoft.com/en-us/dotnet/api/system.guid.newguid?view=netframework-4.7.2)
  * ```Guid g;```
  * ```g = Guid.NewGuid();```

* C# [GUID Constructors](https://docs.microsoft.com/en-us/dotnet/api/system.guid.-ctor?view=netframework-4.7.2)

* Re: C++: [GUID structure](https://msdn.microsoft.com/en-us/library/aa373931%28VS.85%29.aspx)
  * ```typedef struct _GUID {```
    * ```DWORD Data1;```
    * ```WORD  Data2;```
    * ```WORD  Data3;```
    * ```BYTE  Data4[8];```
  * ```} GUID;```
  * Also see:
    * https://msdn.microsoft.com/en-us/library/windows/desktop/aa373931(v=vs.85).aspx

* Re: C++ [CoCreateGuid function](https://docs.microsoft.com/en-us/windows/desktop/api/combaseapi/nf-combaseapi-cocreateguid)
  * ```HRESULT CoCreateGuid(```
    * ```GUID *pguid```
  * ```);```


* [Marshal.GenerateGuidForType(Type) Method](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.marshal.generateguidfortype?redirectedfrom=MSDN&view=netframework-4.7.2#System_Runtime_InteropServices_Marshal_GenerateGuidForType_System_Type_)
  * "Returns the globally unique identifier (GUID) for the specified type, or generates a GUID using the algorithm used by the Type Library Exporter (Tlbexp.exe)."

* https://docs.microsoft.com/en-us/dotnet/api/system.type.guid?view=netframework-4.7.2
* https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.guidattribute?view=netframework-4.7.2



### Code Examples
* ```System.Guid.NewGuid()```

* ```System.Guid.NewGuid().ToString("B").ToUpper()```
  * https://stackoverflow.com/questions/8477664/how-can-i-generate-uuid-in-c-sharp
    * "...to be compatible with some MS Build tools that can't understand lower case UUIDs" - ?
    * "Be careful: while the string representations for .NET Guid and (RFC4122) UUID are identical, the storage format is not."
      * https://en.wikipedia.org/wiki/Universally_unique_identifier#Binary_encoding
    * "If you are transmitting the bytes (for example, as base64), you can't just use Guid.ToByteArray() and encode it. You'll need to Array.Reverse the first three parts (Data1-3)."
      * https://stackoverflow.com/questions/10190817/guid-byte-order-in-net/10191075#10191075
      * ```var rfc4122bytes = Convert.FromBase64String("aguidthatIgotonthewire==");```
      * ```Array.Reverse(rfc4122bytes,0,4);```
      * ```Array.Reverse(rfc4122bytes,4,2);```
      * ```Array.Reverse(rfc4122bytes,6,2);```
      * ```var guid = new Guid(rfc4122bytes);```

* ```Guid iid = System.Runtime.InteropServices.Marshal.GenerateGuidForType(typeof(IFoo));```

* https://www.cryptosys.net/pki/uuid-rfc4122.html
  * https://www.cryptosys.net/pki/Uuid.cs.html



### Gist Resources
* [Java's Universally Unique Identifier (UUID) implementation in C#](https://gist.github.com/rickbeerendonk/13655dd24ec574954366)



### Github Resources
* TBD...



### GUID Generator Utilities
* https://www.guidgenerator.com/
  * https://tools.ietf.org/html/rfc7515#appendix-C


