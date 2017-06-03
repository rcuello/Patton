using Postman.Core.Domain;
using Postman.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinPostman.Helper
{
    public class ConfigHelper
    {
        
        public String Host { get; set; }

        
        public String Uri { get; set; }

        
        public String BodyRaw { get; set; }

        public String BodyType { get; set; }

        public Boolean UseXmlSerializer { get; set; }

        public HttpMethodEnum Method { get; set; }

        public HttpContentType BodyContentType { get; set; }


        public List<Header> Headers { get; set; }

        
        public List<Attachment> Attachments { get; set; }

        public List<Variable> Variables { get; set; }
    }
}
