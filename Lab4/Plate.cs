using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Plate : Dishes
    {
        protected override double Weight { get ; set ; }
        protected override string Location { get; set; } = "вiтрина";

        public Plate(double weight)
        {
            Weight = weight;
        }
        public override void PrintLocation()
        {
            Console.WriteLine($"Місцезнаходження цієї тарілки - {Location}.");
        }

        public override void Wash()
        {
            Console.WriteLine("Ви помили цю тарiлку.");
        }

        public override void PlaceToTable()
        {
            if (Location != "стіл")
            {
                Location = "стіл";
                Console.WriteLine("Ви перемістили цю тарілку на стіл.");
            }
            else Console.WriteLine("Неможливо перемістити на стіл , оскільки ця тарілка вже знаходиться на ньому.");
        }

        public override void PlaceToSink()
        {
            if (Location != "раковина")
            {
                Location = "раковина";
                Console.WriteLine("Ви перемістили цю тарілку в раковину.");
            }
            else Console.WriteLine("Неможливо перемістити в раковину , оскільки ця тарілка вже знаходиться в ній.");
        }

        public override string ToString()
        {
            return "Тарiлка " + base.ToString();
        }
    }
}
