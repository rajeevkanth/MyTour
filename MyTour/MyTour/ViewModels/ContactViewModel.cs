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
        [MaxLength(50)]
        public string Name { get; set; }

        public string Phone { get; set; }
       
        [Required]
        public string Email { get; set; }

       [Required]
       [MaxLength(1500)]
        public string Message { get; set; }

    }
}