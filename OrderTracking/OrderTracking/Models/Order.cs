using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderTracking.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int CountryId { get; set; }
        public DateTime Termin { get; set; } //?
        public DateTime CreatedDate { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        
    }
}
