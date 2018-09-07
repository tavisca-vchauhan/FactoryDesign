using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IProduct
    {
        string GetTypeOfProduct(string s);
        void Save(string s,string g);
        void Book(string s,string g);
    }
}
