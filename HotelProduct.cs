using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class HotelProduct : IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Hotel";
        }
        public void Book()
        {
            Console.WriteLine("Booking Hotel");
        }
        public void Save()
        {
            Console.WriteLine("Saving Hotel details");
        }
    }
}
