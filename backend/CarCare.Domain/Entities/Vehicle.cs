using CarCare.Domain.Common;
using System.Collections.Generic;

namespace CarCare.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string PlateNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public string? Color { get; set; }

        // DÝKKAT: Burasý int olmalý. Eðer string ise 'int Year' yap.
        public int Year { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ServiceTransaction> ServiceTransactions { get; set; }
    }
}