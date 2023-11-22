using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeShop
{
    public class DataService
    {

        public static void SaveOrder(string item, int quantity, int price, int total)
        {
            using (IDbConnection db = GetOpenConnection())
            {
                string query = "INSERT INTO Orders (Item, Quantity, Price, TotalBill) VALUES (@Item, @Quantity, @Price, @TotalBill)";

                // Create an instance of the Order class with values
                var order = new Order { Item = item, Quantity = quantity, Price = price, TotalBill = total };

                
                db.Execute(query, order);
            }
        }

        public static List<Order> GetOrderData()
        {
            using (IDbConnection db = GetOpenConnection())
            {
                return db.Query<Order>("SELECT * FROM Orders").ToList();
            }
        }

        private static IDbConnection GetOpenConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            IDbConnection db = new SqlConnection(conn);

            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }

            return db;
        }


    }
}
