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
        public string GetTypeOfProduct(string databaseOperation)
        {
            return "air";
        }
        public void Book(string databaseOperation)
        {
            log.write("\nBooking Air Product");
            string data = "TicketNumber: " + ticketNumber + ", DepartureStation: " + departureStation + ",  ArrivalTime : " + arrivalTime + ", DepartureTime : " + departureTime + " , Fare : " + fare+" , Seat : "+seat + " IsBooked :" + IsBooked;
            data = "\nBooking Air product :- " + data;
            dtype.GetDatabasetype(data, databaseOperation);
            Console.WriteLine("Booking Air product");
            IsBooked = true;
        }
        public void Save(string databaseOperation)
        {
            log.write("\nSaving Air Product");
            string data = "TicketNumber: " + ticketNumber + ", DepartureStation: " + departureStation + ",  ArrivalTime : " + arrivalTime + ", DepartureTime : " + departureTime + " , Fare : " + fare + " , Seat : " + seat + " IsBooked :" + IsBooked;
            data = "\nSaving Air product :- " + data;
            dtype.GetDatabasetype(data, databaseOperation);
            Console.WriteLine("Saving Air product");
        }
    }
}