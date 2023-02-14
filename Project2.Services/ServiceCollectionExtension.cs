using Microsoft.Extensions.DependencyInjection;
using project.Repositories;
using project2;
using project2.Entities;
using project2.Interface;
using Project2.Common.DTOS;

using Project2.DBContext;
using Project2.Services.Interface;
using Project2.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
           services.AddRepositories();
            services.AddScoped<IDataService<DTOSUser>, UserService>();
            services.AddScoped<IDataService<DTOSChild>, ChildService>();
            services.AddSingleton<Icontext, MyDbContext>();
            services.AddAutoMapper(typeof(Mapping));
            return services;
        }

    }
}
