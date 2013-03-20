using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Phone:DomainBase
    {
        public virtual Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public string Number { get; set; }

        public int PhoneType { get; set; }

        public bool IsPreferred { get; set; }
    }
}
