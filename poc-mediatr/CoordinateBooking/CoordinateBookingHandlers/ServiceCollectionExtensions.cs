using CoordinateBooking.Handlers;
using CoordinateBookingCommon;
using CoordinateBookingDataAccess;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateBookingHandlers
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBookingHandlers(this IServiceCollection services)
        {
            services.AddDataAccess();

            services.AddTransient<IRequestHandler<BatchBookingRequest, BatchBookingResponse>, BatchBookingsHandler>();
            services.AddTransient<IRequestHandler<BookingRequest, BookingResponse>, SingleBookingHandler>();
        }
    }
}
