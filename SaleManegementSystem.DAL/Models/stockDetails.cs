using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.DAL.Models
{
    public enum Type
    {
        Sale,
        Purechase,
        Expenses
    }
    public class stockDetails
    {
        public int Id { get; set; }
        public int stockId {  get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public Type type { get; set; }
    }
}
