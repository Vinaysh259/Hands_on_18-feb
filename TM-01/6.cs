using System;


namespace _6
{
    public class Program6
    {
       
        public void Pre(int num1, int num2)
        {
            num2 = ++num1;
            Console.Write("new numbers are: {0},{1}\n", num1, num2);
            
            
             
        }
        public void Post(int num1, int num2)
        {
            num2 = num1++;
            Console.Write("new numbers are: {0},{1}\n", num1, num2);
        }
        public void Swap(int num1, int num2)
        {
            int b;
            b = num1;
            num1 = num2;
            num2 = b;
          
            Console.Write("new numbers are: {0},{1}", num1, num2);
        }

        static void Main()
        {
            Program6 a = new Program6();
            int n1, n2;
            Console.Write("Enter a number: ");
             n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
             n2 = Convert.ToInt32(Console.ReadLine());

            a.Pre(n1,n2);
            a.Post(n1, n2);
            a.Swap(n1, n2);
            Console.ReadKey();
        }
    }
}
