using CoordinateBookingCommon;
using MediatR;
using Microsoft.Extensions.Logging;

namespace SayanInvestorAuditing
{
    public class SingleBookingAuditingHandler : RequestHandler<BookingRequest>
    {
        private readonly ILogger<SingleBookingAuditingHandler> _logger;

        public SingleBookingAuditingHandler(ILogger<SingleBookingAuditingHandler> logger)
        {
            _logger = logger;
        }

        protected override void Handle(BookingRequest request)
        {
            _logger.LogInformation($"[Sayan Investor INC]: {request}");
        }
    }
}
