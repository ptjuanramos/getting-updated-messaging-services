using CoordinateBookingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoordinateBookingDataAccess
{
    internal class BookingCommand : IBookingCommand
    {
        public Task<IEnumerable<Booking>> BatchCreateAsync(IReadOnlyCollection<Booking> bookings)
        {
            return Task.FromResult(bookings.AsEnumerable());
        }

        Task<Booking> IBookingCommand.CreateAsync(Booking booking)
        {
            return Task.FromResult(booking);
        }
    }
}
