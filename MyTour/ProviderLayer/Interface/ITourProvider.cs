using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace ProviderLayer.Interface
{
    public interface ITourProvider
    {
        IList<Place> GetAllPlaces();

        void AddBooking(Booking booking);

        bool AddContactInfo(Contact contact);

    }
}
