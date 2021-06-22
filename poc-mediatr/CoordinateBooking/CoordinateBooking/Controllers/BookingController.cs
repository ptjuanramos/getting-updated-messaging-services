using CoordinateBooking.Models;
using CoordinateBookingCommon;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoordinateBooking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[controller]/single-book")]
        public async Task<BookingResponseViewModel> SingleBook(BookingViewModel model)
        {
            BookingRequest bookingRequest = (BookingRequest)model;
            BookingResponse bookingResponse = await _mediator.Send(bookingRequest);
            
            await _mediator.Publish(bookingRequest);

            BookingResponseViewModel responseViewModel = (BookingResponseViewModel)bookingResponse;

            return responseViewModel;
        }

        [HttpPost("[controller]/batch-book")]
        public async Task<IEnumerable<BookingResponseViewModel>> BatchBook(BatchBookingViewModel model)
        {
            BatchBookingRequest bookingRequest = (BatchBookingRequest)model;
            BatchBookingResponse bookingResponse = await _mediator.Send(bookingRequest);

            await _mediator.Publish(bookingRequest);

            BatchBookingResponseViewModel responseViewModel = (BatchBookingResponseViewModel)bookingResponse;

            return responseViewModel;
        }
    }
}
