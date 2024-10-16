// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class ChannelFactory(string resourceName = null, Action<Humidifier.CloudTrail.Channel> factoryAction = null) : ResourceFactory<Humidifier.CloudTrail.Channel>(resourceName)
{

    internal List<InnerChannelDestinationFactory> DestinationsFactories { get; set; } = [];

    protected override Humidifier.CloudTrail.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.CloudTrail.Channel CreateChannel()
    {
        var channelResult = new Humidifier.CloudTrail.Channel
        {
            GivenName = InputResourceName,
        };

        return channelResult;
    }
    public override void CreateChildren(Humidifier.CloudTrail.Channel result)
    {
        base.CreateChildren(result);

        result.Destinations = DestinationsFactories.Any() ? DestinationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ChannelFactoryExtensions
{
    public static CombinedResult<ChannelFactory, InnerChannelDestinationFactory> WithDestinations(this ChannelFactory parentFactory, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null)
    {
        var factory = new InnerChannelDestinationFactory(subFactoryAction);
        parentFactory.DestinationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ChannelFactory, T1, InnerChannelDestinationFactory> WithDestinations<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelDestinationFactory> WithDestinations<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelDestinationFactory> WithDestinations<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelDestinationFactory> WithDestinations<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelDestinationFactory> WithDestinations<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelDestinationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelDestinationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelDestinationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelDestinationFactory> WithDestinations<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelDestinationFactory> WithDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.CloudTrail.ChannelTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinations(combinedResult.T5, subFactoryAction));
}
