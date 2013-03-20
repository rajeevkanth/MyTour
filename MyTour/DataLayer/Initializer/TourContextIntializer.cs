using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace DataLayer.Initializer
{
    public class TourContextIntializer:DropCreateDatabaseIfModelChanges<MyTourContext>
    {
        
        protected override void Seed(MyTourContext context)
        {
            base.Seed(context);
        }
    }
}
