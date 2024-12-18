using MovieBookingInterview.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingInterview.Services
{
    public class BookService : IBookingService
    {
        private readonly List<IMovies> _movies;
        private readonly List<Tickets> _tickets;
        private int _ticketCounter = 1;
        public BookService(List<IMovies> movies)
        {
            _movies = movies;
            _tickets = new List<Tickets>();
        }
        public void BookTickets(int movieId, string showTime, string CustomerName)
        {
            var movie = _movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
            {
                Console.WriteLine("Invalid Movie Id");
                return;
            }
            if (!movie.ShowTimings.Contains(showTime))
            {
                Console.WriteLine("Invalid show time");
                return;
            }
            if (movie.SeatsAvailable <= 0)
            {
                Console.WriteLine("No Seats Available");
                return;
            }
            var ticket = new Tickets
            {
                TicketId = _ticketCounter++,
                MovieId = movieId,
                ShowTime = showTime,
                CustomerName = CustomerName
            };
            _tickets.Add(ticket);
            movie.BookSeat();
            Console.WriteLine($"Booking Successful! Your Ticket ID is: {ticket.TicketId}");

        }

        public void CancelTickets(int ticketId)
        {
           var ticket=_tickets.FirstOrDefault(x=>x.TicketId == ticketId);
            if (ticket == null)
            {
                Console.WriteLine("Invalid Ticket Id");
            }
            var movie=_movies.FirstOrDefault(x=>x.Id == ticket.MovieId);
            if (movie != null)
            {
                movie.CancelSeat();
            }
            _tickets.Remove(ticket);
            Console.WriteLine("Tickets cancelled successfully");
        }

        public void ViewMovies()
        {
            foreach (var movie in _movies)
            {
                {
                    movie.DisplayDetails();
                }
            }
        }
    }
}
