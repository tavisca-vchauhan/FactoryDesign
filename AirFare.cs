using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class AirFare
    {
        public int Discout(int fare)
        {
            fare = fare + (fare * 20) / 100;
            return fare;
        }
    }
}
