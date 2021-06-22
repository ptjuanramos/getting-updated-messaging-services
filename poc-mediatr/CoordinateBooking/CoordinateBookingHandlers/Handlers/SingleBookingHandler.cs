using CoordinateBookingCommon;
using CoordinateBookingDataAccess;
using CoordinateBookingDataAccess.Models;
using CoordinateBookingHandlers;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace CoordinateBooking.Handlers
{
    public class SingleBookingHandler : IRequestHandler<BookingRequest, BookingResponse>
    {
        private readonly IBookingCommand _bookingCommand;
        private readonly ILogger<SingleBookingHandler> _logger;

        public SingleBookingHandler(IBookingCommand bookingCommand, ILogger<SingleBookingHandler> logger)
        {
            _bookingCommand = bookingCommand;
            _logger = logger;
        }

        public async Task<BookingResponse> Handle(BookingRequest request, CancellationToken cancellationToken)
        {
            Booking createdBooking = await _bookingCommand.CreateAsync(ModelsUtils.CreateBookingModel(request, 10));

            _logger.LogInformation($"[Coordinated booking] new booking was created {createdBooking}");

            return new BookingResponse
            {
                Id = createdBooking.Id,
                Cost = createdBooking.Cost,
                Success = true
            };
        }
    }
}
