using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Test_case,M = 0,N = 0 ;
            string tst;
            char[] ch;
            int count = 0;
            Console.WriteLine("Enter the Number of Testcases :");
            tst = Console.ReadLine();
            Test_case = Convert.ToInt32(tst);
          //  Console.WriteLine(Test_case);
            string[] str = new string[Test_case];
            


            Console.WriteLine("Enter the Test Cases :");
            for (int i = 0; i < Test_case; i++)
            {
                str[i] = Console.ReadLine();
            }
            
            for(int i = 0; i < Test_case; i++)
            {
                string str1 = str[i];
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (Char.IsDigit(str[i][j]))
                    {
                        if(count == 0)
                        {
                            N = Convert.ToInt32(str[i][j]);
                            count++;
                        }
                        else
                        {
                            M = Convert.ToInt32(str[i][j]);
                            count = 0;
                        }
                       
                    }

                    
                }
                tst = str[i].Substring((N - '0'), (M - N + 1));
               // Console.WriteLine(tst);
                ch = tst.ToCharArray(0, tst.Length);
                for(int j = 1;j < tst.Length; j++)
                {
                    for(int k = 0; k < (tst.Length - j); k++)
                    {
                        if (ch[k] < ch[k + 1])
                        {
                            char temp = ch[k];
                            ch[k] = ch[k + 1];
                            ch[k + 1] = temp;
                        }
                    }
                }
               // Console.WriteLine(str1);
                //Console.WriteLine(ch);
                char[] ch1 = str1.ToCharArray(0, str1.Length);
                int l = 0;
                    for (int j = (N - '0') ; j < (M - '0' + 1); j++)
                    {
                        ch1[j] = ch[l];
                        l++;
                    }
                    
                
                for(int j =0;j<ch1.Length;j++)
                {
                    if(ch1[j] != ' ')
                    {
                        Console.Write(ch1[j]);
                       
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write('\n');
            }

            Console.ReadKey();
        }

    }
}
