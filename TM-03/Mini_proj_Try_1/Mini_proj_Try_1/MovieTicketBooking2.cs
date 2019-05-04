using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketBooking1;
using MovieTicketBooking3;

namespace MovieTicketBooking2
{
    public interface IAdmin
    {
        bool AddTheatre(Theatre obj);
        bool UpdateTheatre(Theatre obj);
        bool AddMovie(Movie obj);
        bool UpdateMovie(Movie obj);
        bool AddShow(Show obj);
        bool UpdateShow(Show obj);
        bool DeleteShow(int Showid);
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

    public class Administrator : IAdmin
    {

        public bool AddTheatre(Theatre obj)
        {
            bool flag = false;
            
            try
            {
                if (obj.TheatreName == "" || obj.CityName == "" || obj.Address == "" || obj.NoOfScreens == null || obj.Screens == null)
                {
                    Console.WriteLine("The theatre details should not be empty");
                }

                else if (obj == null)
                {
                    throw new Exception();
                }


                else if (obj.NoOfScreens <= 0)
                {
                    Exceptions.InvalidScreenCountExcpetion n1 = new Exceptions.InvalidScreenCountExcpetion();
                }

                else
                {
                    Theatre t1 = new Theatre(obj.TheatreName, obj.CityName, obj.Address, obj.NoOfScreens);
                    MovieTicketing.Theatres.Add(t1);
                    flag = true;

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return flag;
        }


        public bool UpdateTheatre(Theatre obj)
        {
            bool flag = false;
            bool flag1 = false;

            foreach (var val in MovieTicketing.Theatres)
            {
                if (val == obj)
                {
                    flag1 = true;
                    break;
                }

                else
                    flag1 = false;

            }

            if (flag1)
                obj.DisplayTheatreDetails();

            else
            {
                Console.WriteLine("Theatre not found");
                return flag;
            }
                                 
            Console.WriteLine("What are the Updated details ????");

            string TheatreName1 = Console.ReadLine();
            string CityName1 = Console.ReadLine();
            string Address1 = Console.ReadLine();
            int NoOfScreens1 = int.Parse(Console.ReadLine());

            if (TheatreName1 == "" || CityName1 == "" || Address1 == "" || NoOfScreens1 == null)
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


        
        public bool AddMovie(Movie obj)
        {
            bool flag = false;
            
            try
            {
                if (obj.MovieName == "" || obj.Director == "" || obj.Producer == "" || obj.Story == "" || obj.Type == "" || obj.Cast == "" || obj.Duration == null)
                {
                    Console.WriteLine("Movie details should not be empty!!! ");
              
                }

                              
                else if (obj == null)
                    throw new Exception();

                else if (obj.Type != "Running" || obj.Type != "Upcoming")
                {
                   Exceptions.InvalidMovieTypeException n1 = new Exceptions.InvalidMovieTypeException();
                }

                else
                {
                    Movie m1 = new Movie(obj.MovieName, obj.Director, obj.Producer, obj.Cast, obj.Duration, obj.Story, obj.Type);
                    MovieTicketing.Movies.Add(m1);
                    flag = true;

                }


            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return flag;
        }


        public bool UpdateMovie(Movie obj)
        {
            bool flag = false;
            Console.WriteLine("What are the updated movie details???");

            string MovieName1 = Console.ReadLine();
            string Director1 = Console.ReadLine();
            string Producer1 = Console.ReadLine();
            string Cast1 = Console.ReadLine();
            double Duration1 = double.Parse(Console.ReadLine());
            string Story1 = Console.ReadLine();
            string Type1 = Console.ReadLine();

                       
            try
            {
                if (MovieName1 == null || Director1 == null || Producer1 == null || Story1 == null || Type1 == null || Cast1 == null || Duration1 == null)
                {
                    Console.WriteLine("Movie details should not be empty!!! ");
                }

                else if (obj == null)
                {
                    throw new Exception();
                }

                else if (Type1 != "Running" || Type1 != "Upcoming")
                {
                    Exceptions.InvalidMovieTypeException n1 = new Exceptions.InvalidMovieTypeException();
                }

                else
                {
                    obj.MovieName = MovieName1;
                    obj.Director = Director1;
                    obj.Producer = Producer1;
                    obj.Cast = Cast1;
                    obj.Duration = Duration1;
                    obj.Type = Type1;
                    obj.Story = Story1;
                    MovieTicketing.Movies.Add(obj);
                    flag = true;
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return flag ;
        }

        public bool AddShow(Show obj)
        {
            bool flag = false;
           
            try
            {
                if (obj.MovieID == null || obj.TheatreID == null || obj.ScreenID == null || obj.StartDate == null || obj.EndDate == null || Show.PlatinumSeatRate == null || Show.GoldSeatRate == null || Show.SilverSeatRate == null)
                {
                    Console.WriteLine("Show details should not be empty");
                }

                else if (obj == null)
                {
                    throw new Exception();
                }

                else
                {
                    foreach (var val in MovieTicketing.Shows)
                    {
                        if (val.MovieID == obj.MovieID && val.TheatreID == obj.TheatreID && val.ScreenID == obj.ScreenID)
                        {
                            MovieTicketing.Shows.Add(obj);
                            flag = true;
                            break;
                        }

                        else
                            flag = false;

                    }
                }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (flag == true)
                return flag;

            else
            {
                Console.WriteLine("Inappropriate data found");
                return flag;
            }
        }

        public bool UpdateShow(Show obj)
        {
            bool flag = false;
            Console.WriteLine("What are the updated show details???");

            int m_id = int.Parse(Console.ReadLine());
            int t_id = int.Parse(Console.ReadLine());
            int sc_id = int.Parse(Console.ReadLine());

            DateTime s_date = DateTime.Parse(Console.ReadLine());
            DateTime e_date = DateTime.Parse(Console.ReadLine());
            decimal p_rate = decimal.Parse(Console.ReadLine());
            decimal g_rate = decimal.Parse(Console.ReadLine());
            decimal s_rate = decimal.Parse(Console.ReadLine());
            try
            {
                if (m_id == null || t_id == null || sc_id == null || s_date == null || e_date == null || p_rate == null || g_rate == null || s_rate == null)
                {
                    Console.WriteLine("Show details should not be empty!!!!");
                }
                else if (obj == null)
                {
                    throw new Exception("Show details can't be null");
                }
                else
                {
                    foreach (var val in MovieTicketing.Shows)
                    {
                        if (val.MovieID == obj.MovieID && val.TheatreID == obj.TheatreID && val.ScreenID == obj.ScreenID)
                        {
                            obj.MovieID = m_id;
                            obj.TheatreID = t_id;
                            obj.ScreenID = sc_id;
                            obj.StartDate = s_date;
                            obj.EndDate = e_date;
                            Show.PlatinumSeatRate = p_rate;
                            Show.GoldSeatRate = g_rate;
                            Show.SilverSeatRate = s_rate;
                            flag = true;
                        }

                        else
                            flag = false;

                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if(flag)
            {
                return flag;
            }
            else
            {
              Console.WriteLine("Inappropriate data found");
              return flag;
            }
            
        }

        public bool DeleteShow(int Showid)
        {
            bool flag = false;
            foreach(var val in MovieTicketing.Shows)
            {
                if (val.ShowID == Showid)
                {
                    MovieTicketing.Shows.Remove(val);
                    flag = true;
                    break;
                }
                else
                    flag = false;       
            }
            return flag;    
        }
 
        public bool AddAgent(User obj)
        {
            bool flag = false;
            try
            {
                if (obj == null)
                {
                    throw new Exception();
                }

                else if (obj.UserName == "" || obj.Password == "" || obj.UserType == "")
                    {
                        Console.WriteLine("User info cant be empty");
                    }

                    else
                    {
                    MovieTicketing.UserInformation.Add(obj);
                        flag = true;
                    }
            }       

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;

        }

        public List<Theatre> GetAllTheatres()
        {
            return MovieTicketing.Theatres;
        }
        public List<Movie> GetAllMovies()
        {
            return MovieTicketing.Movies;
        }
        public List<Show> GetAllShows()
        {
            return MovieTicketing.Shows;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
