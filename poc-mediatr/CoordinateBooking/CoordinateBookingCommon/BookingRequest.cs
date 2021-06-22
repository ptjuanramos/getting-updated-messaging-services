using MediatR;
using System;
using System.Text.Json;

namespace CoordinateBookingCommon
{
    public class BookingRequest : IRequest
    {
        public Guid Id { get; set; }
        public string BookingReference { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
