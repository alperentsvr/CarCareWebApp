using CarCare.Application.Interfaces.Repositories;
using CarCare.Persistence.Contexts;
using CarCare.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace CarCare.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection s, IConfiguration c)
        {
            s.AddDbContext<CarCareDbContext>(o => o.UseNpgsql(c.GetConnectionString("DefaultConnection")));
            s.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}