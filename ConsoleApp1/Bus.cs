using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bus
    {
        private string mark; //Марка
        private int places; // кол-во мест
        private double ticketPrice; // стоимость билета

        
        public string Mark
        {
            get { return mark; }
            set { mark = value ?? throw new ArgumentException("Марка автобуса не может быть пустой."); }
        }

        public int Places
        {
            get { return places; }
            set { places = value >= 1 ? value : throw new ArgumentException("Количество мест должно быть больше 0."); }
        }

        public double TicketPrice
        {
            get { return ticketPrice; }
            set { ticketPrice = value >= 0 ? value : throw new ArgumentException("Цена билета не может быть отрицательной."); }
        }
        public Bus() //Без параметров 
        {
            
        }

        public Bus(string mark, int places, double ticketPrice)
        {
            this.mark = mark;
            this.places = places;
            this.ticketPrice = ticketPrice;
        }

        public virtual void PrintInfo() // Вывод
        {
            Console.WriteLine($"Марка автобуса: {Mark}");
            Console.WriteLine($"Количество мест: {Places}");
            Console.WriteLine($"Стоимость билета: {TicketPrice} руб.");
        }

        public double Sum() //Общая стоимость всех мест
        {
            return Places * TicketPrice;
        }
    }
}
