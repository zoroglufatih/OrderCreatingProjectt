using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderTracking.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        [StringLength(5)]
        public string SizeName { get; set; }

        public List<SizeSetSize> SizeSetSizes { get; set; }
    }
}
