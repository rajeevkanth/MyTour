using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace DataLayer.Configurations
{
    public class BookingConfiguration:EntityTypeConfiguration<Booking>
    {
        public BookingConfiguration()
        {
            ToTable("Booking");

            Property(p => p.BookingDate).IsRequired();

            HasRequired(p => p.Customer).WithMany(p => p.Bookings).HasForeignKey(p => p.CustomerId).WillCascadeOnDelete();
        }
    }
}
