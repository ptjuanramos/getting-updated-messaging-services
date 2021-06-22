using CoordinateBookingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateBookingDataAccess
{
    public interface IBookingCommand
    {
        public Task<Booking> CreateAsync(Booking booking);
        public Task<IEnumerable<Booking>> BatchCreateAsync(IReadOnlyCollection<Booking> bookings);
    }
}
