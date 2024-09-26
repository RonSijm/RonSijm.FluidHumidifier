// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceConfluenceSourceConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.ConfluenceSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.ConfluenceSourceConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.ConfluenceSourceConfiguration Create()
    {
        var confluenceSourceConfigurationResult = CreateConfluenceSourceConfiguration();
        factoryAction?.Invoke(confluenceSourceConfigurationResult);

        return confluenceSourceConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.ConfluenceSourceConfiguration CreateConfluenceSourceConfiguration()
    {
        var confluenceSourceConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.ConfluenceSourceConfiguration();

        return confluenceSourceConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceConfluenceSourceConfigurationFactoryExtensions
{
}
