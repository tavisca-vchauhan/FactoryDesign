using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Hotel: GetProduct
    {
        public new IProduct GetProductType(string desc)
        {
            return new HotelProduct();
        }
    }
}
