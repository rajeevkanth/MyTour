using System;
using System.Data.Entity.ModelConfiguration;
using Common.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configurations
{
    public class RoyaltyConfiguration:EntityTypeConfiguration<Royalty>
    {
        public RoyaltyConfiguration()
        {
            Property(p => p.MemberSince).IsRequired();

            HasRequired(p => p.Customer).WithOptional(p => p.Royalty);
        }
    }
}
