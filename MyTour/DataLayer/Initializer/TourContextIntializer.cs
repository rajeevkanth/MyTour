using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Initializer
{
    public class TourContextIntializer:DropCreateDatabaseAlways<MyTourContext>
    {
        
        protected override void Seed(MyTourContext context)
        {
            
            base.Seed(context);
        }
    }
}
