// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexMultiplexOutputDestinationFactory(Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination>
{

    internal InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory MultiplexMediaConnectOutputDestinationSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination Create()
    {
        var multiplexOutputDestinationResult = CreateMultiplexOutputDestination();
        factoryAction?.Invoke(multiplexOutputDestinationResult);

        return multiplexOutputDestinationResult;
    }

    private Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination CreateMultiplexOutputDestination()
    {
        var multiplexOutputDestinationResult = new Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination();

        return multiplexOutputDestinationResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination result)
    {
        base.CreateChildren(result);

        result.MultiplexMediaConnectOutputDestinationSettings ??= MultiplexMediaConnectOutputDestinationSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerMultiplexMultiplexOutputDestinationFactoryExtensions
{
    public static CombinedResult<InnerMultiplexMultiplexOutputDestinationFactory, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings(this InnerMultiplexMultiplexOutputDestinationFactory parentFactory, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null)
    {
        parentFactory.MultiplexMediaConnectOutputDestinationSettingsFactory = new InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MultiplexMediaConnectOutputDestinationSettingsFactory);
    }

    public static CombinedResult<InnerMultiplexMultiplexOutputDestinationFactory, T1, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1>(this CombinedResult<InnerMultiplexMultiplexOutputDestinationFactory, T1> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexMultiplexOutputDestinationFactory, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1>(this CombinedResult<T1, InnerMultiplexMultiplexOutputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMultiplexMultiplexOutputDestinationFactory, T1, T2, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2>(this CombinedResult<InnerMultiplexMultiplexOutputDestinationFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexMultiplexOutputDestinationFactory, T2, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2>(this CombinedResult<T1, InnerMultiplexMultiplexOutputDestinationFactory, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexMultiplexOutputDestinationFactory, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2>(this CombinedResult<T1, T2, InnerMultiplexMultiplexOutputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMultiplexMultiplexOutputDestinationFactory, T1, T2, T3, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2, T3>(this CombinedResult<InnerMultiplexMultiplexOutputDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexMultiplexOutputDestinationFactory, T2, T3, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2, T3>(this CombinedResult<T1, InnerMultiplexMultiplexOutputDestinationFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexMultiplexOutputDestinationFactory, T3, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerMultiplexMultiplexOutputDestinationFactory, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMultiplexMultiplexOutputDestinationFactory, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMultiplexMultiplexOutputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMultiplexMultiplexOutputDestinationFactory, T1, T2, T3, T4, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2, T3, T4>(this CombinedResult<InnerMultiplexMultiplexOutputDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMultiplexMultiplexOutputDestinationFactory, T2, T3, T4, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerMultiplexMultiplexOutputDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMultiplexMultiplexOutputDestinationFactory, T3, T4, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMultiplexMultiplexOutputDestinationFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMultiplexMultiplexOutputDestinationFactory, T4, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMultiplexMultiplexOutputDestinationFactory, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMultiplexMultiplexOutputDestinationFactory, InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory> WithMultiplexMediaConnectOutputDestinationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMultiplexMultiplexOutputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexMediaConnectOutputDestinationSettings(combinedResult.T5, subFactoryAction));
}
