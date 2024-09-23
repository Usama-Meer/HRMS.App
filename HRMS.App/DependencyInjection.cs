using HRMS.Application;
using HRMS.Infrastructure;
namespace HRMS.App

{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI().AddInfrastructureDI();
            return services;
        }

    }
}
