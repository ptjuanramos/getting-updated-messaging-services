using CoordinateBookingCommon;
using CoordinateBookingDataAccess;
using CoordinateBookingDataAccess.Models;
using CoordinateBookingHandlers;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace CoordinateBooking.Handlers
{
    public class BatchBookingsHandler : IRequestHandler<BatchBookingRequest, BatchBookingResponse>
    {
        private readonly IBookingCommand _bookingCommand;
        private readonly ILogger<BatchBookingsHandler> _logger;

        public BatchBookingsHandler(IBookingCommand bookingCommand, ILogger<BatchBookingsHandler> logger)
        {
            _bookingCommand = bookingCommand;
            _logger = logger;
        }

        public async Task<BatchBookingResponse> Handle(BatchBookingRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Booking> models = request?.Select(b => ModelsUtils.CreateBookingModel(b, 10));
            IEnumerable<Booking> createdBookings = await _bookingCommand.BatchCreateAsync(models?.ToList().AsReadOnly());

            _logger.LogInformation($"[Coordinated booking] new bookings were created {JsonSerializer.Serialize(createdBookings)}");

            IEnumerable<BookingResponse> resultBookings = createdBookings.Select(rb => new BookingResponse
            {
                Id = rb.Id,
                Cost = 10,
                Success = true
            });

            return new BatchBookingResponse(resultBookings);
        }
    }
}
