// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelInputLossBehaviorFactory(Action<Humidifier.MediaLive.ChannelTypes.InputLossBehavior> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.InputLossBehavior>
{

    internal InnerChannelInputLocationFactory InputLossImageSlateFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.InputLossBehavior Create()
    {
        var inputLossBehaviorResult = CreateInputLossBehavior();
        factoryAction?.Invoke(inputLossBehaviorResult);

        return inputLossBehaviorResult;
    }

    private Humidifier.MediaLive.ChannelTypes.InputLossBehavior CreateInputLossBehavior()
    {
        var inputLossBehaviorResult = new Humidifier.MediaLive.ChannelTypes.InputLossBehavior();

        return inputLossBehaviorResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.InputLossBehavior result)
    {
        base.CreateChildren(result);

        result.InputLossImageSlate ??= InputLossImageSlateFactory?.Build();
    }

} // End Of Class

public static class InnerChannelInputLossBehaviorFactoryExtensions
{
    public static CombinedResult<InnerChannelInputLossBehaviorFactory, InnerChannelInputLocationFactory> WithInputLossImageSlate(this InnerChannelInputLossBehaviorFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null)
    {
        parentFactory.InputLossImageSlateFactory = new InnerChannelInputLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputLossImageSlateFactory);
    }

    public static CombinedResult<InnerChannelInputLossBehaviorFactory, T1, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1>(this CombinedResult<InnerChannelInputLossBehaviorFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputLossBehaviorFactory, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1>(this CombinedResult<T1, InnerChannelInputLossBehaviorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelInputLossBehaviorFactory, T1, T2, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2>(this CombinedResult<InnerChannelInputLossBehaviorFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputLossBehaviorFactory, T2, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2>(this CombinedResult<T1, InnerChannelInputLossBehaviorFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputLossBehaviorFactory, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2>(this CombinedResult<T1, T2, InnerChannelInputLossBehaviorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelInputLossBehaviorFactory, T1, T2, T3, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2, T3>(this CombinedResult<InnerChannelInputLossBehaviorFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputLossBehaviorFactory, T2, T3, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2, T3>(this CombinedResult<T1, InnerChannelInputLossBehaviorFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputLossBehaviorFactory, T3, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelInputLossBehaviorFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputLossBehaviorFactory, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelInputLossBehaviorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelInputLossBehaviorFactory, T1, T2, T3, T4, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2, T3, T4>(this CombinedResult<InnerChannelInputLossBehaviorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputLossBehaviorFactory, T2, T3, T4, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelInputLossBehaviorFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputLossBehaviorFactory, T3, T4, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelInputLossBehaviorFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputLossBehaviorFactory, T4, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelInputLossBehaviorFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelInputLossBehaviorFactory, InnerChannelInputLocationFactory> WithInputLossImageSlate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelInputLossBehaviorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLossImageSlate(combinedResult.T5, subFactoryAction));
}
