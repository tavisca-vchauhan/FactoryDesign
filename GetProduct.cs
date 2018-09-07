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
        public void GetProductType(string desc , String Operation,string databaseOperation)
        {
            IProduct product;
            Type type1;
            int count = 0;
            Logger log = Logger.getInstance();
            System.Type[] types = System.Reflection.Assembly.GetExecutingAssembly().GetTypes();
            System.Type[] possible = (from System.Type type in types where type.IsSubclassOf(typeof(GetProduct)) select type).ToArray();
            log.write("\nMoved into GetProduct");
            foreach(Type name in possible)
            {
                string Name = name.ToString();
                string []temp = Name.Split('.');
                Name = temp[1];
                if (Name == desc)
                {
                    count++;
                    type1 = Type.GetType(name.ToString(), true);
                    product = (IProduct)Activator.CreateInstance(type1);
                    ConstructorInfo constructor = type1.GetConstructor(Type.EmptyTypes);
                    object classObj = constructor.Invoke(new object[] { });
                    MethodInfo method = type1.GetMethod(Operation);
                    log.write("\nCreating instance of Product-Type { "+Name+" } class");
                    method.Invoke(classObj, new object[] {databaseOperation,Name });
                }
            }
            if(count==0)
            {
                Console.WriteLine("You have entered wrong 'product-type' OR 'Operation-type' ");
            }
        }
    }
}
