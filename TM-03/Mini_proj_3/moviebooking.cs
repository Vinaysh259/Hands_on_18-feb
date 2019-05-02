using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketBooking;

namespace Mini_proj_3
{
    public interface IAdmin
    {
        bool AddTheatre(Theatre obj);
        bool UpdateTheatre(Theatre obj);
        bool AddMovie(Movie obj);
        bool UpdateMovie(Movie obj);
        bool AddShow(Show obj);
        bool UpdateShow(Show obj);
        bool DeleteShow(Show obj);
        bool AddAgent(User obj);
        List<Theatre> GetAllTheatres();
        List<Movie> GetAllMovies();
        List<Show> GetAllShows();
    }

    namespace Exceptions
    {
        class InvalidScreenCountExcpetion
        {
            public InvalidScreenCountExcpetion()
            {
                throw new Exception("Invalid Screen count. The number of screens shouldn't be less than or equal to zero.");
            }
        }

        class InvalidMovieTypeException
        {
            public InvalidMovieTypeException()
            {
                throw new Exception("Invalid Movie type. Movie type should be either running or upcoming.");
            }
        }
    }

    class Administrator : IAdmin
    {

        // Add this object to the theatres collections of MovieTicketing class
        public bool AddTheatre(Theatre obj)
        {

            if (obj.TheatreID == null || obj.TheatreName == null || obj.CityName == null || obj.Address == null || obj.NoOfScreens == null || obj.Screens == null)
            {
                Console.WriteLine("The theatre details should not be empty");
            }

            else
            {
                obj.DisplayTheatreDetails();
            }

            try
            {
                if (obj.NoOfScreens <= 0)
                {
                    Exceptions.InvalidScreenCountExcpetion n1 = new Exceptions.InvalidScreenCountExcpetion();
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Theatre t1 = obj;

            return true;
        }


        public bool UpdateTheatre(Theatre obj)
        {
            bool flag = false;
            obj.DisplayTheatreDetails();

            Console.WriteLine("What are the Updated details ????");

            string TheatreName1 = Console.ReadLine();
            string CityName1 = Console.ReadLine();
            string Address1 = Console.ReadLine();
            int NoOfScreens1 = int.Parse(Console.ReadLine());

            if (TheatreName1 == null || CityName1 == null || Address1 == null || NoOfScreens1 == null)
            {
                Console.WriteLine("The theatre details should not be empty");
            }

            else
            {
                try
                {
                    if (NoOfScreens1 <= 0)
                    {
                        Exceptions.InvalidScreenCountExcpetion n1 = new Exceptions.InvalidScreenCountExcpetion();
                    }

                    else
                    {
                        obj.TheatreName = TheatreName1;
                        obj.CityName = CityName1;
                        obj.Address = Address1;
                        obj.NoOfScreens = NoOfScreens1;
                        flag = true;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
            }
            return flag;
        }


        //Add new movie to the Movies list collection of MovieTicketing class
        public bool AddMovie(Movie obj)
        {
            if(obj.MovieName == null || obj.Director == null || obj.Producer == null || obj.Story == null || obj.Type == null || obj.Cast == null || obj.Duration == null)
            {
                Console.WriteLine("Movie details should not be empty!!! ");
            }

            try
            {
                if (obj.Type != "Running" || obj.Type != "Upcoming")
                {
                    Exceptions.InvalidMovieTypeException n1 = new Exceptions.InvalidMovieTypeException();
                }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return true;
        }


        public bool UpdateMovie(Movie obj)
        {
            Console.WriteLine("What are the updated movie details???");

            string MovieName1 = Console.ReadLine();
            string Director1 = Console.ReadLine();
            string Producer1 = Console.ReadLine();
            string Cast1 = Console.ReadLine();
            double Duration1 = double.Parse(Console.ReadLine());
            string Story1 = Console.ReadLine();
            string Type1 = Console.ReadLine();

            if (MovieName1 == null || Director1 == null || Producer1 == null || Story1 == null || Type1 == null || Cast1 == null || Duration1 == null)
            {
                Console.WriteLine("Movie details should not be empty!!! ");
            }

            try
            {
                if (Type1 != "Running" || Type1 != "Upcoming")
                {
                    Exceptions.InvalidMovieTypeException n1 = new Exceptions.InvalidMovieTypeException();
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            obj.MovieName = MovieName1;
            obj.Director = Director1;
            obj.Producer = Producer1;
            obj.Cast = Cast1;
            obj.Duration = Duration1;
            obj.Type = Type1;
            obj.Story = Story1;

            return true;


        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
