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
        public Booking Create(Booking booking);
        public IEnumerable<Booking> BatchCreate(IReadOnlyCollection<Booking> bookings);
    }
}
