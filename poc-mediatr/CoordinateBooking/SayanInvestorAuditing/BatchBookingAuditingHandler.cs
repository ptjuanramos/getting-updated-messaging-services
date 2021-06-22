using CoordinateBookingCommon;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayanInvestorAuditing
{
    public class BatchBookingAuditingHandler : NotificationHandler<BatchBookingRequest>
    {
        private readonly ILogger<BatchBookingAuditingHandler> _logger;

        public BatchBookingAuditingHandler(ILogger<BatchBookingAuditingHandler> logger)
        {
            _logger = logger;
        }

        protected override void Handle(BatchBookingRequest request)
        {
            _logger.LogInformation($"[Sayan Investor INC]: {request}");
        }
    }
}
