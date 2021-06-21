using CoordinateBookingDataAccess;
using CoordinateBookingHandlers;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoordinateBooking.Handlers
{
    public class SingleBookingHandler : IRequestHandler<BookingRequest>
    {
        private readonly IBookingCommand _bookingCommand;

        public SingleBookingHandler(IBookingCommand bookingCommand)
        {
            _bookingCommand = bookingCommand;
        }

        public Task<Unit> Handle(BookingRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
