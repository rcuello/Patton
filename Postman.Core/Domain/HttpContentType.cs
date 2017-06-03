using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Core.Domain
{
    public class HttpContentType
    {
        public String Name { get; set; }

        public String Value { get; set; }

        public HttpContentType(String name,String value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
