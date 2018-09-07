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
        public string GetTypeOfProduct(string databaseOperation)
        {
            return "car";
        }
        public void Book(string databaseOperation)
        {
            log.write("\nBooking Car Product");
            string data = "CarId: " + carId + ", \nCarName: " + carName + ", \n CarModel : " + carModel + ", \n Cost: " + cost + " IsBooked :" + IsBooked;
            data = "\nBooking Car :- " + data;
            dtype.GetDatabasetype(data,databaseOperation);
            Console.WriteLine("Booking Car");
            IsBooked = true;
        }
        public void Save(string databaseOperation)
        {
            log.write("\nSaving Car product");
            string data = "CarId: " + carId + ", \nCarName: " + carName + ", \n CarModel : " + carModel + ", \n Cost: " + cost + " IsBooked :" + IsBooked;
            data = "\nSaving car product :- " + data;
            dtype.GetDatabasetype(data, databaseOperation);
            Console.WriteLine("Saving car product");
        }
    }
}