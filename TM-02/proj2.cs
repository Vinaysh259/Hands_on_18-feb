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
                   
                    Console.WriteLine("screen no:{0}", Screens[i]);
                }
            }
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
                    {
                        for (int i = 1; i <= 50; i++)
                        {
                            string str = Seats[i];
                            Console.WriteLine("seat no.:{0},status:{1}", i, str);
                        }

                    }
                }

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



                    Console.WriteLine("enter the details of the theatre");
                    string TheatreName1 = Console.ReadLine();
                    string CityName1 = Console.ReadLine();
                    string Address1 = Console.ReadLine();

                    int NoOfScreens1 = int.Parse(Console.ReadLine());
                    

                    Theatre t = new Theatre(TheatreName1, CityName1, Address1, NoOfScreens1);

                    m.DisplayMovieDetails();
                    t.DisplayTheatreDetails();
                    
                    Screen s = new Screen();
                    s.DisplayScreenDetails();


                    Console.ReadKey();
                }
            }
        }
    }
}




