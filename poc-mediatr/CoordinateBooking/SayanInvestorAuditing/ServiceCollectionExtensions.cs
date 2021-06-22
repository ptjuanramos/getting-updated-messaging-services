using CoordinateBookingCommon;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace SayanInvestorAuditing
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSayanAuditings(this IServiceCollection services)
        {
            services.AddTransient<INotificationHandler<BatchBookingRequest>, BatchBookingAuditingHandler>();
            services.AddTransient<INotificationHandler<BookingRequest>, SingleBookingAuditingHandler>();
        }
    }
}
