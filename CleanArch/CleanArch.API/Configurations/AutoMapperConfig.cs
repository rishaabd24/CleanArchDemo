using Microsoft.Extensions.DependencyInjection;
using CleanArch.Application.AutoMapper;
namespace CleanArch.API.Configurations
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
