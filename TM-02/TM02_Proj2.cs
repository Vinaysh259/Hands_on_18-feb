using System;
using System.Collections.Generic;

namespace MovieTicketBooking
{
    class Movie
    {
        private int MovieID { get; set; }
        private string MovieName { get; set; }
        private string Director { get; set; }
        private string Producer { get; set; }
        private string Cast { get; set; }

        private double Duration { get; set; }
        private string Story { get; set; }
        private string Type { get; set; }



        public Movie(string a = "DDLJ", string b = "Yash Chopra", string c = "Rohit Shetty", string d = "SRK", double e = 1.5, string f = "love", string g = "upcoming")
        {
            Random rand1 = new Random();
            MovieID = rand1.Next();

            MovieName = a;
            Director = b;
            Producer = c;
            Cast = d;
            Duration = e;
            Story = f;
            Type = g;
        }


        public void DisplayMovieDetails()
        {
            Console.WriteLine("details of the movie:");
            Console.WriteLine("MovieID={0}\nMovieName={1}\nDirector={2}\nProducer={3}\nCast={4}\nDuration={5}\nStory={6}\nType={7}", MovieID, MovieName, Director, Producer, Cast, Duration, Story, Type);
        }
    }

    class Theatre
    {
        private int TheatreID { get; set; }
        private string TheatreName { get; set; }
        private string CityName { get; set; }
        private string Address { get; set; }
        private int NoOfScreens { get; set; }
        private List<int> Screens { get; set; }


        public Theatre(string a = "INOX", string b = "Ranchi", string c = "XYZ", int d = 5)
        {
            Random rand2 = new Random();
            TheatreID = rand2.Next();

            TheatreName = a;
            CityName = b;
            Address = c;
            NoOfScreens = d;
            List<int> Screens = new List<int>();

            for (int i = 1; i <= NoOfScreens; i++)
            {
                Screens.Add(i);

            }


        }

    
        public void DisplayTheatreDetails()
        {
            Console.WriteLine("details of the movie:");
            Console.WriteLine("TheatreID={0}\nTheatreName={1}\nCityName={2}\nAddress={3}\nNoOfScreens={4}", TheatreID, TheatreName, CityName, Address, NoOfScreens);
            for (int i = 1; i <= NoOfScreens; i++)
            {

                Console.WriteLine("screen no:{0}", i);
            }
        }
    }

    public class Screen
    {
        int screenID;
        SortedList seats;

        public Screen() { }
        public Screen(int id)
        {
            screenID = id;
            seats = new SortedList();
            for (int i = 0; i < 5; i++)
            {                  // ** change 5 to 50 in the end
                seats.Add((i + 1), "Vacant");
            }
        }

        public int getScreenID() => screenID;
        public SortedList getSeats() => seats;

        public void bookSeat(int seatNum)
        {
            // seats.Remove(seatNum);
            // seats.Add(seatNum, "Reserved");
            seats[seatNum] = "Reserved";
        }
        public void showSeats()
        {
            Console.WriteLine("\nScreenID : {0}", screenID);
            ICollection key = seats.Keys;
            foreach (int k in key)
            {
                Console.WriteLine("Seat #{0} : {1} ", k, seats[k]);
            }
        }
    }


    /*

        class Screen
        {
            private int ScreenID;

            private SortedList<int, string> Seats;

            public Screen()
            {
                ScreenID = 1000;
                SortedList<int, string> Seats = new SortedList<int, string>();

                for (int i = 1; i <= 50; i++)
                {
                    Seats.Add(i, "Vacant");
                }


            }



            public void DisplayScreenDetails()
            {

                Console.WriteLine("details of the screen and corresponding seats:");

                Console.WriteLine("screen id:{0}\n", ScreenID);

                for (int i = 1; i <= 50; i++)
                {
                    //string str = Seats[i];
                    Console.WriteLine("seat no.:{0},status:{1}", i, 'v');
                }


            }
        }
        */

