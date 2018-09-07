using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Hotel : GetProduct , IProduct
    {
        int hotelId = 1;
        string hotelName = "Hyatt";
        string hotelAddress = "Near Weikfield ,Viman Nagar,Pune,Maharashtra";
        int fare = 4500;
        int roomsAvailable = 10;
        Boolean IsBooked=false;
        GetDatabaseType dtype = new GetDatabaseType();
        Logger log = Logger.getInstance();
        HotelFare hotel = new HotelFare();

        public Hotel()
        {
            fare = hotel.Discout(fare);
        }
        public string GetTypeOfProduct(string databaseOperation)
        {
            return "Hotel";
        }
        public void Book(string databaseOperation)
        {
            log.write("\nBooking Hotel Product");
            string data = "HotelId: " + hotelId + ", HotelName: " + hotelName + ",  HotelAddress : " + hotelAddress + ", Fare: " + fare+" , RoomsAvailable : "+roomsAvailable + " IsBooked :" + IsBooked;
            data = "\nBooking Hotel :- " + data;
            dtype.GetDatabasetype(data, databaseOperation);
            Console.WriteLine("Booking Hotel");
            IsBooked = true;
        }
        public void Save(string databaseOperation)
        {
            log.write("\nSaving Hotel Product");
            string data = "HotelId: " + hotelId + ", HotelName: " + hotelName + ",  HotelAddress : " + hotelAddress + ", Fare: " + fare + " , RoomsAvailable : " + roomsAvailable + " IsBooked :" + IsBooked;
            data = "\nSaving Hotel details :- " + data;
            dtype.GetDatabasetype(data, databaseOperation);
            Console.WriteLine("Saving Hotel details");
        }
    }
}
