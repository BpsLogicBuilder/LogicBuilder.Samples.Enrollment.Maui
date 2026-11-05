using Enrollment.XPlatform.Views;

namespace Microsoft.Extensions.DependencyInjection
{
    internal static class ViewServices
    {
        internal static IServiceCollection AddViews(this IServiceCollection services)
        {
            return services
                .AddTransient<ExtendedSplashView>();
        }
    }
}
