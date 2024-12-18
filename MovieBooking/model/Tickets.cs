using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingInterview.model
{
    public class Tickets
    {
        public int TicketId { get; set; }
        public int MovieId { get; set; }
        public string ShowTime { get; set; }
        public int Total { get; set; }

        public string CustomerName { get; set; }
    }
}
