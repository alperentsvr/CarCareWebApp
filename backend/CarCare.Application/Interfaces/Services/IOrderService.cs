using CarCare.Application.DTOs;
using CarCare.Application.Wrappers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarCare.Application.Interfaces.Services
{
    public interface IOrderService
    {
        // Controller ve Manager ile uyumlu metodlar:

        Task<ServiceResponse<List<OrderListDto>>> GetAllOrdersAsync();

        Task<ServiceResponse<int>> CreateOrderAsync(CreateOrderDto request);

        // Hata veren "UpdateOrderDetailsAsync" metodu buraya eklendi:
        Task<ServiceResponse<bool>> UpdateOrderDetailsAsync(UpdateOrderDto request);

        Task<ServiceResponse<bool>> DeleteOrderAsync(int id);

        // Hata veren "SearchByPhoneOrPlateAsync" metodu buraya eklendi:
        Task<ServiceResponse<CustomerVehicleSearchDto>> SearchByPhoneOrPlateAsync(string text);

        // YENÝ: Item Bazlý Güncellemeler (Admin Onayý Sonrasý)
        Task<ServiceResponse<bool>> UpdateItemPriceAsync(int itemId, decimal newPrice);
        Task<ServiceResponse<bool>> DeleteItemAsync(int itemId);
    }
}