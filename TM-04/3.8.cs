using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program8
    {
        static void Main()
        {
            int n1, n2, res, count = 0, j = 1, i, c, k;
            Console.WriteLine("Enter the Number of inputs : ");
            int N = int.Parse(Console.ReadLine());
            IList<string> list = new List<string>();
            while (j <= N)
            {
                c = 0;
                Console.Write("Enter first number: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                string n3 = n1.ToString();
                char[] num = n3.ToCharArray();
                int L = num.Length;
                int[] x1 = new int[L];
                for (i = 0; i < L; i++)
                {
                    string s = num[i].ToString();
                    x1[i] = Convert.ToInt32(s);
                }


                for (k = 0; k < x1.Length; k++)
                {
                    if (x1[k] == n2)
                    {
                        c++;

                        break;
                    }
                    else
                    { }

                }
                //Console.WriteLine("{0}", c);
                if (c == 0)
                {
                    string ans = "second number doesn't exist in first number";
                    list.Add(ans);

                }
                else

                {
                    while (n1 > 0)
                    {
                        res = n1 % 10;
                        if (res == n2)

                            break;

                        else
                            n1 = n1 / 10;
                        count++;
                    }
                    if (count == 0)
                    {
                        string ans = "unit's place";
                        list.Add(ans);
                    }

                    else if (count == 1)
                    {
                        string ans = "ten's place";
                        list.Add(ans);
                    }

                    else if (count == 2)
                    {
                        string ans = "hundred's place";
                        list.Add(ans);
                    }

                    else
                    {
                        string ans = "thousand's place";
                        list.Add(ans);
                    }
                }
                j++;
            }
            for (int m = 0; m < list.Count; m++)
                Console.WriteLine("{0}) {1}", m + 1, list[m]);
            Console.ReadKey();
        }

    }
}
