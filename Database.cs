using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Database : GetDatabaseType, IDatabase
    {
         Logger log = Logger.getInstance();
        public void AddProduct(string data, string schema)
        {
            string[] storedValue = data.Split(',');
            string query = "";
            string queryData = "";
            foreach (string response in storedValue)
            {
                string[] key = response.Split(':');
                Console.WriteLine(key[0] + ": " + key[1]);
                query += "@" + key[0] + ",";
                queryData += key[1] + ",";
            }
            int len = query.Length - 1;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=TAVDESK013;Initial Catalog=Travel;Integrated Security=True";
            query = query.Remove(len, 1);
            string con = "insert into " + schema + " values(" + query + ")";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into " + schema + " values(" + query + ")", connection);
            string[] col = query.Split(',');
            string[] colValue = queryData.Split(',');
            for (int index = 0; index < col.Length; index++)
            {
                sqlCommand.Parameters.AddWithValue(col[index], colValue[index]);
            }
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            log.write("Saving data into SQL-database");

        }
    }
}
