using System;


namespace MovieTicketBooking
{
    class Movie
    {
        private int MovieID;
        private string MovieName;
        private string Director;
        private string Producer;
        private string Cast;
       
        private double Duartion;
        private string Story;
        private string Type;
        public Movie(Random rand)
        {
            MovieID = rand.Next();
        }
        public Movie(string a, string b,string c,string d, double e, string f, string g)
        {
            //MovieID=rand.Next();
            
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
            Console.WriteLine("MovieID={0}\nMovieName={1}\nDirector={2}\nProducer={3}\nCast={4}\nDuration={5}\nStory={6}\nType={7}", MovieID,MovieName,Director,Producer,Cast,Duration,Story,Type);
        }
        static void Main()
        {
            Console.WriteLine("enter the details of the movie");
            Random rand = new Random();
            Movie(rand);
            string MovieName1 = Console.ReadLine();
            string Director1 = Console.ReadLine();
            string Producer1 = Console.ReadLine();
            string Cast1 = Console.ReadLine();
          double Duration1= double.Parse(Console.ReadLine());
            string Story1 = Console.ReadLine();
            string Type1 = Console.ReadLine();

            Movie m = new Movie(MovieName1,Director1,Producer1,Cast1,Duration1,Story1,Type1);


            m.DisplayMovieDetails();
            Console.ReadKey();
        }
    }
}
