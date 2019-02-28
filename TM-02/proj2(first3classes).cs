using System;
using System.Collections.Generic;

namespace MovieTicketBooking
{
    class Movie
    {
        private int MovieID;
        private string MovieName;
        private string Director;
        private string Producer;
        private string Cast;

        private double Duration;
        private string Story;
        private string Type;

        public Movie(Random rand1, string a, string b, string c, string d, double e, string f, string g)
        {
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
            private int TheatreID;
            private string TheatreName;
            private string CityName;
            private string Address;
            private int NoOfScreens;
            private List<int> Screens;

            public Theatre(Random rand2, string a, string b, string c, int d, List<int> e)
            {
                TheatreID = rand2.Next();

                TheatreName = a;
                CityName = b;
                Address = c;
                NoOfScreens = d;
                Screens = e;

            }
            public void DisplayTheatreDetails()
            {
                Console.WriteLine("details of the movie:");
                Console.WriteLine("TheatreID={0}\nTheatreName={1}\nCityName={2}\nAddress={3}\nNoOfScreens={4}", TheatreID, TheatreName, CityName, Address, NoOfScreens);
                for (int i = 1; i <= NoOfScreens; i++)
                {
                    Screens.Add(i);
                    Console.WriteLine("screen no.{0}:{1}", i, i);
                }
            }
            /*class Screen
            {
                private int ScreenID;
                
                private SortedList<int, string> Seats ;

                public Screen()
                {
                    ScreenID = 1000;
                    SortedList<int, string> Seats = new SortedList<int, string>();
                    while (ScreenID < 1005)
                    {
                        for (int i = 1; i <= 50; i++)
                        {
                            Seats.Add(i, "V");
                        }
                        ScreenID++;
                    }

                }

                public void DisplayScreenDetails()
                {
                    
                    Console.WriteLine("details of the screen and corresponding seats:");
                    while (ScreenID < 1005)
                    {
                        Console.WriteLine("screen id:{0}\n", ScreenID);
                        {
                            for (int i = 1; i <= 50; i++)
                            {
                                Console.WriteLine("seat no.:{0},status:{1}",i,"V");
                            }
                        }
                        ScreenID++;
                    }
                }*/
                static void Main()
                {

                    Console.WriteLine("enter the details of the movie");
                    Random rand1 = new Random();
                    Random rand2 = new Random();
                    string MovieName1 = Console.ReadLine();
                    string Director1 = Console.ReadLine();
                    string Producer1 = Console.ReadLine();
                    string Cast1 = Console.ReadLine();
                    double Duration1 = double.Parse(Console.ReadLine());
                    string Story1 = Console.ReadLine();
                    string Type1 = Console.ReadLine();

                    Movie m = new Movie(rand1, MovieName1, Director1, Producer1, Cast1, Duration1, Story1, Type1);



                    Console.WriteLine("enter the details of the theatre");
                    string TheatreName1 = Console.ReadLine();
                    string CityName1 = Console.ReadLine();
                    string Address1 = Console.ReadLine();

                    int NoOfScreens1 = int.Parse(Console.ReadLine());
                    List<int> Screens1 = new List<int>();

                    Theatre t = new Theatre(rand2, TheatreName1, CityName1, Address1, NoOfScreens1, Screens1);

                    m.DisplayMovieDetails();
                    t.DisplayTheatreDetails();
                    /*SortedList<int, string> Seats1 = new SortedList<int, string>();
                    Screen s = new Screen();
                    s.DisplayScreenDetails();*/


                    Console.ReadKey();
                }
            }
        }
    }




