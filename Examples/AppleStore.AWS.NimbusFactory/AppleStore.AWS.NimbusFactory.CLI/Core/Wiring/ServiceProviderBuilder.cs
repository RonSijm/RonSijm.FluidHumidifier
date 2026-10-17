using RonSijm.FluidHumidifier.VCDM.Stacks;
using RonSijm.FluidHumidifier.VCDM.Config;
using RonSijm.Syringe;
using RonSijm.Syringe.Helpers;
using RonSijm.Syringe.Settings;

namespace AppleStore.AWS.NimbusFactory.CLI.Core.Wiring;

public static class ServiceProviderBuilder
{
    public static IServiceProvider Build()
    {
        SyringeGlobalSettings.DefaultServiceLifetime = ServiceLifetime.Transient;

        // Override the logging library's provider accounts with fictional example accounts.
        VismaAccountConfig.StagingAccount = new("example-security-logs-stage", "777777777777", AWSConfigSettings.DefaultRegion);
        VismaAccountConfig.ProdAccount = new("example-security-logs-prod", "888888888888", AWSConfigSettings.DefaultRegion);

        var settings = SettingsWiring.GetSettings();
        AppSettingsContainer.Settings = settings;

        var builder = typeof(Program).WireImplicit()
                .RegisterBothTypeAndInterfaces([typeof(IEnvironmentComposer), typeof(IHaveDecorators)])
                .DontRegisterTypes(typeof(AppSettings))
            .WireImplicit<IDecorator>()
            .WireImplicit<GithubActionFactory>()
            .WireImplicit<BatchActionFactory>()
            .WireImplicit<VCDMLoggingStackComposer>().RegisterBothTypeAndInterfaces([typeof(IEnvironmentComposer), typeof(IHaveDecorators)])
            .AddScopedFunc<OTAPEnvironmentComposer>()
            .AddSingleton(settings);

            var serviceProvider = builder.BuildServiceProvider();

        return serviceProvider;
    }
}
