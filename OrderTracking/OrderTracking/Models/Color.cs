using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderTracking.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        [StringLength(25)]
        public string ColorName { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
