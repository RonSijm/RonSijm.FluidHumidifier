// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelBlackoutSlateFactory(Action<Humidifier.MediaLive.ChannelTypes.BlackoutSlate> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.BlackoutSlate>
{

    internal InnerChannelInputLocationFactory NetworkEndBlackoutImageFactory { get; set; }

    internal InnerChannelInputLocationFactory BlackoutSlateImageFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.BlackoutSlate Create()
    {
        var blackoutSlateResult = CreateBlackoutSlate();
        factoryAction?.Invoke(blackoutSlateResult);

        return blackoutSlateResult;
    }

    private Humidifier.MediaLive.ChannelTypes.BlackoutSlate CreateBlackoutSlate()
    {
        var blackoutSlateResult = new Humidifier.MediaLive.ChannelTypes.BlackoutSlate();

        return blackoutSlateResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.BlackoutSlate result)
    {
        base.CreateChildren(result);

        result.NetworkEndBlackoutImage ??= NetworkEndBlackoutImageFactory?.Build();
        result.BlackoutSlateImage ??= BlackoutSlateImageFactory?.Build();
    }

} // End Of Class

public static class InnerChannelBlackoutSlateFactoryExtensions
{
    public static CombinedResult<InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage(this InnerChannelBlackoutSlateFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null)
    {
        parentFactory.NetworkEndBlackoutImageFactory = new InnerChannelInputLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkEndBlackoutImageFactory);
    }

    public static CombinedResult<InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithBlackoutSlateImage(this InnerChannelBlackoutSlateFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null)
    {
        parentFactory.BlackoutSlateImageFactory = new InnerChannelInputLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BlackoutSlateImageFactory);
    }

    public static CombinedResult<InnerChannelBlackoutSlateFactory, T1, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1>(this CombinedResult<InnerChannelBlackoutSlateFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1>(this CombinedResult<T1, InnerChannelBlackoutSlateFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2>(this CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2>(this CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2>(this CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, T3, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2, T3>(this CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, T3, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2, T3>(this CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, T3, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelBlackoutSlateFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, T3, T4, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2, T3, T4>(this CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, T3, T4, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, T3, T4, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelBlackoutSlateFactory, T4, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelBlackoutSlateFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithNetworkEndBlackoutImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelBlackoutSlateFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkEndBlackoutImage(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerChannelBlackoutSlateFactory, T1, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1>(this CombinedResult<InnerChannelBlackoutSlateFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1>(this CombinedResult<T1, InnerChannelBlackoutSlateFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2>(this CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2>(this CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2>(this CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, T3, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2, T3>(this CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, T3, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2, T3>(this CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, T3, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelBlackoutSlateFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, T3, T4, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2, T3, T4>(this CombinedResult<InnerChannelBlackoutSlateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, T3, T4, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelBlackoutSlateFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, T3, T4, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelBlackoutSlateFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelBlackoutSlateFactory, T4, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelBlackoutSlateFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelBlackoutSlateFactory, InnerChannelInputLocationFactory> WithBlackoutSlateImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelBlackoutSlateFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlackoutSlateImage(combinedResult.T5, subFactoryAction));
}
