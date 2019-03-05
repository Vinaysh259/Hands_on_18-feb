using System;


namespace _1
{
    class Person
    {
        private string FirstName;
        private string LastName;
        private string EmailAddress;
        private DateTime DateOfBirth;
        public Person(string a, string b, string c, DateTime d)
        {
            FirstName = a;
            LastName = b;
            EmailAddress = c;
            DateOfBirth = d;
        }

        public bool IsBirthDay()
        {
            DateTime now = DateTime.Now;
            if (DateOfBirth == now)
            {
                return true;
            }
            else
                return false;
        }
        public string ScreenName()
        {
            
            return (FirstName.ToLower()+DateOfBirth.Day.ToString()+DateOfBirth.Month.ToString());
        }


    }

    
    
}
        static void Main(string[] args)
        {
        }


