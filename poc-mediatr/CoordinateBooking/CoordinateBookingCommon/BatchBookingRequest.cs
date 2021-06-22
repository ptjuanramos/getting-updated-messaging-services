using MediatR;
using System.Collections.Generic;
using System.Text.Json;

namespace CoordinateBookingCommon
{
    public class BatchBookingRequest : List<BookingRequest>, IRequest<BatchBookingResponse>, INotification
    {

        public BatchBookingRequest(IEnumerable<BookingRequest> bookings) : base(bookings)
        {

        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
