using MovieBookingInterview.model;
using MovieBookingInterview.Services;
using MovieBookingInterview.UI;

class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Clear(); // Apply the background color change across the screen.

        Console.WriteLine("**********************************");
        Console.WriteLine("     Movie Ticket Booking System   ");
        Console.WriteLine("**********************************");
        // Initialize movie data
        var movies = new List<IMovies>
        {
            new Movies(1, "Avatar", new List<string> { "10:00 AM", "2:00 PM", "6:00 PM" }, 5),
            new Movies(2, "Inception", new List<string> { "11:00 AM", "3:00 PM", "7:00 PM" }, 3),
            new Movies(3, "Titanic", new List<string> { "12:00 PM", "4:00 PM", "8:00 PM" }, 4)
        };

        IBookingService bookingService = new BookService(movies);
        var cinemaHall = new CinemaHall(bookingService);

       
        cinemaHall.Run();
    }
}




