using CarCare.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarCare.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T e);
        Task UpdateAsync(T e);
        Task DeleteAsync(T e);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);

        // Hata veren kýsým burasýydý, bu satýrý kesinlikle ekle:
        Task<List<T>> GetAsync(Expression<Func<T, bool>> p);
        // Mevcut metotlarýn yanýna ekle
        Task<List<T>> GetAllAsync(params System.Linq.Expressions.Expression<Func<T, object>>[] includes);
    }
}