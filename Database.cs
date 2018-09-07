using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Database : GetDatabaseType, IDatabase
    {
        public void AddProduct(string data)
        {

        }
    }
}
