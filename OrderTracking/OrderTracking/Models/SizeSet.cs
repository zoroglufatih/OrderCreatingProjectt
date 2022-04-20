using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderTracking.Models
{
    public class SizeSet
    {
        [Key]
        public int SizeSetId { get; set; }
        [StringLength(10)]
        public string SizeSetName { get; set; }  // S - XL veya S-M

        public List<SizeSetSize> SizeSetSizes { get; set; }

    }
}
