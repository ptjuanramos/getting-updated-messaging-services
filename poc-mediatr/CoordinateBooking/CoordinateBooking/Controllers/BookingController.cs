using CoordinateBooking.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoordinateBooking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        [HttpPost("[controller]/single-book")]
        public BookingResponseViewModel SingleBook(BookingViewModel model)
        {
            return null;
        }

        [HttpPost("[controller]/batch-book")]
        public IEnumerable<BookingResponseViewModel> BatchBook(IEnumerable<BookingViewModel> models)
        {
            return null;
        }
    }
}
