using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderTracking.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(30)]
        public string ProductName { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
