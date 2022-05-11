using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Dishes : KitchenAppliance
    {
        abstract public void Wash();
        abstract public void PlaceToSink();
    }
}
