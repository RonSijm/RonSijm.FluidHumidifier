// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElementalInference;

public class InnerFeedDataSourceConfigurationFactory(Action<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration>
{

    protected override Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration Create()
    {
        var dataSourceConfigurationResult = CreateDataSourceConfiguration();
        factoryAction?.Invoke(dataSourceConfigurationResult);

        return dataSourceConfigurationResult;
    }

    private Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration CreateDataSourceConfiguration()
    {
        var dataSourceConfigurationResult = new Humidifier.ElementalInference.FeedTypes.DataSourceConfiguration();

        return dataSourceConfigurationResult;
    }

} // End Of Class

public static class InnerFeedDataSourceConfigurationFactoryExtensions
{
}
