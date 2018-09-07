using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Factory
{
    class Logger
    {
        private static Logger _logger = null;
        private static Object _lock = typeof(Logger);
        int count = 0;
        public static Logger getInstance()
        {
            //lock object to make it thread safe  
            lock (_lock)
            {
                if (_logger == null)
                {
                    _logger = new Logger();

                }
            }
            return _logger;
        }

        public void write(string detailedLog)
        {

            FileStream fs = new FileStream(@"C:\Log.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            if(count==0)
            {
                sw.WriteLine(detailedLog);
            }
            else
            {
                sw.WriteLine(" - " + detailedLog);
            }
            count++;
            sw.Flush();

            sw.Close();

            fs.Close();
        }
    }
}