// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class InnerApplicationExternalUrlConfigFactory(Action<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig>
{

    protected override Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig Create()
    {
        var externalUrlConfigResult = CreateExternalUrlConfig();
        factoryAction?.Invoke(externalUrlConfigResult);

        return externalUrlConfigResult;
    }

    private Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig CreateExternalUrlConfig()
    {
        var externalUrlConfigResult = new Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig();

        return externalUrlConfigResult;
    }

} // End Of Class

public static class InnerApplicationExternalUrlConfigFactoryExtensions
{
}
