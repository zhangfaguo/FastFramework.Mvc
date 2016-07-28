using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFramework.Services.Mains.Contracts.Models
{
    public class MessageObject
    {
        public int MessageType { get; set; }

        public string CodeInfo { get; set; }

        public dynamic Data { get; set; }

        public string Mark { get; set; }


    }
}
