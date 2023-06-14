using InstantCredit.Utility.AppSettingsClasses;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantCredit.Utility.DI_Config
{
    public static class DI_AppSettingsConfig
    {
        public static IServiceCollection AddAppSettingsConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<InstantForecastSettings>(configuration.GetSection("InstantForecast"));
            services.Configure<SendGridSettings>(configuration.GetSection("SendGrid"));
            services.Configure<StripeSettings>(configuration.GetSection("Stripe"));
            services.Configure<TwilioSettings>(configuration.GetSection("Twilio"));
            return services;
        }
    }
}
