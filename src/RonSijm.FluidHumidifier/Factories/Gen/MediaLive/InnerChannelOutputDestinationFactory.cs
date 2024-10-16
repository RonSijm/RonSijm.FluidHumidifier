// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelOutputDestinationFactory(Action<Humidifier.MediaLive.ChannelTypes.OutputDestination> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.OutputDestination>
{

    internal InnerChannelMultiplexProgramChannelDestinationSettingsFactory MultiplexSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.OutputDestination Create()
    {
        var outputDestinationResult = CreateOutputDestination();
        factoryAction?.Invoke(outputDestinationResult);

        return outputDestinationResult;
    }

    private Humidifier.MediaLive.ChannelTypes.OutputDestination CreateOutputDestination()
    {
        var outputDestinationResult = new Humidifier.MediaLive.ChannelTypes.OutputDestination();

        return outputDestinationResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.OutputDestination result)
    {
        base.CreateChildren(result);

        result.MultiplexSettings ??= MultiplexSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelOutputDestinationFactoryExtensions
{
    public static CombinedResult<InnerChannelOutputDestinationFactory, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings(this InnerChannelOutputDestinationFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null)
    {
        parentFactory.MultiplexSettingsFactory = new InnerChannelMultiplexProgramChannelDestinationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MultiplexSettingsFactory);
    }

    public static CombinedResult<InnerChannelOutputDestinationFactory, T1, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1>(this CombinedResult<InnerChannelOutputDestinationFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelOutputDestinationFactory, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1>(this CombinedResult<T1, InnerChannelOutputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelOutputDestinationFactory, T1, T2, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2>(this CombinedResult<InnerChannelOutputDestinationFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelOutputDestinationFactory, T2, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2>(this CombinedResult<T1, InnerChannelOutputDestinationFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelOutputDestinationFactory, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelOutputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelOutputDestinationFactory, T1, T2, T3, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2, T3>(this CombinedResult<InnerChannelOutputDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelOutputDestinationFactory, T2, T3, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelOutputDestinationFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelOutputDestinationFactory, T3, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelOutputDestinationFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelOutputDestinationFactory, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelOutputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelOutputDestinationFactory, T1, T2, T3, T4, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelOutputDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelOutputDestinationFactory, T2, T3, T4, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelOutputDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelOutputDestinationFactory, T3, T4, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelOutputDestinationFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelOutputDestinationFactory, T4, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelOutputDestinationFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelOutputDestinationFactory, InnerChannelMultiplexProgramChannelDestinationSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelOutputDestinationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T5, subFactoryAction));
}
