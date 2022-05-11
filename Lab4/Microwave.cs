using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Microwave : KitchenAppliance, IsElectrical
    {
        protected override double Weight { get; set ; }
        protected override string Location { get; set; } = "підвіконник";
        public Microwave(double weight)
        {
            Weight = weight;
        }
        public override void PrintLocation()
        {
            Console.WriteLine($"Мiсцезнаходження цiєї мікрохвильовки - {Location}.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Мiкрохвильовка була ввiмкнена.");
        }

        public override void PlaceToTable()
        {
            if (Location != "стіл")
            {
                Location = "стіл";
                Console.WriteLine("Ви перемістили цю мікрохвильовку на стіл.");
            }
            else Console.WriteLine("Неможливо перемістити на стіл , оскільки ця мікрохвильовка вже знаходиться на ньому");
        }

        public override string ToString()
        {
            return "Мiкрохвильовка " + base.ToString();
        }
    }
}
