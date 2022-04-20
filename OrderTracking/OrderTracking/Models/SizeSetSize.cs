using System.ComponentModel.DataAnnotations.Schema;

namespace OrderTracking.Models
{
    public class SizeSetSize
    {
        public int SizeId { get; set; }
        public int SizeSetId { get; set; }

        [ForeignKey(nameof(SizeId))]
        public Size Size { get; set; }
        [ForeignKey(nameof(SizeSetId))]
        public SizeSet SizeSet { get; set; }

    }
}
