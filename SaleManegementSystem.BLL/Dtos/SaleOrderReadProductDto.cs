using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.BLL.Dtos
{
    public class SaleOrderReadProductDto
    {
        public int SaleOrderID { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductQuantity { get; set; }
        public decimal ProductTotalPrice{ get; set; }

    }
}
