using CoordinateBookingCommon;
using System;

namespace CoordinateBooking.Models
{
    public class BookingViewModel
    {
        public Guid Id { get; set; }
        public string BookingReference { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public static explicit operator BookingRequest(BookingViewModel viewModel) 
        {
            return new BookingRequest
            {
                Id = viewModel.Id,
                BookingReference = viewModel.BookingReference,
                Email = viewModel.Email,
                Name = viewModel.Name
            };
        }
    }
}
