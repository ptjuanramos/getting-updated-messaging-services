using CoordinateBooking.Models;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace CoordinateBookingCommon
{
    public class BatchBookingViewModel : List<BookingViewModel>
    {
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public static explicit operator BatchBookingRequest(BatchBookingViewModel viewModel)
        {
            return new BatchBookingRequest(viewModel?.Select(b => (BookingRequest)b).ToList());
        }
    }
}
