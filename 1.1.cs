using System;



class Square
{
    static void Main()
    {
        Console.WriteLine("enter the side of the square");
        float Side = float.Parse(Console.ReadLine());
        float Area = Side * Side;
        Console.WriteLine("area= {0}", Area);
        Console.ReadKey();

    }
}