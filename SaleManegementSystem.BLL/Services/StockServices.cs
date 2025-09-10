using SaleManegementSystem.DAL;
using SaleManegementSystem.DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.BLL.Services
{
    public class StockServices
    {

        //GetAllStock
        public static List<Stock> GetStocks()
        {

            DataTable dataTable = DataBaseHelper.ExecuteSelect("select * from Stock");
            List<Stock> list = new List<Stock>();
            foreach (DataRow row in dataTable.Rows)
            {
                Stock Stock = new Stock();
                Stock.Id = (int)row["ID"];
                Stock.Name = (string)row["NAME"];
                Stock.TotalMoney = Convert.ToDecimal(row["TotalMoney"]);
                list.Add(Stock);
            }
            return list;

        }

        public static List<Stock> GetStocksByPattern(string pattern)
        {

            DataTable dataTable = DataBaseHelper.ExecuteSelect($"select * from Stock where Name Like N'%{pattern}%'");
            List<Stock> list = new List<Stock>();
            foreach (DataRow row in dataTable.Rows)
            {
                Stock Stock = new Stock();
                Stock.Id = (int)row["ID"];
                Stock.Name = (string)row["NAME"];
                Stock.TotalMoney = Convert.ToDecimal(row["TotalMoney"]);
                list.Add(Stock);
            }
            return list;

        }
        //GetBYId
        public static Stock GetById(int id)
        {
            var p = DataBaseHelper.ExecuteSelect($"SELECT * FROM Stock WHERE ID ={id}");
            if (p.Rows.Count == 0)
                return null;
            var row = p.Rows[0];

            return new Stock
            {
                Id = (int)row["ID"],
                Name = (string)row["NAME"],
                TotalMoney = Convert.ToDecimal(row["TotalMoney"])

            };

        }
        //AddStock
        public static bool AddStock(Stock Stock)
        {
            return DataBaseHelper.ExecuteDML($"INSERT INTO Stock(NAME,TotalMoney) VALUES (N'{Stock.Name}',{Stock.TotalMoney})");
        }

        //Delete
        public static bool DeleteStock(int ID)
        {
            return DataBaseHelper.ExecuteDML($"DELETE FROM Stock WHERE ID= {ID}");
        }
        //UpdateStock
        public static bool UpdateStock(Stock Stock)
        {
            return DataBaseHelper.ExecuteDML($"Update Stock SET NAME=N'{Stock.Name}' ,TotalMoney={Stock.TotalMoney} WHERE  ID= {Stock.Id}");
        }
        public static bool DeleteAllStock()
        {
            return DataBaseHelper.ExecuteDML($"DELETE FROM Stock");
        }

        public static string UpdateStockPlusGetCommand (Stock Stock)
        {
            string commend = $"UPDATE STOCK SET TOTALMONeY = TotalMoney + {Stock.TotalMoney} WHERE ID={Stock.Id};";
            return commend;
        }
    }
}
