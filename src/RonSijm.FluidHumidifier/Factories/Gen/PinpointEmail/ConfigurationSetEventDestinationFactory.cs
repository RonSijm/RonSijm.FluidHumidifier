// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class ConfigurationSetEventDestinationFactory(string resourceName = null, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestination> factoryAction = null) : ResourceFactory<Humidifier.PinpointEmail.ConfigurationSetEventDestination>(resourceName)
{

    internal InnerConfigurationSetEventDestinationEventDestinationFactory EventDestinationFactory { get; set; }

    protected override Humidifier.PinpointEmail.ConfigurationSetEventDestination Create()
    {
        var configurationSetEventDestinationResult = CreateConfigurationSetEventDestination();
        factoryAction?.Invoke(configurationSetEventDestinationResult);

        return configurationSetEventDestinationResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetEventDestination CreateConfigurationSetEventDestination()
    {
        var configurationSetEventDestinationResult = new Humidifier.PinpointEmail.ConfigurationSetEventDestination
        {
            GivenName = InputResourceName,
        };

        return configurationSetEventDestinationResult;
    }
    public override void CreateChildren(Humidifier.PinpointEmail.ConfigurationSetEventDestination result)
    {
        base.CreateChildren(result);

        result.EventDestination ??= EventDestinationFactory?.Build();
    }

} // End Of Class

public static class ConfigurationSetEventDestinationFactoryExtensions
{
    public static CombinedResult<ConfigurationSetEventDestinationFactory, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination(this ConfigurationSetEventDestinationFactory parentFactory, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null)
    {
        parentFactory.EventDestinationFactory = new InnerConfigurationSetEventDestinationEventDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventDestinationFactory);
    }

    public static CombinedResult<ConfigurationSetEventDestinationFactory, T1, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1>(this CombinedResult<ConfigurationSetEventDestinationFactory, T1> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationSetEventDestinationFactory, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1>(this CombinedResult<T1, ConfigurationSetEventDestinationFactory> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationSetEventDestinationFactory, T1, T2, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2>(this CombinedResult<ConfigurationSetEventDestinationFactory, T1, T2> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationSetEventDestinationFactory, T2, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2>(this CombinedResult<T1, ConfigurationSetEventDestinationFactory, T2> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationSetEventDestinationFactory, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2>(this CombinedResult<T1, T2, ConfigurationSetEventDestinationFactory> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationSetEventDestinationFactory, T1, T2, T3, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2, T3>(this CombinedResult<ConfigurationSetEventDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationSetEventDestinationFactory, T2, T3, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2, T3>(this CombinedResult<T1, ConfigurationSetEventDestinationFactory, T2, T3> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationSetEventDestinationFactory, T3, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationSetEventDestinationFactory, T3> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationSetEventDestinationFactory, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationSetEventDestinationFactory> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationSetEventDestinationFactory, T1, T2, T3, T4, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2, T3, T4>(this CombinedResult<ConfigurationSetEventDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationSetEventDestinationFactory, T2, T3, T4, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationSetEventDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationSetEventDestinationFactory, T3, T4, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationSetEventDestinationFactory, T3, T4> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationSetEventDestinationFactory, T4, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationSetEventDestinationFactory, T4> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationSetEventDestinationFactory, InnerConfigurationSetEventDestinationEventDestinationFactory> WithEventDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationSetEventDestinationFactory> combinedResult, Action<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventDestination(combinedResult.T5, subFactoryAction));
}
