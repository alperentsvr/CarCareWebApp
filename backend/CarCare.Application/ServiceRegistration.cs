using CarCare.Application.Interfaces.Services;
using CarCare.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using CarCare.Application.Mappings;
namespace CarCare.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection s)
        {
            s.AddAutoMapper(configuration => { configuration.AddProfile<GeneralMapping>(); });
            s.AddScoped<IAuthService, AuthManager>();
            s.AddScoped<IOrderService, OrderManager>(); 
            s.AddScoped<IPersonnelService, PersonnelManager>(); 
            s.AddScoped<IExpenseService, ExpenseManager>();
            s.AddScoped<ICatalogService, CatalogManager>();
            s.AddScoped<IDeletionRequestService, DeletionRequestManager>();
        }
    }
}
