using Enrollment.XPlatform.Flow;
using LogicBuilder.App.Utils.Rules;
using LogicBuilder.RulesDirector;

namespace Microsoft.Extensions.DependencyInjection
{
    internal static class RulesServices
    {
        internal static IServiceCollection AddRulesCache(this IServiceCollection services)
        {
            return services.AddRulesCacheService
            (
                new RulesLoaderRequest
                (
                    "Enrollment.XPlatform.Flow.Rulesets",
                    typeof(FlowActivity),
                    [
                        typeof(LogicBuilder.App.Utils.Interfaces.ITypeHelper).Assembly,
                        typeof(LogicBuilder.App.Maui.Forms.Parameters.CommandButtonParameters).Assembly,
                        typeof(LogicBuilder.App.Maui.Forms.Configuration.CommandButtonDescriptor).Assembly,
                        typeof(LogicBuilder.Forms.Parameters.ConnectorParameters).Assembly,
                        typeof(Enrollment.Domain.Entities.UserModel).Assembly,
                        typeof(Enrollment.Data.Entities.User).Assembly,
                        typeof(DirectorBase).Assembly,
                        typeof(string).Assembly
                    ]
                )
            );
        }
    }
}
