using Enrollment.XPlatform.Views;
using LogicBuilder.App.Maui.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;

namespace Enrollment.XPlatform
{
    public partial class App : Application
    {
        public App(IConfiguration configuration)
        {
            InitializeComponent();
            BASE_URL = configuration["BASE_URL"]! ?? throw new InvalidOperationException("BASE_URL is not configured");
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Microsoft.Maui.Controls.Window(ServiceProvider.GetRequiredService<MainPageView>());
            /*To use the extended splash (useful for low powered devices)
                 * 1) Replace return new Microsoft.Maui.Controls.Window(ServiceProvider.GetRequiredService<MainPageView>()); with return new Microsoft.Maui.Controls.Window(ServiceProvider.GetRequiredService<ExtendedSplashView>())
                 * 2) In MauiProgram.ConfigureServices(), comment out .AddRulesCache()
                 */
            //return new Microsoft.Maui.Controls.Window(App.ServiceProvider.GetRequiredService<ExtendedSplashView>())
        }

        public static string BASE_URL { get; set; } = "";


        #region Properties
        private static IServiceProvider? _serviceProvider;
        public static IServiceProvider ServiceProvider
        {
            get => GetServiceProvider();
            set => _serviceProvider = value;
        }

        private static IServiceProvider GetServiceProvider()
        {
            if (_serviceProvider == null)
                throw new ArgumentException($"{nameof(ServiceProvider)}: {{BB398D24-BB50-45EF-BEC8-97370762F80B}}");

            return _serviceProvider;
        }

        private static ServiceCollection? _serviceCollection;
        public static ServiceCollection ServiceCollection
        {
            get => GetServiceCollection();
            set => _serviceCollection = value;
        }

        private static ServiceCollection GetServiceCollection()
        {
            if (_serviceCollection == null)
                throw new ArgumentException($"{nameof(ServiceCollection)}: {{218FFC77-0EB3-4D1A-96DE-A86B32E3ED0F}}");

            return _serviceCollection;
        }
        #endregion Properties
    }
}