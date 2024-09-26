// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceWebCrawlerAuthenticationConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.WebCrawlerAuthenticationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.WebCrawlerAuthenticationConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.WebCrawlerAuthenticationConfiguration Create()
    {
        var webCrawlerAuthenticationConfigurationResult = CreateWebCrawlerAuthenticationConfiguration();
        factoryAction?.Invoke(webCrawlerAuthenticationConfigurationResult);

        return webCrawlerAuthenticationConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.WebCrawlerAuthenticationConfiguration CreateWebCrawlerAuthenticationConfiguration()
    {
        var webCrawlerAuthenticationConfigurationResult = new Humidifier.Kendra.DataSourceTypes.WebCrawlerAuthenticationConfiguration();

        return webCrawlerAuthenticationConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceWebCrawlerAuthenticationConfigurationFactoryExtensions
{
}
