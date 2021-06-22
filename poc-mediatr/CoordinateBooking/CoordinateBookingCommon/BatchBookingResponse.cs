using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateBookingCommon
{
    public class BatchBookingResponse : List<BookingResponse>
    {
        public BatchBookingResponse(IEnumerable<BookingResponse> bookings) : base(bookings)
        {

        }
    }
}
