using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class HotelFare
    {
        public int Discout(int fare)
        {
            fare = fare + (fare * 15) / 100;
            return fare;
        }
    }
}
