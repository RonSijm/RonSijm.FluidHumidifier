// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigurationAggregatorAccountAggregationSourceFactory(Action<Humidifier.Config.ConfigurationAggregatorTypes.AccountAggregationSource> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigurationAggregatorTypes.AccountAggregationSource>
{

    protected override Humidifier.Config.ConfigurationAggregatorTypes.AccountAggregationSource Create()
    {
        var accountAggregationSourceResult = CreateAccountAggregationSource();
        factoryAction?.Invoke(accountAggregationSourceResult);

        return accountAggregationSourceResult;
    }

    private Humidifier.Config.ConfigurationAggregatorTypes.AccountAggregationSource CreateAccountAggregationSource()
    {
        var accountAggregationSourceResult = new Humidifier.Config.ConfigurationAggregatorTypes.AccountAggregationSource();

        return accountAggregationSourceResult;
    }

} // End Of Class

public static class InnerConfigurationAggregatorAccountAggregationSourceFactoryExtensions
{
}
