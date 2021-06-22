using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateBookingCommon
{
    public class BookingResponse
    {
        public Guid Id { get; set; }
        public bool Success { get; set; }
        public decimal Cost { get; set; }
    }
}
