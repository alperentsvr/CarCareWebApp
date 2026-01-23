using System;

namespace CarCare.Domain.Common
{
    /// <summary>
    /// Tüm veritabaný tablolarýnýn (Entity) miras alacaðý temel sýnýf.
    /// Kod tekrarýný önlemek için ID ve Tarih gibi ortak alanlarý burada tutuyoruz.
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; } // Birincil Anahtar (Primary Key)
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // Kayýt oluþturulma zamaný

        // Veriyi fiziksel olarak silmek yerine gizlemek için (Soft Delete)
        public bool IsDeleted { get; set; } = false;
    }
}