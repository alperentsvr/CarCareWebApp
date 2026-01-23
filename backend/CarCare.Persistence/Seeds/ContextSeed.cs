using CarCare.Domain.Entities;
using CarCare.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CarCare.Persistence.Seeds
{
    public static class ContextSeed
    {
        public static async Task SeedAsync(CarCareDbContext context)
        {
            // Seed logic removed as Materials and ServiceDefinitions are deleted.
            await context.SaveChangesAsync();
        }
    }
}