using System.Threading.Tasks;

namespace CarCare.Application.Interfaces.Services
{
    public interface IOrderService
    {
        Task DeleteOrderAsync(int id);
        Task UpdateItemPriceAsync(int itemId, decimal newPrice);
        Task DeleteItemAsync(int itemId);
    }
}
