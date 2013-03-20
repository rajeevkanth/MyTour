using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Address : DomainBase
    {
        public int CustomerId { get; set; } 
        
        public int CountryId { get; set; }

        public int SuburbId { get; set; }

        public int StateId { get; set; }

        public string StreetAddress1 { get; set; }

        public string StreetAddress2 { get; set; }

        public virtual Suburb Suburb { get; set; }

        public virtual State State { get; set; }

        public virtual Country Country { get; set; }

        public virtual Customer Customer { get; set; }


    }
}
