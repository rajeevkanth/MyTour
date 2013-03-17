using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Place:DomainBase
    {
        public int SuburbId { get; set; }

        public int StateId { get; set; }

        public Suburb Suburb { get; set; }

        public State State { get; set; }

       // public virtual Place[] AttractionsNearBy { get; set; }

        public byte[] Pictures { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Type { get; set; }
    }
}
