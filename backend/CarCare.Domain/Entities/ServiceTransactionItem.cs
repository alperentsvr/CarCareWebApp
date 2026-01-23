using CarCare.Domain.Common;

namespace CarCare.Domain.Entities
{
    public class ServiceTransactionItem : BaseEntity
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // YENÝ: Parçalarý veritabanýnda uzun bir yazý olarak tutacaðýz
        // Örn: "Kaput, Tavan, Bagaj"
        public string SelectedParts { get; set; }

        public int ServiceTransactionId { get; set; }
        public ServiceTransaction ServiceTransaction { get; set; }
    }
}