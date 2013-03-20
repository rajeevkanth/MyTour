using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace DataLayer.Configurations
{
    public class AddressConfiguration:EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(p => p.StreetAddress1).IsRequired().HasMaxLength(50);

            Property(p => p.StreetAddress2).IsOptional().HasMaxLength(50);

            HasRequired(p => p.Customer).WithMany(p => p.Addresses).HasForeignKey(p => p.CustomerId).WillCascadeOnDelete();

            HasRequired(p => p.Country).WithMany().HasForeignKey(p => p.CountryId);

            HasRequired(p => p.State).WithMany().HasForeignKey(p => p.StateId);
                
            HasRequired(p => p.Suburb).WithMany().HasForeignKey(p => p.SuburbId);
        }

    }
}
