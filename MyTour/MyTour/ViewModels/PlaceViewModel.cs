using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTour.ViewModels
{
    public class PlaceViewModel
    {
        public IList<byte[]> Images { get; set; }

        public string Name { get; set; }
    }
}