using System;
using Common.Domain;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configurations
{
    public class PlaceConfiguration:EntityTypeConfiguration<Place>
    {
        public PlaceConfiguration()
        {
            ToTable("Place");

            HasRequired(p => p.Suburb).WithMany().HasForeignKey(p => p.SuburbId);

            HasRequired(p => p.State).WithMany().HasForeignKey(p => p.StateId);

            Property(p => p.Name).IsRequired().HasMaxLength(50);

            Property(p => p.Description).IsOptional().HasMaxLength(250);



        }
    }
}
