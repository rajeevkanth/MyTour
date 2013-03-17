using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace DataLayer.Configurations
{
    public class CustomerConfiguration: EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            ToTable("Customer");

            Property(p => p.FirstName).HasMaxLength(50);

            Property(p => p.LastName).IsRequired().HasMaxLength(50);

            Property(p => p.DateOfBirth).IsOptional();

            Property(p => p.Email).IsRequired();
        }
    }
}
