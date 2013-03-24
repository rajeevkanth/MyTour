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

            Property(p => p.Name).IsRequired().HasMaxLength(50);

            Property(p => p.Phone).IsOptional().HasMaxLength(50);

            Property(p => p.Email).IsRequired();

            Property(p => p.Message).IsRequired().HasMaxLength(1500);
        }
    }
}
