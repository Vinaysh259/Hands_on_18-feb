using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketBooking1;
using MovieTicketBooking2;

namespace MovieTicketBooking3
{
    public class MovieTicketing
    {

        public static List<User> UserInformation { get; set; }
        public static List<Theatre> Theatres { get; set; }
        public static List<Movie> Movies { get; set; }
        public static List<Show> Shows { get; set; }
        public static List<Booking> Bookings { get; set; }

        public MovieTicketing()
        {
            User u1 = new User("Admin", "Admin", "Admin");
            UserInformation = new List<User>();
            UserInformation.Add(u1);

            Theatres = new List<Theatre>();
            Movies = new List<Movie>();
            Shows = new List<Show>();
            Bookings = new List<Booking>();

        }


        public void AdminMenu()
        {
            Console.WriteLine("Admin Menu :\n" +
                "1. Add Theatre\n" +
                "2. Update Theatre\n" +
                "3. Add Movie\n" +
                "4. Update Movie\n" +
                "5. Add Show\n" +
                "6. Update Show\n" +
                "7. Delete Show\n" +
                "8. Display Theatres\n" +
                "9. Display Movies\n" +
                "10. Display Shows\n" +
                "11. Add Agent\n" +
                "12. Book Ticket\n" +
                "13. Print Ticket\n" +
                "14. Exit\n");
        }

        public void AgentMenu()
        {
            Console.WriteLine("Agent Menu :\n" +
                "1. View Shows\n" +
                "2. New Ticket\n" +
                "3. Print Ticket\n" +
                "4. Exit\n");
        }

        public int GetChoice()
        {
            Console.WriteLine("Please Enter Your Choice :");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public string Login()
        {
            bool flag = false;
            Console.WriteLine("Enter Your Login Credentials :\n" +
                "Enter Username :");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password :");
            string password = Console.ReadLine();
            string type = null;

            foreach (var obj in UserInformation)
            {
                if (obj.UserName == username && obj.Password == password)
                {
                    flag = true;
                    type = obj.UserType;
                    break;
                }


            }

            if (flag)
                return type;
            else
                return type;
        }
    }


    class program
    {
        static void Main(string[] args)
        {

        }
    }
}
