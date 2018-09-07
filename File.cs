using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class File : GetDatabaseType, IDatabase
    {
        public void AddProduct(string data)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\FileData.txt", true)) 
            {
                file.WriteLine(data);
            }
        }

    }
}
