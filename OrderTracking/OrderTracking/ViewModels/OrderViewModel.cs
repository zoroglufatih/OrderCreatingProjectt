using System;
using System.Collections.Generic;
using OrderTracking.Models;

namespace OrderTracking.ViewModels
{
    public class OrderViewModel
    {
        public int OrderNumber { get; set; }
        public int CountryId { get; set; }
        public DateTime Termin { get; set; }
        public int ProductId { get; set; }
        public int PatternId { get; set; }
        public int SeasonId { get; set; }
        public int ColorId { get; set; }
        public int SizeSetId { get; set; }
        public List<Size> Sizes { get; set; }
        public List<int> Quantities { get; set; }
    }
}
