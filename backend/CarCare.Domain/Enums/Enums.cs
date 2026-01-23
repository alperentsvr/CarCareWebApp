namespace CarCare.Domain.Enums
{
    // Ýþlemin ödenip ödenmediði durumu
    public enum PaymentStatus { Unpaid = 1, Paid = 2 }

    // Ýþlemin süreci (Bekliyor -> Ýþlemde -> Bitti)
    public enum TransactionStatus { Pending = 0, InProgress = 1, Completed = 2, Cancelled = 3 }

    // Ödeme Yöntemi (Muhasebe takibi için)
    public enum PaymentMethod
    {
        None = 0,           // Belirtilmedi
        Cash = 1,           // Nakit
        CreditCard = 2,     // Kredi Kartý
        EFT_Transfer = 3    // Havale / EFT
    }
}