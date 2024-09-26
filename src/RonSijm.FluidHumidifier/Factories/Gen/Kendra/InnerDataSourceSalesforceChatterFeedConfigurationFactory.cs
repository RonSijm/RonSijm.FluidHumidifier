// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceSalesforceChatterFeedConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.SalesforceChatterFeedConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.SalesforceChatterFeedConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.SalesforceChatterFeedConfiguration Create()
    {
        var salesforceChatterFeedConfigurationResult = CreateSalesforceChatterFeedConfiguration();
        factoryAction?.Invoke(salesforceChatterFeedConfigurationResult);

        return salesforceChatterFeedConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.SalesforceChatterFeedConfiguration CreateSalesforceChatterFeedConfiguration()
    {
        var salesforceChatterFeedConfigurationResult = new Humidifier.Kendra.DataSourceTypes.SalesforceChatterFeedConfiguration();

        return salesforceChatterFeedConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceSalesforceChatterFeedConfigurationFactoryExtensions
{
}
