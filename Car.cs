using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory 
{
    class Car : GetProduct , IProduct
    {
        int carId = 1;
        string carModel = "2018 model";
        string carName = "BBT";
        int cost = 2505000;
        Boolean IsBooked = false;
        Logger log = Logger.getInstance();
        GetDatabaseType dtype = new GetDatabaseType();
        CarFare car = new CarFare();
        public Car()
        {
            cost =car.Discout(cost);
        }
        public string GetTypeOfProduct(string operationChoice)
        {
            return "car";
        }
        public void Book(string operationChoice, string schema)
        {
            log.write("\nBooking Car Product");
            string value = "carId:" + carId + ",carName:" + carName + ",carModel:" + carModel + ",cost:" + cost + ",IsBooked:" + IsBooked;
            dtype.GetDatabasetype(value, operationChoice , schema);
            Console.WriteLine("Booking Car");
            IsBooked = true;
        }
        public void Save(string operationChoice, string schema)
        {
            log.write("\nSaving Car product");
            string value = "carId:" + carId + ",carName:" + carName + ",carModel:" + carModel + ",cost:" + cost + ",IsBooked:" + IsBooked;
            dtype.GetDatabasetype(value, operationChoice, schema);
            Console.WriteLine("Saving car product");
        }
    }
}