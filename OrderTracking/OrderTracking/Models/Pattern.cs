using System.ComponentModel.DataAnnotations;

namespace OrderTracking.Models
{
    public class Pattern
    {
        [Key]
        public int PatternId { get; set; }
        [StringLength(25)]
        public string PatternName { get; set; }
    }
}
