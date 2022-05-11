using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
     static class Program
     {
         static void Main()
         {
            var microwave = new Microwave(8);
            Console.WriteLine(microwave);
            microwave.PlaceToTable();
            microwave.PlaceToTable();
            microwave.PrintLocation();
            var fork = new Fork(0.2);
            Console.WriteLine(fork);
            fork.Wash();
            fork.PlaceToTable();
            fork.PlaceToTable();
            fork.PrintLocation();
            fork.PlaceToSink();
            fork.PrintLocation();
            microwave.TurnOn();
         }
     }

   
}
