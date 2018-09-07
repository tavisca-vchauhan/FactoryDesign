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
        public string GetTypeOfProduct(string operationChoice)
        {
            return "activity";
        }
        public void Book(string operationChoice , string schema)
        {
            log.write("Booking Activity Product");
            string value = "activityId:" + activityId + ",activityName:" + activityName + ",activityDuration:" + activityDuration + ",cost:" + cost +",IsBooked:"+IsBooked;
            dtype.GetDatabasetype(value, operationChoice, schema);
            Console.WriteLine("Booking Activity products");
            IsBooked = true;
        }
        public void Save(string operationChoice, string schema)
        {
            log.write("Saving Activity Product");
            string value = "activityId:" + activityId + ",activityName:" + activityName + ",activityDuration:" + activityDuration + ",cost:" + cost + ",IsBooked:" + IsBooked;
            dtype.GetDatabasetype(value, operationChoice, schema);
            Console.WriteLine("Saving activity product");
        }
    }
}