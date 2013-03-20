using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Booking:DomainBase
    {
        public  virtual Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public virtual IList<Trip> Trips { get; set; }

        public bool ContinueAsGuest { get; set; }

        public DateTime BookingDate { get; set; }

        public bool IsActive { get; set; }
    }
}
