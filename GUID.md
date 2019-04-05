
# Globally Unique Identifiers (GUIDs) Resources, aka Universally Unique IDentifier (UUID)


## References
- https://en.wikipedia.org/wiki/Universally_unique_identifier
  + "In its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 alphanumeric characters and 4 hyphens)"
  + Format: "xxxxxxxx-xxxx-Mxxx-Nxxx-xxxxxxxxxxxx"
    * "The 4 bits of digit M indicate the UUID version, and the 1–3 most significant bits of digit N indicate the UUID variant"
  + Example: "123e4567-e89b-12d3-a456-426655440000"
    * "In the example, M is 1, and N is a (10xx2), meaning that the UUID is a variant-1, version-1 UUID; that is, a time-based DCE/RFC 4122 UUID."

- [RFC-4122 A Universally Unique IDentifier (UUID) URN Namespace](https://tools.ietf.org/rfc/rfc4122.txt)

- [International Telecommunications Union, Object Identifiers (OID) and Registration Authorities Recommendations](https://www.itu.int/ITU-T/studygroups/com17/oid.html)


## Microsoft Documentation
- Microsoft Blogs:
  + [GUIDs are globally unique, but substrings of GUIDs aren't](https://devblogs.microsoft.com/oldnewthing/?p=21823)


- SQL Server 2017
  + ```NEWID()```
    + [NEWID (Transact-SQL)](https://docs.microsoft.com/en-us/sql/t-sql/functions/newid-transact-sql?view=sql-server-2017)
    * "Creates a unique value of type ```uniqueidentifier```"
    * "```NEWID()``` is compliant with [RFC4122](https://tools.ietf.org/html/rfc4122)."


## Articles
-  https://stackoverflow.com/questions/246930/is-there-any-difference-between-a-guid-and-a-uuid
  + 16 byte (128 bits) 
  + "GUID is Microsoft's implementation of the UUID standard. ... The term GUID usually refers to Microsoft's implementation of the Universally Unique Identifier (UUID) standard. An updated quote from that same Wikipedia article: RFC 4122 itself states that UUIDs "are also known as GUIDs"




