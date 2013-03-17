using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace DataLayer.Configurations
{
    public class PhoneConfiguration:EntityTypeConfiguration<Phone>
    {
        public PhoneConfiguration()
        {
            Property(p => p.Number).IsRequired().HasMaxLength(12);

            Property(p => p.PhoneType).IsRequired();

            HasRequired(p => p.Customer).WithMany(c => c.Phones).HasForeignKey(p => p.CustomerId).WillCascadeOnDelete();
        }
    }
}
