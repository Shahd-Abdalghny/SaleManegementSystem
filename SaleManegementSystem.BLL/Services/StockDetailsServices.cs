using SaleManegementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.BLL.Services
{
    public class StockDetailsServices
    {

        public static string AddStockDetailsGetCommand(stockDetails details)
        {
            string command = $"INSERT INTO StockDetails (STOCKID,TYPE,TOTAL,DATE,ORDERID) VALUES ({details.stockId},{(int)details.type},{details.Total},'{details.Date}',{details.OrderId});";
           return command ;
        }
    }
}
