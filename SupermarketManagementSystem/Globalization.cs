using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem
{
    public static class Globalization
    {
        private static SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Supermarket;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public static List<int> ListOfIDFromDB(string nameDB)
        {
            string query = $"SELECT * FROM dbo.{nameDB}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable table = dataSet.Tables[0];
            List<int> listOfIDs = new List<int>();
            foreach (DataRow row in table.Rows)
            {
                listOfIDs.Add(Convert.ToInt32(row["ID"]));
            }

            return listOfIDs;
        }
    }
}
