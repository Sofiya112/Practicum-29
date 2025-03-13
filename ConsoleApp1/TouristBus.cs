using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TouristBus : Bus
    {
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value >= 0 ? value : throw new ArgumentException("Стоимость экскурсии не может быть отрицательной."); }
        }
        public TouristBus()//Без параметра
        {
            
        }

        public TouristBus(string mark, int places, double ticketPrice, double price) : base(mark, places, ticketPrice) // Спараметрами
        {
            Price = price;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            base.PrintInfo(); 
            Console.WriteLine($"Стоимость экскурсии: {Price} руб.");
            Console.WriteLine($"Общая стоимость всех мест с учетом экскурсии: {Tender()} руб.");
        }

        public double Tender() // Общая стоимость всех мест с учетом увеличения цены билета за экскурсию
        {
            return Places * (TicketPrice + Price);
        }
    }
}
