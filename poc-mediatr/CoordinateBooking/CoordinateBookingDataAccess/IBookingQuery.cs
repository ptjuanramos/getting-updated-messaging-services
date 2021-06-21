using CoordinateBookingDataAccess.Models;
using System;
using System.Collections.Generic;

namespace CoordinateBookingDataAccess
{
    public interface IBookingQuery
    {
        public Booking Get(Guid id);
        public Booking GetAll(IReadOnlyCollection<Guid> ids);
    }
}