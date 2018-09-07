using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class File : GetDatabaseType, IDatabase
    {
        Logger log = Logger.getInstance();
        public void AddProduct(string value , string schema)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\FileData.txt", true)) 
            {
                log.write("Writing data into File");
                file.WriteLine(value);
            }
        }

    }
}
