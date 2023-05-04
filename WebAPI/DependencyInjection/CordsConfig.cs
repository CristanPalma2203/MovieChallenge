﻿namespace WebAPI.DependencyInjection
{
    public static class CordsConfig
    {
        public static void AddCorsConfig(this IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
            {
                builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
            }));
        }
    }
}
