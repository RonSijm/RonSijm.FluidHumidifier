// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceSalesforceSourceConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.SalesforceSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.SalesforceSourceConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.SalesforceSourceConfiguration Create()
    {
        var salesforceSourceConfigurationResult = CreateSalesforceSourceConfiguration();
        factoryAction?.Invoke(salesforceSourceConfigurationResult);

        return salesforceSourceConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.SalesforceSourceConfiguration CreateSalesforceSourceConfiguration()
    {
        var salesforceSourceConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.SalesforceSourceConfiguration();

        return salesforceSourceConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceSalesforceSourceConfigurationFactoryExtensions
{
}
