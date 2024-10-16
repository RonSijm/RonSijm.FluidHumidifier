// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class MultiplexFactory(string resourceName = null, Action<Humidifier.MediaLive.Multiplex> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.Multiplex>(resourceName)
{

    internal List<InnerMultiplexMultiplexOutputDestinationFactory> DestinationsFactories { get; set; } = [];

    internal List<InnerMultiplexTagsFactory> TagsFactories { get; set; } = [];

    internal InnerMultiplexMultiplexSettingsFactory MultiplexSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.Multiplex Create()
    {
        var multiplexResult = CreateMultiplex();
        factoryAction?.Invoke(multiplexResult);

        return multiplexResult;
    }

    private Humidifier.MediaLive.Multiplex CreateMultiplex()
    {
        var multiplexResult = new Humidifier.MediaLive.Multiplex
        {
            GivenName = InputResourceName,
        };

        return multiplexResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.Multiplex result)
    {
        base.CreateChildren(result);

        result.Destinations = DestinationsFactories.Any() ? DestinationsFactories.Select(x => x.Build()).ToList() : null;
        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.MultiplexSettings ??= MultiplexSettingsFactory?.Build();
    }

} // End Of Class

public static class MultiplexFactoryExtensions
{
    public static CombinedResult<MultiplexFactory, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations(this MultiplexFactory parentFactory, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null)
    {
        var factory = new InnerMultiplexMultiplexOutputDestinationFactory(subFactoryAction);
        parentFactory.DestinationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MultiplexFactory, InnerMultiplexTagsFactory> WithTags(this MultiplexFactory parentFactory, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerMultiplexTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MultiplexFactory, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings(this MultiplexFactory parentFactory, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null)
    {
        parentFactory.MultiplexSettingsFactory = new InnerMultiplexMultiplexSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MultiplexSettingsFactory);
    }

    public static CombinedResult<MultiplexFactory, T1, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1>(this CombinedResult<MultiplexFactory, T1> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1>(this CombinedResult<T1, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, T2, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2>(this CombinedResult<MultiplexFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, T2, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2>(this CombinedResult<T1, MultiplexFactory, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiplexFactory, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2>(this CombinedResult<T1, T2, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, T2, T3, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<MultiplexFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, T2, T3, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<T1, MultiplexFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiplexFactory, T3, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<T1, T2, MultiplexFactory, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiplexFactory, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<T1, T2, T3, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, T2, T3, T4, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<MultiplexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, T2, T3, T4, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, MultiplexFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiplexFactory, T3, T4, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, MultiplexFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiplexFactory, T4, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MultiplexFactory, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MultiplexFactory, InnerMultiplexMultiplexOutputDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, InnerMultiplexTagsFactory> WithTags<T1>(this CombinedResult<MultiplexFactory, T1> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, InnerMultiplexTagsFactory> WithTags<T1>(this CombinedResult<T1, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, T2, InnerMultiplexTagsFactory> WithTags<T1, T2>(this CombinedResult<MultiplexFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, T2, InnerMultiplexTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, MultiplexFactory, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiplexFactory, InnerMultiplexTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, T2, T3, InnerMultiplexTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<MultiplexFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, T2, T3, InnerMultiplexTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, MultiplexFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiplexFactory, T3, InnerMultiplexTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, MultiplexFactory, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiplexFactory, InnerMultiplexTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, T2, T3, T4, InnerMultiplexTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<MultiplexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, T2, T3, T4, InnerMultiplexTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, MultiplexFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiplexFactory, T3, T4, InnerMultiplexTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, MultiplexFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiplexFactory, T4, InnerMultiplexTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MultiplexFactory, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MultiplexFactory, InnerMultiplexTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1>(this CombinedResult<MultiplexFactory, T1> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1>(this CombinedResult<T1, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, T2, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2>(this CombinedResult<MultiplexFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, T2, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2>(this CombinedResult<T1, MultiplexFactory, T2> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiplexFactory, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2>(this CombinedResult<T1, T2, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, T2, T3, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2, T3>(this CombinedResult<MultiplexFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, T2, T3, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2, T3>(this CombinedResult<T1, MultiplexFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiplexFactory, T3, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2, T3>(this CombinedResult<T1, T2, MultiplexFactory, T3> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiplexFactory, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MultiplexFactory, T1, T2, T3, T4, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<MultiplexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiplexFactory, T2, T3, T4, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<T1, MultiplexFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiplexFactory, T3, T4, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, MultiplexFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiplexFactory, T4, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MultiplexFactory, T4> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MultiplexFactory, InnerMultiplexMultiplexSettingsFactory> WithMultiplexSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MultiplexFactory> combinedResult, Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiplexSettings(combinedResult.T5, subFactoryAction));
}