    class Show
    {
        private int ShowID { get; set; }
        private int MovieID { get; set; }
        private int TheatreID { get; set; }
        private int ScreenID { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        static public decimal PlatinumSeatRate { get; set; }
        static public decimal GoldSeatRate { get; set; }
        static public decimal SilverSeatRate { get; set; }

        public Show(DateTime s_date, DateTime e_date, int m_id = 1, int t_id = 1, int sc_id = 1, decimal p_rate = 400, decimal g_rate = 250, decimal s_rate = 150)
        {
            Random rand1 = new Random();
            ShowID = rand1.Next();

            if (m_id > 0)
                MovieID = m_id;
            else
                throw new Exception("MovieID cannot be negative");
            if (t_id > 0)
                TheatreID = t_id;
            else
                throw new Exception("TheatreID cannot be negative");
            if (sc_id > 0)
                ScreenID = sc_id;
            else
                throw new Exception("ScreenID cannot be negative");

            StartDate = s_date;
            EndDate = e_date;

            PlatinumSeatRate = p_rate;
            GoldSeatRate = g_rate;
            SilverSeatRate = s_rate;
        }


        public void DisplayShowDetails()
        {
            Console.WriteLine("Details of the Show :");
            Console.WriteLine("ShowID :{0}\n" +
                "MovieID :{1}\n" +
                "TheatreID :{2}\n" +
                "ScreenID{3} :\n" +
                "StartDate{4} :\n" +
                "EndDate{5} :\n" +
                "PlatinumSeatRate{6} :\n" +
                "GoldSeatRate{7} :\n" +
                "SilverSeatRate{8} :", ShowID, MovieID, TheatreID, ScreenID, StartDate, EndDate, PlatinumSeatRate, GoldSeatRate, SilverSeatRate);
        }
    }



    public class User
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private string UserType { get; set; }

        public User(string u_name = "AAA", string pwd = "12345678", string u_type = "ADMIN")
        {
            UserName = u_name;
            Password = pwd;

            UserType = u_type;
        }
    }



    public class Booking
    {
        int bookingID;
        DateTime bookingDate;
        int showID;
        string customerName;
        int numberOfSeats;
        string seatType;
        decimal amount;
        string email;
        string bookingStatus;
        List<int> seatNumbers;

        public Booking()
        {

        }
        public Booking(int showID, string customerName, int numberOfSeats, string seatType, string email)
        {
            Random rand = new Random();
            this.bookingID = rand.Next();
            this.bookingDate = DateTime.Today;
            this.showID = showID;
            this.customerName = customerName;
            this.numberOfSeats = numberOfSeats;
            this.seatType = seatType;
            this.email = email;
        }

