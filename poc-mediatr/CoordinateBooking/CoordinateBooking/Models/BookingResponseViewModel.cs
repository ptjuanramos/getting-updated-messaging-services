using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoordinateBooking.Models
{
    public class BookingResponseViewModel
    {
        public Guid Id { get; set; }
        public bool Success { get; set; }
        public decimal Cost { get; set; }
    }
}
