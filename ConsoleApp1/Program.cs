using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Bus bus = new Bus("BMW", 34, 1200);
            Console.WriteLine("Автобус");
            bus.Sum();
            Console.WriteLine();

            TouristBus touristBus = new TouristBus("BMW", 34, 1200, 6801);
            Console.WriteLine("Общая стоимость билета");
            touristBus.PrintInfo();
            Console.WriteLine();

            int N = 3;
            TouristBus[] touristBus1 = new TouristBus[N];
            touristBus1[0] = new TouristBus("BMW", 34, 1200, 6801);
            touristBus1[1] = new TouristBus("BMW", 14, 1200, 6801);
            touristBus1[2] = new TouristBus("BMW", 24, 1200, 6801);
            Console.WriteLine();

            foreach (var touris in touristBus1)
            {
                touris.PrintInfo();
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
