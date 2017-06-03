using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Core.Domain
{
    public class Header
    {
        
        [DataMember(Name = "text")]
        public String Text { get; set; }

        [DataMember(Name = "value")]
        public String Value { get; set; }
    }
}
