// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceWebCrawlerLimitsFactory(Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits>
{

    protected override Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits Create()
    {
        var webCrawlerLimitsResult = CreateWebCrawlerLimits();
        factoryAction?.Invoke(webCrawlerLimitsResult);

        return webCrawlerLimitsResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits CreateWebCrawlerLimits()
    {
        var webCrawlerLimitsResult = new Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits();

        return webCrawlerLimitsResult;
    }

} // End Of Class

public static class InnerDataSourceWebCrawlerLimitsFactoryExtensions
{
}
