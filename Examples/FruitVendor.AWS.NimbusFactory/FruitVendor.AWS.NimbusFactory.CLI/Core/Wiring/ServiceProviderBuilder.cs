using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;
using FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.OTAPEnvironmentComposer;
using RonSijm.FluidHumidifier.VCDM.Stacks;
using RonSijm.Syringe;
using RonSijm.Syringe.Helpers;
using RonSijm.Syringe.Settings;

namespace FruitVendor.AWS.NimbusFactory.CLI.Core.Wiring;

public static class ServiceProviderBuilder
{
    public static IServiceProvider Build()
    {
        SyringeGlobalSettings.DefaultServiceLifetime = ServiceLifetime.Transient;

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