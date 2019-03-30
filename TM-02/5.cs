using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Fan
    {
        public const int SLOW = 1, MEDIUM = 2, FAST = 3;
        public int speed { get; set; }
        private bool on { get; set; }
        private double radius { get; set; }
        private string color { get; set; }
        public Fan()
        {
            speed = SLOW;
            on = false;
            radius = 5;
            color = "red";
        }
        public void toString()
        {
            Console.WriteLine("enter the scenerio:");
            int count = int.Parse(Console.ReadLine());
            if (count == 0)
            {
                Console.WriteLine("enter the details of your fan:");
                int f_speed = int.Parse(Console.ReadLine());
                bool f_on = bool.Parse(Console.ReadLine());
                double f_radius = double.Parse(Console.ReadLine());
                string f_color = Console.ReadLine();
                Console.WriteLine("current status of fan:");

                if (f_speed == 1)
                    Console.Write("speed=SLOW,");
                else if (f_speed == 2)
                    Console.Write("speed=MEDIUM,");
                else
                    Console.Write("speed=FAST,");
                Console.WriteLine("on={0},radius={1},color={2}", f_on, f_radius, f_color);
            }
            else
                Console.WriteLine("default status of fan:\nspeed={0},on={1},radius={2},color={3}", speed, on, radius, color);
        }
    }
    class status
    {
        static void Main(string[] args)
        {
            Fan f = new Fan();
            f.toString();
            Console.ReadKey();
        }
    }
}

