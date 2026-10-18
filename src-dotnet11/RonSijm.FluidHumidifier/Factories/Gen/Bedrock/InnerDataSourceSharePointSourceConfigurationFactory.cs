// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceSharePointSourceConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.SharePointSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.SharePointSourceConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.SharePointSourceConfiguration Create()
    {
        var sharePointSourceConfigurationResult = CreateSharePointSourceConfiguration();
        factoryAction?.Invoke(sharePointSourceConfigurationResult);

        return sharePointSourceConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.SharePointSourceConfiguration CreateSharePointSourceConfiguration()
    {
        var sharePointSourceConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.SharePointSourceConfiguration();

        return sharePointSourceConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceSharePointSourceConfigurationFactoryExtensions
{
}
