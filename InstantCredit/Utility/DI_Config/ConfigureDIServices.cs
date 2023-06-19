using InstantCredit.Data.Repository.IRepository;
using InstantCredit.Models;
using InstantCredit.Service;
using InstantCredit.Service.LifeTimeExample;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Utility.DI_Config
{
    public static class ConfigureDIServices
    {
        public static IServiceCollection AddAllServices(this IServiceCollection services)
        {
            services.AddScoped<IValidationChecker, AddressValidationChecker>();
            services.AddScoped<IValidationChecker, CreditValidationChecker>();
            services.AddScoped<ICreditValidator, CreditValidator>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //Conditional Implementation
            services.AddScoped<CreditApprovedHigh>();
            services.AddScoped<CreditApprovedLow>();

            services.AddScoped<Func<CreditApprovedEnum, ICreditApproved>>(ServiceProvider => range =>
            {
                switch (range)
                {
                    case CreditApprovedEnum.High: return ServiceProvider.GetService<CreditApprovedHigh>();
                    case CreditApprovedEnum.Low: return ServiceProvider.GetService<CreditApprovedLow>();
                    default: return ServiceProvider.GetService<CreditApprovedLow>();
                }
            });

            services.AddTransient<IMarketForecaster, MarketForecasterV2>();
            services.AddTransient<TransientService>();
            services.AddScoped<ScopedService>();
            services.AddSingleton<SingletonService>();

            //avoid duplicated implementations
            //services.TryAddEnumerable(ServiceDescriptor.Scoped<IValidationChecker, CreditValidationChecker>());
            //services.TryAddEnumerable(new[]{
            //    ServiceDescriptor.Scoped<IValidationChecker, CreditValidationChecker>(),
            //     ServiceDescriptor.Scoped<IValidationChecker, AddressValidationChecker>()
            //});

            return services;
        }
    }
    
}
