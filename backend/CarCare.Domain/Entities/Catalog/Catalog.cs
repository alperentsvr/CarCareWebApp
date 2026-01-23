using CarCare.Domain.Common;

namespace CarCare.Domain.Entities.Catalog
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        // Kategoriye ait ürünler
        public ICollection<Product> Products { get; set; }
    }
}