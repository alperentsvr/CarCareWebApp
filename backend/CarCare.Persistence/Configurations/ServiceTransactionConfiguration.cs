using CarCare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCare.Persistence.Configurations
{
    public class ServiceTransactionConfiguration : IEntityTypeConfiguration<ServiceTransaction>
    {
        public void Configure(EntityTypeBuilder<ServiceTransaction> builder)
        {
            // Araç Ýliþkisi
            builder.HasOne(x => x.Vehicle)
                   .WithMany(x => x.ServiceTransactions)
                   .HasForeignKey(x => x.VehicleId);

            // DÜZELTME: Personel ile artýk Çoka-Çok iliþki var
            // Eðer burada eski .HasOne(x => x.Personnel) kodu varsa HATA VERÝR.
            builder.HasMany(x => x.Personnels)
                   .WithMany(x => x.ServiceTransactions);


        }
    }
}