using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CarFare
    {
        public int Discout(int fare)
        {
            fare = fare + (fare*25)/100;
            return fare;
        }
    }
}
