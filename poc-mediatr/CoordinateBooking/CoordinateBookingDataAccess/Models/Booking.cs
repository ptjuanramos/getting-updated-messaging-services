using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateBookingDataAccess.Models
{
    public record Booking(Guid Id, string Reference, string Name, string Email)
    {
    }
}
