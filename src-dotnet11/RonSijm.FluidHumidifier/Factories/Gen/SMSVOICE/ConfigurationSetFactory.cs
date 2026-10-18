// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class ConfigurationSetFactory(string resourceName = null, Action<Humidifier.SMSVOICE.ConfigurationSet> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.ConfigurationSet>(resourceName)
{

    internal List<InnerConfigurationSetEventDestinationFactory> EventDestinationsFactories { get; set; } = [];

    protected override Humidifier.SMSVOICE.ConfigurationSet Create()
    {
        var configurationSetResult = CreateConfigurationSet();
        factoryAction?.Invoke(configurationSetResult);

        return configurationSetResult;
    }

    private Humidifier.SMSVOICE.ConfigurationSet CreateConfigurationSet()
    {
        var configurationSetResult = new Humidifier.SMSVOICE.ConfigurationSet
        {
            GivenName = InputResourceName,
        };

        return configurationSetResult;
    }
    public override void CreateChildren(Humidifier.SMSVOICE.ConfigurationSet result)
    {
        base.CreateChildren(result);

        result.EventDestinations = EventDestinationsFactories.Any() ? EventDestinationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ConfigurationSetFactoryExtensions
{
    public static CombinedResult<ConfigurationSetFactory, InnerConfigurationSetEventDestinationFactory> WithEventDestinations(this ConfigurationSetFactory parentFactory, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null)
    {
        var factory = new InnerConfigurationSetEventDestinationFactory(subFactoryAction);
        parentFactory.EventDestinationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConfigurationSetFactory, T1, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1>(this CombinedResult<ConfigurationSetFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationSetFactory, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1>(this CombinedResult<T1, ConfigurationSetFactory> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConfigurationSetFactory, T1, T2, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2>(this CombinedResult<ConfigurationSetFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationSetFactory, T2, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2>(this CombinedResult<T1, ConfigurationSetFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationSetFactory, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2>(this CombinedResult<T1, T2, ConfigurationSetFactory> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConfigurationSetFactory, T1, T2, T3, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2, T3>(this CombinedResult<ConfigurationSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationSetFactory, T2, T3, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2, T3>(this CombinedResult<T1, ConfigurationSetFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationSetFactory, T3, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationSetFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfigurationSetFactory, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationSetFactory> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConfigurationSetFactory, T1, T2, T3, T4, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2, T3, T4>(this CombinedResult<ConfigurationSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationSetFactory, T2, T3, T4, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationSetFactory, T3, T4, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationSetFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfigurationSetFactory, T4, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationSetFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConfigurationSetFactory, InnerConfigurationSetEventDestinationFactory> WithEventDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationSetFactory> combinedResult, Action<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestinations(combinedResult.T5, subFactoryAction).T2);
}
