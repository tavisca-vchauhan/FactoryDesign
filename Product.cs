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
            GetProduct d = new GetProduct();

            Console.WriteLine("Enter the type of product");
            string desc = Console.ReadLine();
            desc = desc.ToLower();
            desc = desc.Substring(0, 1).ToUpper() + desc.Substring(1);
            IProduct prod = d.GetProductType(desc);
            prod.GetTypeOfProduct();
            prod.Save();
            prod.Book();
            Console.ReadKey();
        }        
    }
}
