using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Chaffeur: DomainBase 
    {
        public string FisrtName { get; set; }

        public string LastName { get; set; }

        public virtual IList<Phone> Phone { get; set; }

        public virtual IList<Address> Address { get; set; }



    }
}
