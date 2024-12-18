
using MovieBookingInterview.Services;


namespace MovieBookingInterview.UI
{

    public class CinemaHall
    {
        private readonly IBookingService _bookingService;
        public CinemaHall(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Movie Ticket System");
                Console.WriteLine("1.View All Movies");
                Console.WriteLine("2.Book Tickets");
                Console.WriteLine("3.Cancel Ticket");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter Your Choice");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        _bookingService.ViewMovies();
                        break;
                    case "2":
                        Console.Write("Enter Movie ID: ");
                        int movieId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Show Time: ");
                        string showTime = Console.ReadLine();
                        Console.Write("Enter Your Name: ");
                        string name = Console.ReadLine();
                        _bookingService.BookTickets(movieId, showTime, name);
                        break;

                    case "3":
                        Console.WriteLine("Enter Ticket Id to cancel");
                        int ticketId = Convert.ToInt32(Console.ReadLine());
                        _bookingService.CancelTickets(ticketId);
                        break;
                    case "4":
                        Console.WriteLine("exiting");
                        return;

                    default:
                        Console.WriteLine("Invalid choice Try Again");
                        break;

                }
            }
        }
    }
}
