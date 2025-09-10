using SaleManegementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.BLL.Services
{
    public class SaleOrderProductServices
    {


        public static string AddSaleOrderProductGetCommand (List<saleOrderProduct> saleOrders)
        {
            StringBuilder cd = new StringBuilder ();

            foreach (saleOrderProduct product in saleOrders)
            {
                cd.Append($"({product.productPrice},{product.productQuantity},{product.ProductTotalPrice},{product.OrderId},{product.productId}),");
            }
            string cmd = cd.ToString ().TrimEnd(',');
            string command = $"INSERT INTO SaleOrderProduct (ProductPrice,ProductQuantity,ProductTotalPrice,OrderID,ProductID) VALUES {cmd};";

            return command;
        }
    }
}
