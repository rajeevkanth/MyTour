using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Royalty : DomainBase
    {
        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public string status { get; set; }

        public float DistanceTravelled { get; set; }

        public DateTime MemberSince { get; set; }
    }
}
