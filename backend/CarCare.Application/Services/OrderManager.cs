using CarCare.Application.Interfaces.Repositories;
using CarCare.Application.Interfaces.Services;
using CarCare.Domain.Entities;
using System.Threading.Tasks;

namespace CarCare.Application.Services
{
    public class OrderManager : IOrderService
    {
        private readonly IGenericRepository<ServiceTransaction> _repository;
        private readonly IGenericRepository<ServiceTransactionItem> _itemRepository;

        public OrderManager(IGenericRepository<ServiceTransaction> repository, IGenericRepository<ServiceTransactionItem> itemRepository)
        {
            _repository = repository;
            _itemRepository = itemRepository;
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task UpdateItemPriceAsync(int itemId, decimal newPrice)
        {
            var item = await _itemRepository.GetByIdAsync(itemId);
            if (item != null)
            {
                item.Price = newPrice;
                await _itemRepository.UpdateAsync(item);
            }
        }

        public async Task DeleteItemAsync(int itemId)
        {
            await _itemRepository.DeleteAsync(itemId);
        }
    }
}
