// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceServiceNowServiceCatalogConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.ServiceNowServiceCatalogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.ServiceNowServiceCatalogConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.ServiceNowServiceCatalogConfiguration Create()
    {
        var serviceNowServiceCatalogConfigurationResult = CreateServiceNowServiceCatalogConfiguration();
        factoryAction?.Invoke(serviceNowServiceCatalogConfigurationResult);

        return serviceNowServiceCatalogConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.ServiceNowServiceCatalogConfiguration CreateServiceNowServiceCatalogConfiguration()
    {
        var serviceNowServiceCatalogConfigurationResult = new Humidifier.Kendra.DataSourceTypes.ServiceNowServiceCatalogConfiguration();

        return serviceNowServiceCatalogConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceServiceNowServiceCatalogConfigurationFactoryExtensions
{
}
