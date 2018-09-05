using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class WrongProduct : IProduct
    {
        public string GetTypeOfProduct()
        {
            Console.WriteLine("You Entered Wrong Product-Type");
            return "Wrong Product type";
        }
        public void Book()
        {
            Console.WriteLine("Nothing to be booked");
        }
        public void Save()
        {
            Console.WriteLine("Nothing to be saved");
        }
    }
}
