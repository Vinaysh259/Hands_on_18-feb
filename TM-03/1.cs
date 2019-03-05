using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On_3
{
    class Person
    {
        private string FirstName;
        private string LastName;
        private string EmailAddress;
        private DateTime DateofBirth;

        public Person(string f_name, string l_name, string e_id, DateTime dob)
        {
            FirstName = f_name;
            LastName = l_name;
            EmailAddress = e_id;
            DateofBirth = dob;
        }

        public bool IsAdult()
        {

            DateTime now = DateTime.Today;
            var age = now.Year - DateofBirth.Year;
            if (age > 18)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public string SunSign()
        {
            int date = DateofBirth.Day;
            int month = DateofBirth.Month;

            if ((month == 3 && date > 20) || (month == 4 && date < 20))
            {
                return "Aries";
            }

            else if ((month == 4 && date > 19) || (month == 5 && date < 21))
            {
                return "Taurus";
            }

            else if ((month == 5 && date > 20) || (month == 6 && date < 22))
            {
                return "Gemini";
            }

            else if ((month == 6 && date > 21) || (month == 7 && date < 23))
            {
                return "Cancer";
            }

            else if ((month == 7 && date > 22) || (month == 8 && date < 23))
            {
                return "Leo";
            }

            else if ((month == 8 && date > 22) || (month == 9 && date < 23))
            {
                return "Virgo";
            }

            else if ((month == 9 && date > 22) || (month == 10 && date < 24))
            {
                return "Libra";
            }

            else if ((month == 10 && date > 23) || (month == 9 && date < 22))
            {
                return "Scorpio";
            }

            else if ((month == 11 && date > 21) || (month == 12 && date < 22))
            {
                return "Sagittarius";
            }

            else if ((month == 12 && date > 21) || (month == 1 && date < 20))
            {
                return "Capricon";
            }

            else if ((month == 1 && date > 19) || (month == 2 && date < 19))
            {
                return "Aquarius";
            }

            else
            {
                return "Pisces";
            }

        }

        public bool IsBirthDay()
        {
            DateTime now = DateTime.Now;
            if ((DateofBirth.Month == now.Month) && (DateofBirth.Day == now.Day))
            {
                return true;
            }
            else
                return false;
        }

        public string ScreenName()
        {

            return (FirstName.ToLower() + DateofBirth.Day.ToString() + DateofBirth.Month.ToString());
        }
    }

    class Employee : Person
    {
        private double Salary;

        public Employee(string f_name, string l_name, string e_id, DateTime dob, double e_salary) : base(f_name, l_name, e_id, dob)
        {
            Salary = e_salary;
        }
        public double salary
        {
            get
            {
                return (Salary);
            }
        }
    }


    class ProgramTest
    {
        static void Main(string[] args)
        {
            DateTime dob = new DateTime(1997, 12, 25);
            string f_name, l_name, e_id;
            double salary;
            Console.WriteLine("Enter the employee details :");
            f_name = Console.ReadLine();
            l_name = Console.ReadLine();
            e_id = Console.ReadLine();
            dob = DateTime.Parse(Console.ReadLine());
            salary = double.Parse(Console.ReadLine());
            //Employee e1 = new Employee("Vinay", "Hegde", "vinaysh258@gmail.com",dob, 35000);
            Employee e1 = new Employee(f_name, l_name, e_id, dob, salary);
            if (e1.IsAdult())
                Console.WriteLine("Employee {0}, is an adult person", e1.ScreenName());
            else
                Console.WriteLine("Employee {0}, is not an adult person", e1.ScreenName());

            Console.WriteLine("Sun Sign of the Employee is {0}", e1.SunSign());

            if (e1.IsBirthDay())
                Console.WriteLine("Hey {0} , Happy Birthday!!!!!!!", e1.ScreenName());

            Console.WriteLine("Employee {0}, has a salary of {1} rupees.", e1.ScreenName(), e1.salary);

            Console.ReadKey();
        }
    }
}
