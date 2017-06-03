using System;
using System.Runtime.Serialization;

namespace Postman.Core.Domain
{
    public class Attachment
    {
        [DataMember(Name = "fileName")]
        public String FileName { get; set; }

        [DataMember(Name = "mimeType")]
        public String MimeType { get; set; }

        [DataMember(Name = "data")]
        public Byte[] Data { get; set; }
    }
}
