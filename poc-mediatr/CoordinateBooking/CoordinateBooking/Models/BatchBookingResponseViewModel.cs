using CoordinateBookingCommon;
using System.Collections.Generic;
using System.Linq;

namespace CoordinateBooking.Models
{
    public class BatchBookingResponseViewModel : List<BookingResponseViewModel>
    {
        public BatchBookingResponseViewModel(IEnumerable<BookingResponseViewModel> bookings) : base(bookings)
        {
        }

        public static explicit operator BatchBookingResponseViewModel(BatchBookingResponse bookingResponses)
        {
            return new BatchBookingResponseViewModel(bookingResponses?.Select(b => (BookingResponseViewModel)b));
        }
    }
}
