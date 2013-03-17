using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using DataLayer.Configurations;

namespace DataLayer
{
    public class MyTourContext :DbContext
    {
        public MyTourContext():base("name=TourismContext")
        {
            
        }

        #region DbSet
        public DbSet<Customer> Customer { get; set; }
        
        public DbSet<Booking> Booking { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Chaffeur> Chaffeur { get; set; }

        public DbSet<Country> Country { get; set; }

        public DbSet<Phone> Phone { get; set; }

        public DbSet<Place> Place { get; set; }

        public DbSet<Royalty> Royalty { get; set; }

        public DbSet<State> State { get; set; }

        public DbSet<Suburb> Suburb { get; set; }

        public DbSet<Trip> Trip { get; set; }

        public DbSet<Vehicle> Vehicle { get; set; }

        public DbSet<Contact> Contact { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new BookingConfiguration());
            modelBuilder.Configurations.Add(new ContactConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new PhoneConfiguration());
            modelBuilder.Configurations.Add(new PlaceConfiguration());
            modelBuilder.Configurations.Add(new RoyaltyConfiguration());
            modelBuilder.Configurations.Add(new TripConfiguration());



        }

        public IList<Place> GetAllPlaces()
        {
            return Place.Select(p => p).ToList();
        }

        public void AddContactInfo(Contact contact)
        {
            Contact.Add(contact);
            SaveChanges();
        }

        public void AddBooking(Booking booking)
        {
            Booking.Add(booking);
            SaveChanges();
        }


    }
}
