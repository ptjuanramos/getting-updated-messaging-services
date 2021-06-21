using System;

namespace CoordinateBooking.Models
{
    public class BookingViewModel
    {
        public Guid Id { get; set; }
        public string BookingReference { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
