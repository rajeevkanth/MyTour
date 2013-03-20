using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Trip: DomainBase
    {
        public virtual Booking Booking { get; set; }

        public int BookingId { get; set; }

        public int? ChaffeurId { get; set; }

        public virtual Chaffeur Chaffeur { get; set; }

        public int? VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public DateTime? TripDate { get; set; }

        public int PlaceId { get; set; }

        public virtual Place Place { get; set; }

        public double DistanceCovered { get; set; }

        public string SpecialInstructions { get; set; }

        
    }
}
