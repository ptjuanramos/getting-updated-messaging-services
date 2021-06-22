using Microsoft.Extensions.DependencyInjection;

namespace CoordinateBookingDataAccess
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddTransient<IBookingQuery, BookingQuery>();
            services.AddTransient<IBookingCommand, BookingCommand>();
        }
    }
}
