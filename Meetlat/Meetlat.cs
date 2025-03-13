    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace Meetlat
{
    public class Meetlat
    {

        private double lengteInMeter;


        public Meetlat(double meter)
        {
            lengteInMeter = meter;
        }


        public double LengteInCm => lengteInMeter * 100;
        public double LengteInKm => lengteInMeter / 1000;
        public double LengteInVoet => lengteInMeter * 3.2808;
    }
}
