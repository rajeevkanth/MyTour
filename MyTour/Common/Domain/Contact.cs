using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Contact:DomainBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNumberOne { get; set; }

        public string ContactNumberTwo { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }
    }
}
