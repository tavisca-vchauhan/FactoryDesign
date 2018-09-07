using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Air : GetProduct, IProduct
    {
        int ticketNumber = 567321;
        int fare = 7000;
        string departureStation = "Pune";
        string arrivalTime = "16:30 IST";
        string departureTime = "18:00 IST";
        int seat = 1;
        Boolean IsBooked = false;
        GetDatabaseType dtype = new GetDatabaseType();
        Logger log = Logger.getInstance();
        File file = new File();
        AirFare air = new AirFare();
        public Air()
        {
            fare = air.Discout(fare);
        }
        public string GetTypeOfProduct(string operationChoice)
        {
            return "air";
        }
        public void Book(string operationChoice, string schema)
        {
            log.write("\nBooking Air Product");
            string value = "ticketNumber:" + ticketNumber + ",departureStation:" + departureStation + ",arrivalTime:" + arrivalTime + ",departureTime:" + departureTime + ",fare:" + fare+",seat:"+seat + ",IsBooked:" + IsBooked;
            IsBooked = true;
            dtype.GetDatabasetype(value, operationChoice, schema);
            Console.WriteLine("Booking Air product");
        }
        public void Save(string operationChoice, string schema)
        {
            log.write("\nSaving Air Product");
            string value = "ticketNumber:" + ticketNumber + ",departureStation:" + departureStation + ",arrivalTime:" + arrivalTime + ",departureTime:" + departureTime + ",fare:" + fare + ",seat:" + seat + ",IsBooked:" + IsBooked;
            dtype.GetDatabasetype(value, operationChoice, schema);
            Console.WriteLine("Saving Air product");
        }
    }
}