using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Vehicle : DomainBase
    {
        public string Description { get; set; }

        public int Seats { get; set; }

        public bool ChildRestraint { get; set; }

        public bool FourWheelDrive { get; set; }

        public byte[] Pictures { get; set; }

    }
}
