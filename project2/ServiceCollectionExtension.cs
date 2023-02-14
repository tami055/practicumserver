using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using project.Repositories;
using project2.Entities;
using project2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
   public static class ServiceCollectionExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDataRepository<User>, UserRepositories>();
            services.AddScoped<IDataRepository<Child>, ChildRepositories>();
        }
    }
}
