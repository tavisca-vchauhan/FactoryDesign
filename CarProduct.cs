using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory 
{
    class CarProduct : IProduct
    {
        public string GetTypeOfProduct()
        {
            return "car";
        }
        public void Book()
        {
            Console.WriteLine("Booking Car");
        }
        public void Save()
        {
            Console.WriteLine("Saving car product");
        }
    }
}
