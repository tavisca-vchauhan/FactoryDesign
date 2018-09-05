using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class GetCarProduct : GetProduct
    {
        public override IProduct GetProductType()
        {
            return new CarProduct();
        }
    }
}
