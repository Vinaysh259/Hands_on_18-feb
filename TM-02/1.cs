using System;


namespace _1
{
    class Car
    {
        private string carmake;
        private string model;
        private int mfgYear;
        private double price;

        public Car(string a,string b,int c,double d)
        {
            carmake = a;
            model = b;
            mfgYear = c;
            price = d;
        }
        public void DisplayCar()
        {
            Console.WriteLine("details of the car:");
            Console.WriteLine("carmake={0}\nmodel={1}\nmfgYear={2}\nprice={3}", carmake, model, mfgYear, price);
        }
        static void Main()
        {
            Console.WriteLine("enter the details of the car");
            string carmake1 = Console.ReadLine();
            string model1 = Console.ReadLine();
            int mfgYear1 = Convert.ToInt32(Console.ReadLine());
            double price1 = double.Parse(Console.ReadLine());

            Car car = new Car(carmake1,model1,mfgYear1,price1);

          
            car.DisplayCar();
            Console.ReadKey();
        }
    }
}
