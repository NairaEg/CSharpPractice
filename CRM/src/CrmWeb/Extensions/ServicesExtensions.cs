using Crm.Services;
using Crm.Services.Impl;

namespace CrmWeb.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddCrmServices(this IServiceCollection services)
        {
            services.AddScoped<ITaskService, TaskService>();
        }
    }
}
