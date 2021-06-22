using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateBookingCommon
{
    public class NewBookingNotification : INotification
    {
        public string Reference { get; set; }
        public decimal Cost { get; set; }
    }
}
