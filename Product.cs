using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Product
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of product");
            string desc = Console.ReadLine();
            IProduct prod = GetProduct.GetProductType();
            prod.GetTypeOfProduct();
            prod.Save();
            prod.Book();
        }        
    }
}
