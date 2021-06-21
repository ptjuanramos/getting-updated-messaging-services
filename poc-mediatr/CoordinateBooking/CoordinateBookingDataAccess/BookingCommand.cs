using CoordinateBookingDataAccess.Models;
using System;
using System.Collections.Generic;

namespace CoordinateBookingDataAccess
{
    internal class BookingCommand : IBookingCommand
    {
        public IEnumerable<Booking> BatchCreate(IReadOnlyCollection<Booking> bookings)
        {
            throw new NotImplementedException();
        }

        public Booking Create(Booking booking)
        {
            throw new NotImplementedException();
        }
    }
}
