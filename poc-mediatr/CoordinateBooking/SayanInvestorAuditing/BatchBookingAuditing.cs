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
    public class BatchBookingAuditing : RequestHandler<BatchBookingRequest>
    {
        private readonly ILogger<BatchBookingAuditing> _logger;

        public BatchBookingAuditing(ILogger<BatchBookingAuditing> logger)
        {
            _logger = logger;
        }

        protected override void Handle(BatchBookingRequest request)
        {
            _logger.LogInformation($"[Sayan Investor INC]: {request}");
        }
    }
}
