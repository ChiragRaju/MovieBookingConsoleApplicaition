using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingInterview.model
{
    public class Movies : IMovies
    {
        public int Id { get; private set; }

        public string Name { get; private set; } = string.Empty;
        public List<string> ShowTimings { get; private set; }
        public int SeatsAvailable { get; set; }


        public Movies(int id, string name, List<string> showtimings, int seatsAvailable)
        {
            Id = id;
            Name = name;
            ShowTimings = showtimings;
            SeatsAvailable = seatsAvailable;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Movie ID: {Id}, Name: {Name}, Seats Available: {SeatsAvailable}");
            Console.WriteLine($"Show Time{string.Join(",", ShowTimings)}");
        }

        public void BookSeat()
        {
            if (SeatsAvailable > 0)
            {
                SeatsAvailable--;
            }

        }
        public void CancelSeat()
        {
            SeatsAvailable++;
        }
    }
}
