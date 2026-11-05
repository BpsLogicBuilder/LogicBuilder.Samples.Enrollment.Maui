using Enrollment.XPlatform.ViewModels;

namespace Microsoft.Extensions.DependencyInjection
{
    internal static class ViewModelServices
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services)
            => services
                .AddTransient<ExtendedSplashViewModel>();
    }
}
