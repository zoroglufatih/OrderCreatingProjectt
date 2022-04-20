using System.ComponentModel.DataAnnotations;

namespace OrderTracking.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [StringLength(25)]
        public string CountryName { get; set; }
    }
}
