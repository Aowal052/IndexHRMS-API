﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexHRMS.Application.Interfaces;
using IndexHRMS.Infrastructure.Context;
using IndexHRMS.Infrastructure.Repositories;

namespace IndexHRMS.Infrastructure.Helper
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInsfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IAccountsRepository, AccountsRepository>();
            services.AddScoped<ITokenRepository, TokenRepository>();
			services.AddScoped<ITravelOnDutyRepository, TravelOnDutyRepository>();
			services.AddScoped<ITravelOnDutyInfoRepository, TravelOnDutyInfoRepository>();
			return services;
        }
    }
}
