// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceProxyConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.ProxyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.ProxyConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.ProxyConfiguration Create()
    {
        var proxyConfigurationResult = CreateProxyConfiguration();
        factoryAction?.Invoke(proxyConfigurationResult);

        return proxyConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.ProxyConfiguration CreateProxyConfiguration()
    {
        var proxyConfigurationResult = new Humidifier.Kendra.DataSourceTypes.ProxyConfiguration();

        return proxyConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceProxyConfigurationFactoryExtensions
{
}
