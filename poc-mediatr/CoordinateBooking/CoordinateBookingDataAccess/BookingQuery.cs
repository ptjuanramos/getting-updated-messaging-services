using CoordinateBookingDataAccess.Models;
using System;
using System.Collections.Generic;

namespace CoordinateBookingDataAccess
{
    internal class BookingQuery : IBookingQuery
    {
        public Booking Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Booking GetAll(IReadOnlyCollection<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
