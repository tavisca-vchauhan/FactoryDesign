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
        string hotelAddress = "Near Weikfield Viman-Nagar Pune Maharashtra";
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
        public string GetTypeOfProduct(string operationChoice)
        {
            return "Hotel";
        }
        public void Book(string operationChoice, string schema)
        {
            log.write("\nBooking Hotel Product");
            string value = "hotelId:" + hotelId + ",hotelName:" + hotelName + ",hotelAddress:" + hotelAddress + ",fare:" + fare+",roomsAvailable:"+roomsAvailable + ",IsBooked:" + IsBooked;
            IsBooked = true;
            dtype.GetDatabasetype(value, operationChoice, schema);
            Console.WriteLine("Booking Hotel");
        }
        public void Save(string operationChoice, string schema)
        {
            log.write("\nSaving Hotel Product");
            string value = "hotelId:" + hotelId + ",hotelName:" + hotelName + ",hotelAddress:" + hotelAddress + ",fare:" + fare + ",roomsAvailable:" + roomsAvailable + ",IsBooked:" + IsBooked;
            dtype.GetDatabasetype(value, operationChoice, schema);
            Console.WriteLine("Saving Hotel details");
        }
    }
}
