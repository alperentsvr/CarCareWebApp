using CarCare.Domain.Common;
using System.Collections.Generic;

namespace CarCare.Domain.Entities.Catalog
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        // Yeni Mantýk: Micron var mý?
        public bool HasMicron { get; set; } = false;

        // Micron yoksa fiyat buraya girilir
        public decimal BasePrice { get; set; } = 0;

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductVariant> Variants { get; set; }
    }
}