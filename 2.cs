using System;


namespace String
{
    class Program2
    {
        static void Main()
        {
            string a;
            int alphabets, digits, specialCharacter, i, l;
            alphabets = digits = specialCharacter = i = 0;
            Console.WriteLine("Count the number of digits,alpabets in a string");
            Console.WriteLine("Enter the input String");
            a = Console.ReadLine();
            l = a.Length;
            while (i < l)
            {
                if ((a[i] >= 'a' && a[i] <= 'z') || (a[i] >= 'A' && a[i] <= 'Z'))
                {
                    alphabets++;
                }
                else if (a[i] >= '0' && a[i] <= '9')
                {
                    digits++;
                }
                i++;
            }
            Console.WriteLine("The Number of Alphabets in a String is={0}", alphabets);
            Console.WriteLine("The Number of Digits in a String is={0}", digits);

            Console.ReadKey();


        }
    }
<<<<<<< HEAD
}
=======
}
	
>>>>>>> ea88d3e565a131d8f9f4a6755a703a1b8c3bcf7e
