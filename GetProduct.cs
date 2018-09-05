using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class GetProduct
    {
        public IProduct GetProductType(string desc)
        {
            System.Type[] types = System.Reflection.Assembly.GetExecutingAssembly().GetTypes();
            System.Type[] possible = (from System.Type type in types where type.IsSubclassOf(typeof(GetProduct)) select type).ToArray();
            foreach(Type name in possible)
            {
                string Name = name.ToString();
                string []temp = Name.Split('.');
                Name = temp[1];
                if(Name==desc)
                {
                    Type type = Type.GetType(name.ToString(), true);
                    IProduct product = (IProduct)Activator.CreateInstance(type);
                    string cr = product.GetTypeOfProduct();
                    return product;
                }            
            }
            return new WrongProduct();
        }
    }
}
