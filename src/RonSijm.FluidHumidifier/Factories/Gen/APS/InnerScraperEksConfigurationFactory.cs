// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperEksConfigurationFactory(Action<Humidifier.APS.ScraperTypes.EksConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.EksConfiguration>
{

    protected override Humidifier.APS.ScraperTypes.EksConfiguration Create()
    {
        var eksConfigurationResult = CreateEksConfiguration();
        factoryAction?.Invoke(eksConfigurationResult);

        return eksConfigurationResult;
    }

    private Humidifier.APS.ScraperTypes.EksConfiguration CreateEksConfiguration()
    {
        var eksConfigurationResult = new Humidifier.APS.ScraperTypes.EksConfiguration();

        return eksConfigurationResult;
    }

} // End Of Class

public static class InnerScraperEksConfigurationFactoryExtensions
{
}
