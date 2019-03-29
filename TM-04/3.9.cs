using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class program5
    {
        static void Main()
        {
            int l, N, i = 0, c;
            string ch;
            IList<int> alpha_list = new List<int>();
            IList<char[]> alpha_list1 = new List<char[]>();
            char[] ch1;
            Console.WriteLine("Enter how many characters you are entering :");
            N = int.Parse(Console.ReadLine());

            while (i < N)
            {
                Console.WriteLine("Enter the character:");
                ch = Console.ReadLine();
                l = ch.Length;
                ch1 = ch.ToCharArray(0, l);
                alpha_list1.Add(ch1);


                if ((ch1[0] >= 'A' && ch1[0] <= 'Z') || (ch1[0] >= 'a' && ch1[0] <= 'z'))
                {
                    c = 1;
                }
                else if (ch1[0] >= 48 && ch1[0] <= 57)
                {
                    c = 0;
                }
                else
                {
                    Console.WriteLine("invalid");
                    c = 2;
                }


                alpha_list.Add(c);
                i++;

            }

            for (int j = 0; j < alpha_list.Count; j++)
            {
                string str = new string(alpha_list1[j]);
                if (alpha_list[j] == 1)
                    Console.WriteLine("{0} is an alphabet. ", str);
                else
                    Console.WriteLine("{0} is a digit. ", str);
            }
            Console.ReadKey();
        }
    }
}

