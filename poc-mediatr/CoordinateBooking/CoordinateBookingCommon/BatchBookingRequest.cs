using MediatR;
using System.Collections.Generic;
using System.Text.Json;

namespace CoordinateBookingCommon
{
    public class BatchBookingRequest : List<BookingRequest>, IRequest
    {
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
