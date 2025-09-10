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
    public class CategoryServices
    {
        //GetAllCategory
        public static List<Category> GetCategorys()
        {

            DataTable dataTable = DataBaseHelper.ExecuteSelect("select * from Category");
            List<Category> list = new List<Category>();
            foreach (DataRow row in dataTable.Rows)
            {
                Category Category = new Category();
                Category.Id = (int)row["ID"];
                Category.Name = (string)row["NAME"];
                list.Add(Category);
            }
            return list;

        }
        public static List<CategoryReadBasicDto> GetAllCategoryBasic()
        {
            return DataBaseHelperDapper.Query<CategoryReadBasicDto>("select Id , Name from Category");
        }
        public static List<Category> GetCategorysByPattern(string pattern)
        {

            DataTable dataTable = DataBaseHelper.ExecuteSelect($"select * from Category where Name Like N'%{pattern}%'");
            List<Category> list = new List<Category>();
            foreach (DataRow row in dataTable.Rows)
            {
                Category Category = new Category();
                Category.Id = (int)row["ID"];
                Category.Name = (string)row["NAME"];
                list.Add(Category);
            }
            return list;

        }
        //GetBYId
        public static Category GetById(int id)
        {
            var p = DataBaseHelper.ExecuteSelect($"SELECT * FROM Category WHERE ID ={id}");
            if (p.Rows.Count == 0)
                return null;
            var row = p.Rows[0];

            return new Category
            {
                Id = (int)row["ID"],
                Name = (string)row["NAME"]

            };

        }
        //AddCategory
        public static bool AddCategory(Category Category)
        {
            return DataBaseHelper.ExecuteDML($"INSERT INTO Category(NAME) VALUES (N'{Category.Name}')");
        }

        //Delete
        public static bool DeleteCategory(int ID)
        {
            return DataBaseHelper.ExecuteDML($"DELETE FROM Category WHERE ID= {ID}");
        }
        //UpdateCategory
        public static bool UpdateCategory(Category Category)
        {
            return DataBaseHelper.ExecuteDML($"Update Category SET NAME=N'{Category.Name}' WHERE  ID= {Category.Id}");
        }
        public static bool DeleteAllCategory()
        {
            return DataBaseHelper.ExecuteDML($"DELETE FROM Category");
        }

    }
}
