// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryBrowserConfigFactory(Action<Humidifier.Synthetics.CanaryTypes.BrowserConfig> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.BrowserConfig>
{

    protected override Humidifier.Synthetics.CanaryTypes.BrowserConfig Create()
    {
        var browserConfigResult = CreateBrowserConfig();
        factoryAction?.Invoke(browserConfigResult);

        return browserConfigResult;
    }

    private Humidifier.Synthetics.CanaryTypes.BrowserConfig CreateBrowserConfig()
    {
        var browserConfigResult = new Humidifier.Synthetics.CanaryTypes.BrowserConfig();

        return browserConfigResult;
    }

} // End Of Class

public static class InnerCanaryBrowserConfigFactoryExtensions
{
}
