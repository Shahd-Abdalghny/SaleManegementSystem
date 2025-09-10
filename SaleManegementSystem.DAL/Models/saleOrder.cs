using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.DAL.Models
{
    public class saleOrder
    {
        public int id {  get; set; }
        public int CustomerId { get; set; }

        public double TotalOrder { get; set; }
        public DateTime DateOrder { get; set; }
    }
}
