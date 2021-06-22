using System;
using System.Text.Json;

namespace CoordinateBookingDataAccess.Models
{
    public record Booking(Guid Id, decimal Cost, string Reference, string Name, string Email)
    {
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
