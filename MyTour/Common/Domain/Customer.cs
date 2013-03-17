using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Customer:DomainBase
    {
        public Customer()
        {
            Bookings = new List<Booking>();
            Phones = new List<Phone>();
            Addresses = new List<Address>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? CustomerSince { get; set; }
        public string Email { get; set; }

        public virtual IList<Booking> Bookings { get; set; }
        public virtual IList<Phone> Phones { get; set; } 
        public virtual Royalty Royalty { get; set; }
        public virtual IList<Address> Addresses { get; set; }
    }
}
