namespace Presentation
{
    using Microsoft.Extensions.DependencyInjection;

    public static class DependancyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            return services;
        }
    }
}
