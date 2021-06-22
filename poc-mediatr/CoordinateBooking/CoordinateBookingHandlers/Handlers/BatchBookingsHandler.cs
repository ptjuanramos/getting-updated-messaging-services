using CoordinateBookingCommon;
using CoordinateBookingDataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoordinateBooking.Handlers
{
    public class BatchBookingsHandler : IRequestHandler<BatchBookingRequest>
    {
        private readonly IBookingCommand _bookingCommand;

        public BatchBookingsHandler(IBookingCommand bookingCommand)
        {
            _bookingCommand = bookingCommand;
        }

        public Task<Unit> Handle(BatchBookingRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
