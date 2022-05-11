using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Fork : Dishes
    {
        protected override double Weight { get ; set; }
        protected override string Location { get; set; } = "шухляда";

        public Fork(double weight)
        {
            Weight = weight;
        }

        public override void PrintLocation()
        {
            Console.WriteLine($"Місцезнаходження цієї вилки - {Location}.");
        }

        public override void Wash()
        {
            Console.WriteLine("Ви помили цю вилку.");
        }

        public override void PlaceToTable()
        {
            if (Location != "стіл")
            {
                Location = "стіл";
                Console.WriteLine("Ви перемістили цю вилку на стіл.");
            }
            else Console.WriteLine("Неможливо перемістити на стіл , оскільки ця вилка вже знаходиться на ньому.");
        }

        public override void PlaceToSink()
        {
            if (Location != "раковина")
            {
                Location = "раковина";
                Console.WriteLine("Ви перемістили цю вилку в раковину.");
            }
            else Console.WriteLine("Неможливо перемістити в раковину , оскільки ця вилка вже знаходиться в ній.");
        }

        public override string ToString()
        {
            return "Вилка " + base.ToString();
        }
    }
}
