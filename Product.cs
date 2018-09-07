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
            Logger log =Logger.getInstance();
            char option = 'Y';
            do
            {

                Console.WriteLine("Enter the type of product [e.g :  'Car' , 'Hotel' , 'Air' , 'Activity']");
                string desc = Console.ReadLine();
                log.write("\nStarting from main-program \n Getting product type from user");
                desc = desc.ToLower();
                desc = desc.Substring(0, 1).ToUpper() + desc.Substring(1);
                Console.WriteLine("Enter Operartion You want to perform : [e.g. : 'Save' 'Book']");
                string operation = Console.ReadLine();
                log.write("\nGetting operation from user");
                operation = operation.ToLower();
                operation = operation.Substring(0, 1).ToUpper() + operation.Substring(1);
                Console.WriteLine("What do you want to use to store data : [e.g. : 'File' 'Database' ]");
                string databaseOperation = Console.ReadLine();
                log.write("\nChoosing database through user");
                databaseOperation = databaseOperation.ToLower();
                databaseOperation = databaseOperation.Substring(0, 1).ToUpper() + databaseOperation.Substring(1);
                d.GetProductType(desc, operation, databaseOperation);
                Console.WriteLine("Do you wanna continue ? - Y OR N");
                option = Convert.ToChar(Console.ReadLine());
                if(option=='Y' || option=='y')
                    log.write("Exiting..");
            }
            while (option=='y' || option=='Y');


            Console.ReadKey();
        }        
    }
}
