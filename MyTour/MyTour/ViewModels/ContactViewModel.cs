using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTour.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNumberOne { get; set; }

        public string ContactNumberTwo { get; set; }
       
        [Required]
        public string Email { get; set; }

       [Required]
        public string Message { get; set; }

    }
}