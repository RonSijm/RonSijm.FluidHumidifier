// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperScrapeConfigurationFactory(Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.ScrapeConfiguration>
{

    protected override Humidifier.APS.ScraperTypes.ScrapeConfiguration Create()
    {
        var scrapeConfigurationResult = CreateScrapeConfiguration();
        factoryAction?.Invoke(scrapeConfigurationResult);

        return scrapeConfigurationResult;
    }

    private Humidifier.APS.ScraperTypes.ScrapeConfiguration CreateScrapeConfiguration()
    {
        var scrapeConfigurationResult = new Humidifier.APS.ScraperTypes.ScrapeConfiguration();

        return scrapeConfigurationResult;
    }

} // End Of Class

public static class InnerScraperScrapeConfigurationFactoryExtensions
{
}
