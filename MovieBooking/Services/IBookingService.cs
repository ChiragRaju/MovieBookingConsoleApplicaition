using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingInterview.Services
{
    public interface IBookingService
    {
        void ViewMovies();
        void BookTickets(int MovieId, string showTime, string CustomerName);
        void CancelTickets(int TicketId);
    }
}
