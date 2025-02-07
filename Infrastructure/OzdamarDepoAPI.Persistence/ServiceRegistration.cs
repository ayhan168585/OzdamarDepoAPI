using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OzdamarDepoAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<OzdamarDepoAPIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=12345;Host=localhost;Port=5432;Database=OzdamarDepoAPIDb"));
        }
    }
}
