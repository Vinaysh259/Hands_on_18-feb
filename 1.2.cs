using System;

namespace AreaOfSquare
{
    class square
    {
        double side;
        double area;



        public void SetSide(double sd)
        {
            side = sd;
        }

        public double GetArea()
        {
            area = side * side;
            return area;
        }


    }


    class AreaOfSquareTester
    {
        static void Main()
        {
            square square1 = new square();
            Console.WriteLine("Enter the Side of the Square : \n");
            double sd = double.Parse(Console.ReadLine());
            square1.SetSide(sd);

            Console.WriteLine("Area of the Square = {0}", square1.GetArea());
            Console.ReadKey();
        }
    }
}
