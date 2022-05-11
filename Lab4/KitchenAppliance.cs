using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class KitchenAppliance
    {
        abstract protected double Weight { get; set; }
        abstract protected string Location { get; set; }
        abstract public void PrintLocation();
        abstract public void PlaceToTable();
        public override string ToString()
        {
            return $"{Weight} кг";
        }
    }
}
