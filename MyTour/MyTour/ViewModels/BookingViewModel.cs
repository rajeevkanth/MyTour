using System;
using System.ComponentModel.DataAnnotations;


namespace MyTour.ViewModels
{
    public class BookingViewModel
    {
        public BookingViewModel()
        {
            BookingDate = null;
        }

        [Required]
        public DateTime? BookingDate { get; set; }

        public String Adults { get; set; }

        public String Children { get; set; }
    }
}