// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelAvailBlankingFactory(Action<Humidifier.MediaLive.ChannelTypes.AvailBlanking> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.AvailBlanking>
{

    internal InnerChannelInputLocationFactory AvailBlankingImageFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.AvailBlanking Create()
    {
        var availBlankingResult = CreateAvailBlanking();
        factoryAction?.Invoke(availBlankingResult);

        return availBlankingResult;
    }

    private Humidifier.MediaLive.ChannelTypes.AvailBlanking CreateAvailBlanking()
    {
        var availBlankingResult = new Humidifier.MediaLive.ChannelTypes.AvailBlanking();

        return availBlankingResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.AvailBlanking result)
    {
        base.CreateChildren(result);

        result.AvailBlankingImage ??= AvailBlankingImageFactory?.Build();
    }

} // End Of Class

public static class InnerChannelAvailBlankingFactoryExtensions
{
    public static CombinedResult<InnerChannelAvailBlankingFactory, InnerChannelInputLocationFactory> WithAvailBlankingImage(this InnerChannelAvailBlankingFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null)
    {
        parentFactory.AvailBlankingImageFactory = new InnerChannelInputLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AvailBlankingImageFactory);
    }

    public static CombinedResult<InnerChannelAvailBlankingFactory, T1, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1>(this CombinedResult<InnerChannelAvailBlankingFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelAvailBlankingFactory, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1>(this CombinedResult<T1, InnerChannelAvailBlankingFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelAvailBlankingFactory, T1, T2, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2>(this CombinedResult<InnerChannelAvailBlankingFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelAvailBlankingFactory, T2, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2>(this CombinedResult<T1, InnerChannelAvailBlankingFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelAvailBlankingFactory, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2>(this CombinedResult<T1, T2, InnerChannelAvailBlankingFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelAvailBlankingFactory, T1, T2, T3, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2, T3>(this CombinedResult<InnerChannelAvailBlankingFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelAvailBlankingFactory, T2, T3, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2, T3>(this CombinedResult<T1, InnerChannelAvailBlankingFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelAvailBlankingFactory, T3, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelAvailBlankingFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelAvailBlankingFactory, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelAvailBlankingFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelAvailBlankingFactory, T1, T2, T3, T4, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2, T3, T4>(this CombinedResult<InnerChannelAvailBlankingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelAvailBlankingFactory, T2, T3, T4, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelAvailBlankingFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelAvailBlankingFactory, T3, T4, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelAvailBlankingFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelAvailBlankingFactory, T4, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelAvailBlankingFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelAvailBlankingFactory, InnerChannelInputLocationFactory> WithAvailBlankingImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelAvailBlankingFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailBlankingImage(combinedResult.T5, subFactoryAction));
}
