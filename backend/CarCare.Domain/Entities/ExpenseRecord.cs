using CarCare.Domain.Common;
using System;

namespace CarCare.Domain.Entities
{
    public class ExpenseRecord : BaseEntity
    {
        public string Title { get; set; }       // Baþlýk (Örn: Kira, Elektrik, Bahþiþ)
        public string Description { get; set; } // Detaylý Açýklama
        public decimal Amount { get; set; }     // Tutar

        // 1: Gelir (Income), 0: Gider (Expense)
        // Veritabanýnda bool tutmak daha performanslýdýr (True: Gelir, False: Gider)
        // Ancak senin isteðin üzerine integer gibi davranan bir mantýk kuracaðýz.
        public bool IsIncome { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}