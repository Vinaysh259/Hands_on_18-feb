using System;


namespace _1
{
    class Stock
    {
        private string StockName;
        private string StockSymbol;
        private double PreviousClosingPrice;
        private double CurrentClosingPrice;
        public Stock(string a, string b, double c, double d)
        {
            StockName = a;
            StockSymbol = b;
            PreviousClosingPrice = c;
            CurrentClosingPrice = d;
        }
        public void GetChangePercentage()
        {
            double percentage = ((PreviousClosingPrice - CurrentClosingPrice) / PreviousClosingPrice) * 100;
            Console.WriteLine("percentage change is:{0}%",percentage);
            
        }
        static void Main()
        {
            Console.WriteLine("enter the stock details");
            string StockName = Console.ReadLine();
            string StockSymbol = Console.ReadLine();
            double PreviousClosingPrice = double.Parse(Console.ReadLine());
            double CurrentClosingPrice = double.Parse(Console.ReadLine());
            Stock stock = new Stock(StockName, StockSymbol, PreviousClosingPrice, CurrentClosingPrice);


            stock.GetChangePercentage();
            Console.ReadKey();
        }
    }
}