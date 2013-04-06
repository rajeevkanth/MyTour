using System;
using DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProviderLayer.Interface;

namespace ProviderLayer.Implementation
{
    public class TourProvider:ITourProvider
    {
        protected MyTourContext _context;

        public TourProvider(MyTourContext context)
        {
            _context = context;
        }

        public IList<Common.Domain.Place> GetAllPlaces()
        {
            return _context.GetAllPlaces();
        }

        public void AddBooking(Common.Domain.Booking booking)
        {
            _context.AddBooking(booking);
        }

        public bool AddContactInfo(Common.Domain.Contact contact)
        {
            return _context.AddContactInfo(contact);
        }
    }
}
