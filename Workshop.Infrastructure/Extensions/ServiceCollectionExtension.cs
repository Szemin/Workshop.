using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Infrastructure.Persistence;

namespace Workshop.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {           

            services.AddDbContext<WorkshopDbContext>(options
                 => options.UseSqlServer(configuration.GetConnectionString("WorkshopConnectionString")));
        }
    }
}
