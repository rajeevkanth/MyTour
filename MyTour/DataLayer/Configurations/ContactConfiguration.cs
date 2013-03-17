using System;
using Common.Domain;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configurations
{
    public class ContactConfiguration:EntityTypeConfiguration<Contact>
    {
        public ContactConfiguration()
        {
            ToTable("Contact");

            Property(p => p.LastName).IsRequired().HasMaxLength(50);

            Property(p => p.FirstName).IsOptional().HasMaxLength(50);

            Property(p => p.Message).IsRequired().HasMaxLength(1500);
        }
    }
}
