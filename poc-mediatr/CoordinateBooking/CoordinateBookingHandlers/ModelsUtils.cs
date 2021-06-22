using CoordinateBookingCommon;
using CoordinateBookingDataAccess.Models;

namespace CoordinateBookingHandlers
{
    internal static class ModelsUtils
    {
        public static Booking CreateBookingModel(BookingRequest bookingRequest, decimal cost)
        {
            return new Booking(bookingRequest.Id, cost, bookingRequest.BookingReference, bookingRequest.Name, bookingRequest.Email);
        }
    }
}
