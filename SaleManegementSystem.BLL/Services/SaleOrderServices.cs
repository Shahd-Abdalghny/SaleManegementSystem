using SaleManegementSystem.BLL.Dtos;
using SaleManegementSystem.DAL;
using SaleManegementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.BLL.Services
{
    public class SaleOrderServices
    {

        public static int GetLastOrderID()
        {
            int saleOrder = DataBaseHelperDapper.QuerySingleOrDefault<int>("select ISNULL(Max(id),0) as LastOrderID from SaleOrder");

            return saleOrder;
         
        }
        public static bool AddSaleOrder(saleOrder SaleOrder)
        {
            bool Result = DataBaseHelper.ExecuteDML($"INSERT INTO SaleOrders (ID,DATEORDER,CUSTOMERID,TOTALORDER) VALUES ({SaleOrder.id},'{SaleOrder.DateOrder}',{SaleOrder.CustomerId},{SaleOrder.TotalOrder})");
            return Result;
        }

        public static string AddSaleOrderGetCommand(saleOrder SaleOrder)
        {
            string commend = $"INSERT INTO SaleOrder (ID,DATEORDER,CUSTOMERID,TOTALORDER) VALUES ({SaleOrder.id},'{SaleOrder.DateOrder}',{SaleOrder.CustomerId},{SaleOrder.TotalOrder});";
            return commend;
        }

        public static List<SaleOrderReadProductDto> GetAllSaleOrderDateRange (DateTime stratDate , DateTime endDate)
        {
            List<SaleOrderReadProductDto> dateTable = DataBaseHelperDapper
                .Query<SaleOrderReadProductDto>($"SELECT  S.OrderId , C.NAME , P.NAME , S.productPrice ,S.productQuantity ,S.ProductTotalPrice " +
                $" FROM saleOrderProduct S , customer C , product P , saleOrder SO " +
                $"WHERE S.productId = P.ID AND C.ID =SO.CustomerId AND " +
                $"S.OrderId = SO.ID  " +
                $" AND SO.DateOrder BETWEEN  '{stratDate}' AND '{endDate}'");
             return dateTable;
                

        }

        public static List<SaleOrderReadProductDto> GetAllSaleOrderWithCutomerName(string pattern)
        {
            List<SaleOrderReadProductDto> dateTable = DataBaseHelperDapper
    .Query<SaleOrderReadProductDto>($"SELECT  S.OrderId AS SaleOrderID , C.NAME AS CustomerName , P.NAME AS ProductName , S.productPrice AS ProductPrice ,S.productQuantity AS ProductQuantity,S.ProductTotalPrice AS ProductTotalPrice" +
    $" FROM saleOrderProduct AS S , customer C , product P , saleOrder SO " +
    $"WHERE  S.productId = P.ID AND C.ID = SO.CustomerId AND S.OrderId = SO.ID AND C.NAME LIKE N'%{pattern}%'");
            return dateTable;


        }

        public static List<SaleOrderReadProductDto> GetAllSaleOrderWithOrderID(int id)
        {
            List<SaleOrderReadProductDto> dateTable = DataBaseHelperDapper
                .Query<SaleOrderReadProductDto>($"SELECT  S.OrderId AS SaleOrderID , C.NAME AS CustomerName , P.NAME AS ProductName , S.productPrice AS ProductPrice ,S.productQuantity AS ProductQuantity,S.ProductTotalPrice AS ProductTotalPrice" +
                $" FROM saleOrderProduct AS S , customer C , product P , saleOrder SO " +
                $"WHERE  S.productId = P.ID AND C.ID = SO.CustomerId AND S.OrderId = SO.ID  AND S.OrderId={id}");
            return dateTable;


        }


        public static List<SaleOrderReadProductDto> GetAllSaleOrder()
        {
            List<SaleOrderReadProductDto> dateTable = DataBaseHelperDapper
                .Query<SaleOrderReadProductDto>($"SELECT  S.OrderId AS SaleOrderID , C.NAME AS CustomerName , P.NAME AS ProductName , S.productPrice AS ProductPrice ,S.productQuantity AS ProductQuantity,S.ProductTotalPrice AS ProductTotalPrice" +
                $" FROM saleOrderProduct AS S , customer C , product P , saleOrder SO " +
                $"WHERE  S.productId = P.ID AND C.ID = SO.CustomerId AND S.OrderId = SO.ID  ");
            return dateTable;


        }


        public static bool InsertSaleOrderTransaction(
            List<Product> products,
            Stock stock,
            saleOrder saleOrder,
            List<saleOrderProduct> saleOrders,
            stockDetails details
            )
        { 
         List<string> commends = new List<string>();
            //Update Product Quantitys -
            string updateProductMinusCommand =ProductServices.UpdateProductMinusGetCommand(products);
            commends.Add(updateProductMinusCommand);

            //Update Stock TotalMony

            string updateStockPlusCommand = StockServices.UpdateStockPlusGetCommand(stock);
            commends.Add(updateStockPlusCommand);

            //insert saleOrder

            string addSaleOrderGetCommand = AddSaleOrderGetCommand(saleOrder);
            commends.Add(addSaleOrderGetCommand);

            //insert sale order product
             
            string addSaleOrderProductGetCommand = SaleOrderProductServices.AddSaleOrderProductGetCommand(saleOrders);
            commends.Add(addSaleOrderProductGetCommand);

            //insert stockdetails
            string addStockDetailsGetCommand = StockDetailsServices.AddStockDetailsGetCommand(details);
            commends.Add (addStockDetailsGetCommand);
            bool result = DataBaseHelper.ExecuteTransaction(commends);
            return result;

        }
    }
}
