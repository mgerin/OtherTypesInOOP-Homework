using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem01GalacticGPS
{
    class GalacticGPS
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Mars);
            Console.WriteLine(home);
        }
    }
}
