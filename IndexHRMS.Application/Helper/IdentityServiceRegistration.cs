using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IndexHRMS.Application.Helper
{
    public static class IdentityServiceRegistration
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services, IConfiguration configuration)
        {
            const string openIdConnectAuthenticationScheme = OpenIdConnectDefaults.AuthenticationScheme;
            var openIdConfig = configuration.GetSection("HRMS");
            var authority = $"{openIdConfig["Authority"]}";
            var tokenEndpoint = $"{authority}{openIdConfig["TokenEndpointPath"]}";
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddOpenIdConnect(
                openIdConnectAuthenticationScheme, options =>
                {
                    options.Authority = authority;

                    options.ClientId = openIdConfig["ClientId"];
                    options.ClientSecret = openIdConfig["TokenKey"];
                }
                )
                 .AddJwtBearer(options =>
                 {
                     options.TokenValidationParameters = new TokenValidationParameters
                     {
                         ValidateIssuerSigningKey = true,
                         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(openIdConfig["TokenKey"])),
                         ValidateIssuer = false,
                         ValidateAudience = false
                     };
                 });
            return services;
        }
    }
}
