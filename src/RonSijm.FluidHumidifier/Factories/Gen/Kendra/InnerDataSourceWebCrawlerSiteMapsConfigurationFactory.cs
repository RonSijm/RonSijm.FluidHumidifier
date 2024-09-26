// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceWebCrawlerSiteMapsConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.WebCrawlerSiteMapsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.WebCrawlerSiteMapsConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.WebCrawlerSiteMapsConfiguration Create()
    {
        var webCrawlerSiteMapsConfigurationResult = CreateWebCrawlerSiteMapsConfiguration();
        factoryAction?.Invoke(webCrawlerSiteMapsConfigurationResult);

        return webCrawlerSiteMapsConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.WebCrawlerSiteMapsConfiguration CreateWebCrawlerSiteMapsConfiguration()
    {
        var webCrawlerSiteMapsConfigurationResult = new Humidifier.Kendra.DataSourceTypes.WebCrawlerSiteMapsConfiguration();

        return webCrawlerSiteMapsConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceWebCrawlerSiteMapsConfigurationFactoryExtensions
{
}
