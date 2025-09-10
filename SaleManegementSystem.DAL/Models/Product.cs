using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
