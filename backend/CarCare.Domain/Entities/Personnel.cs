using CarCare.Domain.Common;
using System;
using System.Collections.Generic;

namespace CarCare.Domain.Entities
{
    // Ýþletmede çalýþan personel
    public class Personnel : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; } // Örn: Usta, Kalfa
        public decimal Salary { get; set; }  // Maaþ Bilgisi
        public DateTime StartDate { get; set; }

        // Ýliþki: Bir personelin yaptýðý iþlemler listesi
        public ICollection<ServiceTransaction> ServiceTransactions { get; set; }
    }
}