        public void amountToBePaid(Show[] shows, Theatre[] theatres)
        {
            int movieID, screenID, theatreID, count = 0;
            decimal rate = 0, totalAmount = 0;
            foreach (Show show in shows)
            {
                if (show.getShowID() == showID)
                {
                    movieID = show.getMovieID();
                    screenID = show.getScreenID();
                    theatreID = show.getTheatreID();
                    switch (seatType)
                    {
                        case "Platinum":
                            rate = show.getPlatinumSeatRate();
                            break;
                        case "Gold":
                            rate = show.getGoldSeatRate();
                            break;
                        case "Silver":
                            rate = show.getSilverSeatRate();
                            break;
                    }

                    // find out the theatre
                    foreach (Theatre theatre in theatres)
                    {
                        if (theatre.getTheatreID() == theatreID)
                        {
                            List<Screen> screens = theatre.getAllScreens();
                            // find out the screen
                            foreach (Screen screen in screens)
                            {
                                if (screen.getScreenID() == screenID)
                                {
                                    SortedList seats = screen.getSeats();
                                    foreach (int k in seats)
                                    {
                                        if (String.Equals(seats[k], "Vacant"))
                                        {
                                            count++;
                                            screen.bookSeat(k);
                                            seatNumbers.Add(k);
                                        }
                                        if (count == numberOfSeats)
                                        {
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    }

                    totalAmount = count * rate;

                    break;
                }
            }

            Console.Write("\n\n");
            foreach (int seat in seatNumbers)
            {
                Console.Write("{0} ", seat);
            }
            Console.WriteLine("\n\nTotal Amount: {0}", totalAmount);
        }
    }
    /*
    class Booking
    {
        private int BookingID { get; set; }
        private DateTime BookingDate { get; set; }
        private int ShowID { get; set; }
        private string CustomerName { get; set; }
        private int NumberOfSeats { get; set; }
        private string SeatType { get; set; }
        private decimal Amouont { get; set; }
        private string Email { get; set; }
        private string BookingStatus { get; set; }
        private List<int> SeatNumbers { get; set; }



        public Booking(int s_id, string c_name, int no_seats, string s_type, string e_id)
        {
            ShowID = s_id;
            CustomerName = c_name;

            if (no_seats < 5)
                NumberOfSeats = no_seats;
            else
                throw new Exception("You cannot book more than 4 tickets");

            SeatType = s_type;
            Email = e_id;
            BookingID = 1000;        //Default value
            if (s_type == "Platinum")
                Amouont = no_seats * Show.PlatinumSeatRate;
            else if (s_type == "Gold")
                Amouont = no_seats * Show.GoldSeatRate;
            else
                Amouont = no_seats * Show.SilverSeatRate;
        }

    }
    */

    class Test
    {
        static void Main()
        {

            Console.WriteLine("enter the details of the movie");

            string MovieName1 = Console.ReadLine();
            string Director1 = Console.ReadLine();
            string Producer1 = Console.ReadLine();
            string Cast1 = Console.ReadLine();
            double Duration1 = double.Parse(Console.ReadLine());
            string Story1 = Console.ReadLine();
            string Type1 = Console.ReadLine();

            Movie m = new Movie(MovieName1, Director1, Producer1, Cast1, Duration1, Story1, Type1);
            m.DisplayMovieDetails();


            Console.WriteLine("enter the details of the theatre");
            string TheatreName1 = Console.ReadLine();
            string CityName1 = Console.ReadLine();
            string Address1 = Console.ReadLine();

            int NoOfScreens1 = int.Parse(Console.ReadLine());


            Theatre t = new Theatre(TheatreName1, CityName1, Address1, NoOfScreens1);

         
            t.DisplayTheatreDetails();

            Console.WriteLine("enter the screen id");
            int id1 = int.Parse(Console.ReadLine());
            Screen s = new Screen(id1);
            Console.WriteLine("Information about the Screen :");
            s.showSeats();


            Console.WriteLine("Enter the details about show :");
            int m_id = int.Parse(Console.ReadLine());
            int t_id = int.Parse(Console.ReadLine());
            int sc_id = int.Parse(Console.ReadLine());

            DateTime s_date = DateTime.Parse(Console.ReadLine());
            DateTime e_date = DateTime.Parse(Console.ReadLine());
            decimal p_rate = decimal.Parse(Console.ReadLine());
            decimal g_rate = decimal.Parse(Console.ReadLine());
            decimal s_rate = decimal.Parse(Console.ReadLine());

            Show show1 = new Show(s_date, e_date, m_id, t_id, sc_id, p_rate, g_rate, s_rate);
            show1.DisplayShowDetails();

             User user1 = new User();
              Console.WriteLine("User Name:{0}" +
            "User Password {1}" +
            "User Type {2}", user1.UserName, user1.Password, user1.UserType);


            Booking b = new Booking(showID, customerName, numberOfSeats, seatType, email);
            b.amountToBePaid(shows, theatres);
            Console.ReadKey();

        }

    }
}

