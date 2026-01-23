using CarCare.Domain.Common;

namespace CarCare.Domain.Entities
{
    // Sisteme giriþ yapacak yetkili kullanýcýlar (Admin ve Personel)
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Þifreler hashlenmiþ tutulur
        public string FullName { get; set; }
        public string Role { get; set; } // Yetki Seviyesi: "Admin" veya "Staff"
        public int FailedLoginAttempts { get; set; }
        public DateTime? LockoutEnd { get; set; }
    }
}