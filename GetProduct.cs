using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class GetProduct
    {
        public virtual IProduct GetProductType()
        {
            
            return new WrongProduct();
        }

    }
}
