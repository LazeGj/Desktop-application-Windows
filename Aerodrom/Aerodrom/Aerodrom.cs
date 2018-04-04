using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aerodrom
{
    public class Aerodrom
    {
        public String City { get; set; }
        public String Name { get; set; }
        public String ShortName { get; set; }

        public List<Destination> Destinations { get; set; }

        public Aerodrom()
        {
            Destinations = new List<Destination>();
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} EUR", ShortName, Name, City);
        }
    }
}
