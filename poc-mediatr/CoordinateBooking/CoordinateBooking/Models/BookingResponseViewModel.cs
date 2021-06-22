using CoordinateBookingCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoordinateBooking.Models
{
    public class BookingResponseViewModel
    {
        public Guid Id { get; set; }
        public bool Success { get; set; }
        public decimal Cost { get; set; }

        public static explicit operator BookingResponseViewModel(BookingResponse bookingResponse)
        {
            return new BookingResponseViewModel
            {
                Id = bookingResponse.Id,
                Cost = bookingResponse.Cost,
                Success = bookingResponse.Success
            };
        }
    }
}
