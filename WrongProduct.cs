using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class WrongProduct : IProduct
    {
        public string GetTypeOfProduct(string databaseOperation)
        {
            Console.WriteLine("You Entered Wrong Product-Type");
            return "Wrong Product type";
        }
        public void Book(string databaseOperation)
        {
            Console.WriteLine("Nothing to be booked");
        }
        public void Save(string databaseOperation)
        {
            Console.WriteLine("Nothing to be saved");
        }
    }
}
