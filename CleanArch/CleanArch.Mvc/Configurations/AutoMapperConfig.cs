﻿using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Mvc.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArch.Application.AutoMapper.AutoMapperConfiguration));
            CleanArch.Application.AutoMapper.AutoMapperConfiguration.RegisterMappings();
        }
    }
}
