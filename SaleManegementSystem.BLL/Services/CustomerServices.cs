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
    public class CustomerServices
    {
        //GetAllCustomer
        public static List<Customer> GetCustomers()
        {

            DataTable dataTable = DataBaseHelper.ExecuteSelect("select * from Customer");
            List<Customer> list = new List<Customer>();
            foreach (DataRow row in dataTable.Rows)
            {
                Customer Customer = new Customer();
                Customer.Id = (int)row["ID"];
                Customer.Name = (string)row["NAME"];
                Customer.Address = (string)row["Address"];
                Customer.phoneNumber = (string)row["phoneNumber"];
                Customer.BirthDate = (DateTime)row["BirthDate"];

                list.Add(Customer);
            }
            return list;

        }
        public static List<CustomerReadBasicDto> GetAllCustomerBasic()
        {
            return DataBaseHelperDapper.Query<CustomerReadBasicDto>("select Id , Name from Customer");
        }
        public static List<Customer> GetCustomersByPattern(string pattern)
        {

            DataTable dataTable = DataBaseHelper.ExecuteSelect($"select * from Customer where Name Like N'%{pattern}%' or Address Like N'%{pattern}%'");
            List<Customer> list = new List<Customer>();
            foreach (DataRow row in dataTable.Rows)
            {
                Customer Customer = new Customer();
                Customer.Id = (int)row["ID"];
                Customer.Name = (string)row["NAME"];
                Customer.Address = (string)row["Address"];
                Customer.phoneNumber = (string)row["phoneNumber"];
                Customer.BirthDate = (DateTime)row["BirthDate"];
                list.Add(Customer);
            }
            return list;

        }
        //GetBYId
        public static Customer GetById(int id)
        {
            var p = DataBaseHelper.ExecuteSelect($"SELECT * FROM Customer WHERE ID ={id}");
            if (p.Rows.Count == 0)
                return null;
            var row = p.Rows[0];

            return new Customer
            {
                Id = (int)row["ID"],
                Name = (string)row["NAME"],
                Address = (string)row["Address"],
                phoneNumber = (string)row["phoneNumber"],
                BirthDate = (DateTime)row["BirthDate"]

            };

        }
        //AddCustomer
        public static bool AddCustomer(Customer Customer)
        {
            return DataBaseHelper.ExecuteDML($"INSERT INTO Customer(NAME,Address,phoneNumber,BirthDate) VALUES (N'{Customer.Name}',N'{Customer.Address}',N'{Customer.phoneNumber}',N'{Customer.BirthDate}')");
        }

        //Delete
        public static bool DeleteCustomer(int ID)
        {
            return DataBaseHelper.ExecuteDML($"DELETE FROM Customer WHERE ID= {ID}");
        }
        //UpdateCustomer
        public static bool UpdateCustomer(Customer Customer)
        {
            return DataBaseHelper.ExecuteDML($"Update Customer SET NAME=N'{Customer.Name}' ,Address=N'{Customer.Address}',phoneNumber=N'{Customer.phoneNumber}',BirthDate=N'{Customer.BirthDate}' WHERE  ID= {Customer.Id}");
        }
        public static bool DeleteAllCustomer()
        {
            return DataBaseHelper.ExecuteDML($"DELETE FROM Customer");
        }

    }
}
