using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom
{
    public class Destination
    {
        public String Name { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0}   {1}km-{2} EUR", Name, Distance, Price);
        }
    }
}
