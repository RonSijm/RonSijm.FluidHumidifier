// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceOpenSearchServiceConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.OpenSearchServiceConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.OpenSearchServiceConfig>
{

    protected override Humidifier.AppSync.DataSourceTypes.OpenSearchServiceConfig Create()
    {
        var openSearchServiceConfigResult = CreateOpenSearchServiceConfig();
        factoryAction?.Invoke(openSearchServiceConfigResult);

        return openSearchServiceConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.OpenSearchServiceConfig CreateOpenSearchServiceConfig()
    {
        var openSearchServiceConfigResult = new Humidifier.AppSync.DataSourceTypes.OpenSearchServiceConfig();

        return openSearchServiceConfigResult;
    }

} // End Of Class

public static class InnerDataSourceOpenSearchServiceConfigFactoryExtensions
{
}
