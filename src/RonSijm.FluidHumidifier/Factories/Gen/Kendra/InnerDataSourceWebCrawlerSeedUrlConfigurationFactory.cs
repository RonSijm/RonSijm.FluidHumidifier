// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceWebCrawlerSeedUrlConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.WebCrawlerSeedUrlConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.WebCrawlerSeedUrlConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.WebCrawlerSeedUrlConfiguration Create()
    {
        var webCrawlerSeedUrlConfigurationResult = CreateWebCrawlerSeedUrlConfiguration();
        factoryAction?.Invoke(webCrawlerSeedUrlConfigurationResult);

        return webCrawlerSeedUrlConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.WebCrawlerSeedUrlConfiguration CreateWebCrawlerSeedUrlConfiguration()
    {
        var webCrawlerSeedUrlConfigurationResult = new Humidifier.Kendra.DataSourceTypes.WebCrawlerSeedUrlConfiguration();

        return webCrawlerSeedUrlConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceWebCrawlerSeedUrlConfigurationFactoryExtensions
{
}
