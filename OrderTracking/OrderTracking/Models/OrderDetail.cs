using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderTracking.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PatternId { get; set; }
        public int SeasonId { get; set; }
        public int ColorId { get; set; }
        public int SizeSetId { get; set; }
        public int SizeId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public ProductModel ProductModel { get; set; }
        [ForeignKey(nameof(PatternId))]
        public Pattern Pattern { get; set; }
        [ForeignKey(nameof(SeasonId))]
        public Season Season { get; set; }
        [ForeignKey(nameof(ColorId))]
        public Color Color { get; set; }
        [ForeignKey(nameof(SizeId))]
        public Size Size { get; set; }
        [ForeignKey(nameof(SizeSetId))]
        public SizeSet SizeSet { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }

    }
}
