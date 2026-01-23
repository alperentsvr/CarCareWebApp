using CarCare.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarCare.Domain.Entities.Catalog
{
    public class ProductPartPrice : BaseEntity
    {
        public string PartName { get; set; } // Örn: "Kaput", "Sol Çamurluk", "Komple Araç"

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } // Örn: 3000

        public bool IsExtra { get; set; } = false; // Senin istediðin bool kontrolü (Ek parça mý?)

        // Ýliþkiler
        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; }
    }
}