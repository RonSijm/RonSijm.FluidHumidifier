// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class InnerApplicationIframeConfigFactory(Action<Humidifier.AppIntegrations.ApplicationTypes.IframeConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppIntegrations.ApplicationTypes.IframeConfig>
{

    protected override Humidifier.AppIntegrations.ApplicationTypes.IframeConfig Create()
    {
        var iframeConfigResult = CreateIframeConfig();
        factoryAction?.Invoke(iframeConfigResult);

        return iframeConfigResult;
    }

    private Humidifier.AppIntegrations.ApplicationTypes.IframeConfig CreateIframeConfig()
    {
        var iframeConfigResult = new Humidifier.AppIntegrations.ApplicationTypes.IframeConfig();

        return iframeConfigResult;
    }

} // End Of Class

public static class InnerApplicationIframeConfigFactoryExtensions
{
}
