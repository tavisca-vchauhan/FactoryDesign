using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Activity : GetProduct, IProduct
    {
        int activityId = 25;
        string activityName = "Concert";
        string activityDuration = "3 Hrs";
        int cost=750 ;
        Boolean IsBooked = false;
        GetDatabaseType dtype = new GetDatabaseType();
        Logger log = Logger.getInstance();
        ActivityFare activity = new ActivityFare();

        public Activity()
        {
            cost = activity.Discout(cost);
        }
        public string GetTypeOfProduct(string databaseOperation)
        {
            return "activity";
        }
        public void Book(string databaseOperation)
        {
            log.write("Booking Activity Product");
            string data = "ActivityId: " + activityId + ", ActivityName: " + activityName + ",  ActivityDuration : " + activityDuration + ", Cost : " + cost +" IsBooked :"+IsBooked;
            data = "\nBooking Activity products :- " + data;
            dtype.GetDatabasetype(data, databaseOperation);
            Console.WriteLine("Booking Activity products");
            IsBooked = true;
        }
        public void Save(string databaseOperation)
        {
            log.write("Saving Activity Product");
            string data = "ActivityId: " + activityId + ", ActivityName: " + activityName + ",  ActivityDuration : " + activityDuration + ", Cost : " + cost + " IsBooked :" + IsBooked;
            data = "\nSaving activity product :- " + data;
            dtype.GetDatabasetype(data, databaseOperation);
            Console.WriteLine("Saving activity product");
        }
    }
}