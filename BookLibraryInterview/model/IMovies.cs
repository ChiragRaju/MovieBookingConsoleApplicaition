using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingInterview.model
{
    public interface IMovies
    {
        int Id { get; }

        string Name { get; }
        List<string> ShowTimings { get; }

        int SeatsAvailable { get; }
        void DisplayDetails();
        void BookSeat();

        void CancelSeat();


    }
}
