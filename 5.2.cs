using System;


namespace String
{
    class Program5b
    {
        static void Main()
        {
            string a;
            int  i,l;
            char[] arr;

            Console.WriteLine("Enter the input String");
            a = Console.ReadLine();
            l = a.Length;
            //arr1 = a.ToCharArray(0, l);
            string sub = a.Substring(1, l-1);
            Console.WriteLine("Substring: {0}", sub);

             
            string a2 = string.Copy(a);
            arr = a2.ToCharArray(0, l);
            //string output = a2.Replace(a2, "* ");
            Console.WriteLine("::BEFORE::");
            Console.WriteLine(a2);
            Console.WriteLine("::AFTER::");
            for (i = 0; i < l; i++)
            {
                char ch = arr[i];
                if (Char.IsLower(ch))
                    Console.Write(Char.ToUpper(ch));
                else
                    Console.Write(Char.ToLower(ch));
            }
            //string output = a2.Replace(a2, "* ");

            //Console.WriteLine(output);
            Console.ReadKey();


        }
    }
}