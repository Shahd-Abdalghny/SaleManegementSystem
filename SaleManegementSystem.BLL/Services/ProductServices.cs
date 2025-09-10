using SaleManegementSystem.BLL.Dtos;
using SaleManegementSystem.DAL;
using SaleManegementSystem.DAL.Models;
using SalesManagementSystem.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.BLL.Services
{
    public class ProductServices
    {
        //GetAllProduct
        public static List<Product> GetProducts()
        {

            DataTable dataTable = DataBaseHelper.ExecuteSelect("select * from Product");
            List<Product> list = new List<Product>();
            foreach (DataRow row in dataTable.Rows)
            {
                Product Product = new Product();
                Product.Id = (int)row["ID"];
                Product.Name = (string)row["NAME"];
                Product.BuyPrice = Convert.ToDecimal(row["BuyPrice"]);
                Product.SalePrice = Convert.ToDecimal(row["SalePrice"]);
                Product.Quantity = Convert.ToDecimal(row["Quantity"]);
                Product.CategoryId = (int)row["CategoryId"];
                list.Add(Product);
            }
            return list;

        }
        public static List<ProductReadBasicDto> GetAllPorductBasic()
        {
            return DataBaseHelperDapper.Query<ProductReadBasicDto>("select Id , Name from Product");
        }
        //GetBYId
        public static Product GetById(int id)
        {
            var p = DataBaseHelper.ExecuteSelect($"SELECT * FROM Product WHERE ID ={id}");
            if (p.Rows.Count == 0)
                return null;
            var row = p.Rows[0];

            return new Product
            {
                Id = (int)row["ID"],
                Name = (string)row["NAME"],
                 BuyPrice = Convert.ToDecimal(row["BuyPrice"]),
                SalePrice = Convert.ToDecimal(row["SALEPRICE"]),
                Quantity = Convert.ToDecimal(row["Quantity"]),
                CategoryId = (int)row["CategoryId"]
            };

        }
        //AddProduct
        public static bool AddProduct(Product Product)
        {
            return DataBaseHelper.ExecuteDML($"INSERT INTO Product(NAME,BuyPrice,SALEPRICE,Quantity,CategoryId) VALUES (N'{Product.Name}',{Product.BuyPrice},{Product.SalePrice},{Product.Quantity},{Product.CategoryId})");
        }

        //Delete
        public static bool DeleteProduct(int ID)
        {
            return DataBaseHelper.ExecuteDML($"DELETE FROM Product WHERE ID= {ID}");
        }
        //UpdateProduct
        public static bool UpdateProduct(Product Product)
        {
            return DataBaseHelper.ExecuteDML($"Update Product SET NAME=N'{Product.Name}',BuyPrice={Product.BuyPrice},SALEPRICE={Product.SalePrice},Quantity={Product.Quantity},CategoryId={Product.CategoryId} WHERE  ID= {Product.Id}");
        }

        public static bool DeleteAllProduct()
        {
            return DataBaseHelper.ExecuteDML($"DELETE FROM Product");
        }

        public static List<Product> GetProductsByPattern(string pattern)
        {

            DataTable dataTable = DataBaseHelper.ExecuteSelect($"select * from Product where Name Like N'%{pattern}%' or Quantity Like  N'%{pattern}%'");
            List<Product> list = new List<Product>();
            foreach (DataRow row in dataTable.Rows)
            {
                Product product = new Product();
                product.Id = (int)row["ID"];
                product.Name = (string)row["NAME"];
                product.BuyPrice = Convert.ToDecimal(row["BuyPrice"]);
                product.SalePrice = Convert.ToDecimal(row["SALEPRICE"]);
                product.Quantity = Convert.ToDecimal(row["Quantity"]);
                product.CategoryId = (int)row["CategoryId"];
                list.Add(product);
            }
            return list;

        }

        public static string UpdateProductMinusGetCommand(List<Product> products)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Product product in products)
            {
                stringBuilder.Append($"UPDATE PRODUCT SET QUANTITY = Quantity - {product.Quantity} WHERE ID={product.Id};");
                //stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
            
        }
    }
}
