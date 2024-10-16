// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceSalesforceStandardObjectAttachmentConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardObjectAttachmentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.SalesforceStandardObjectAttachmentConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.SalesforceStandardObjectAttachmentConfiguration Create()
    {
        var salesforceStandardObjectAttachmentConfigurationResult = CreateSalesforceStandardObjectAttachmentConfiguration();
        factoryAction?.Invoke(salesforceStandardObjectAttachmentConfigurationResult);

        return salesforceStandardObjectAttachmentConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.SalesforceStandardObjectAttachmentConfiguration CreateSalesforceStandardObjectAttachmentConfiguration()
    {
        var salesforceStandardObjectAttachmentConfigurationResult = new Humidifier.Kendra.DataSourceTypes.SalesforceStandardObjectAttachmentConfiguration();

        return salesforceStandardObjectAttachmentConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceSalesforceStandardObjectAttachmentConfigurationFactoryExtensions
{
}
