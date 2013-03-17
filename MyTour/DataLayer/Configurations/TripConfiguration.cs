using System;
using System.Data.Entity.ModelConfiguration;
using Common.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configurations
{
    public class TripConfiguration:EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            ToTable("Trip");

            HasRequired(p => p.Booking).WithMany().HasForeignKey(p => p.BookingId);

            Property(p => p.TripDate).IsRequired();

            Property(p => p.SpecialInstructions).HasMaxLength(100).IsOptional();

            HasOptional(p => p.Chaffeur).WithMany().HasForeignKey(p=>p.ChaffeurId);

            HasOptional(p => p.Vehicle).WithMany().HasForeignKey(p => p.VehicleId);

            HasRequired(p => p.PlacesCovered).WithMany().HasForeignKey(p => p.PlaceId);

        }


    }
}
