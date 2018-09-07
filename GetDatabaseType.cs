using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class GetDatabaseType
    {
        public void GetDatabasetype(string data, string databaseOperation , string schema)
        {
            Logger log = Logger.getInstance();
            Type type1;
            int count = 0;
            System.Type[] types = System.Reflection.Assembly.GetExecutingAssembly().GetTypes();
            System.Type[] possible = (from System.Type type in types where type.IsSubclassOf(typeof(GetDatabaseType)) select type).ToArray();
            foreach (Type name in possible)
            {
                string Name = name.ToString();
                string[] temp = Name.Split('.');
                Name = temp[1];
                if (Name == databaseOperation)
                {
                    count++;
                    type1 = Type.GetType(name.ToString(), true);
                    log.write("\nSelecting "+ databaseOperation + " to write data");
                    ConstructorInfo constructor = type1.GetConstructor(Type.EmptyTypes);
                    object classObj = constructor.Invoke(new object[] { });
                    MethodInfo method = type1.GetMethod("AddProduct");
                    log.write("\nInvoking "+ databaseOperation);
                    method.Invoke(classObj, new object[] { data,schema});
                }
            }
            if (count == 0)
            {
                Console.WriteLine("You have entered wrong 'product-type' OR 'Operation-type' ");
            }
        }
    }
}
