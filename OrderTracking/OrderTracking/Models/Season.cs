using System.ComponentModel.DataAnnotations;

namespace OrderTracking.Models
{
    public class Season
    {
        [Key]
        public int SeasonId { get; set; }
        [StringLength(25)]
        public string SeasonName { get; set; }
    }
}
