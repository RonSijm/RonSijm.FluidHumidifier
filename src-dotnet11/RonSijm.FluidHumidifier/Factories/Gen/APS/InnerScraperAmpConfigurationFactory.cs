// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperAmpConfigurationFactory(Action<Humidifier.APS.ScraperTypes.AmpConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.AmpConfiguration>
{

    protected override Humidifier.APS.ScraperTypes.AmpConfiguration Create()
    {
        var ampConfigurationResult = CreateAmpConfiguration();
        factoryAction?.Invoke(ampConfigurationResult);

        return ampConfigurationResult;
    }

    private Humidifier.APS.ScraperTypes.AmpConfiguration CreateAmpConfiguration()
    {
        var ampConfigurationResult = new Humidifier.APS.ScraperTypes.AmpConfiguration();

        return ampConfigurationResult;
    }

} // End Of Class

public static class InnerScraperAmpConfigurationFactoryExtensions
{
}
