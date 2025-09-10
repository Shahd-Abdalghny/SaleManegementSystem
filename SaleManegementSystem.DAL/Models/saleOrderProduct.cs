using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.DAL.Models
{
    public class saleOrderProduct
    {
        public double productPrice {  get; set; }
        public double productQuantity { get; set; }
        public double ProductTotalPrice { get; set; }
        public int productId { get; set; }
        public int OrderId { get; set; }
    }
}
