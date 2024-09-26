// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerRoutingProfileMediaConcurrencyFactory(Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> factoryAction = null) : SubResourceFactory<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency>
{

    internal InnerRoutingProfileCrossChannelBehaviorFactory CrossChannelBehaviorFactory { get; set; }

    protected override Humidifier.Connect.RoutingProfileTypes.MediaConcurrency Create()
    {
        var mediaConcurrencyResult = CreateMediaConcurrency();
        factoryAction?.Invoke(mediaConcurrencyResult);

        return mediaConcurrencyResult;
    }

    private Humidifier.Connect.RoutingProfileTypes.MediaConcurrency CreateMediaConcurrency()
    {
        var mediaConcurrencyResult = new Humidifier.Connect.RoutingProfileTypes.MediaConcurrency();

        return mediaConcurrencyResult;
    }
    public override void CreateChildren(Humidifier.Connect.RoutingProfileTypes.MediaConcurrency result)
    {
        base.CreateChildren(result);

        result.CrossChannelBehavior ??= CrossChannelBehaviorFactory?.Build();
    }

} // End Of Class

public static class InnerRoutingProfileMediaConcurrencyFactoryExtensions
{
    public static CombinedResult<InnerRoutingProfileMediaConcurrencyFactory, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior(this InnerRoutingProfileMediaConcurrencyFactory parentFactory, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null)
    {
        parentFactory.CrossChannelBehaviorFactory = new InnerRoutingProfileCrossChannelBehaviorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CrossChannelBehaviorFactory);
    }

    public static CombinedResult<InnerRoutingProfileMediaConcurrencyFactory, T1, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1>(this CombinedResult<InnerRoutingProfileMediaConcurrencyFactory, T1> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRoutingProfileMediaConcurrencyFactory, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1>(this CombinedResult<T1, InnerRoutingProfileMediaConcurrencyFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRoutingProfileMediaConcurrencyFactory, T1, T2, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2>(this CombinedResult<InnerRoutingProfileMediaConcurrencyFactory, T1, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRoutingProfileMediaConcurrencyFactory, T2, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2>(this CombinedResult<T1, InnerRoutingProfileMediaConcurrencyFactory, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRoutingProfileMediaConcurrencyFactory, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2>(this CombinedResult<T1, T2, InnerRoutingProfileMediaConcurrencyFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRoutingProfileMediaConcurrencyFactory, T1, T2, T3, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2, T3>(this CombinedResult<InnerRoutingProfileMediaConcurrencyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRoutingProfileMediaConcurrencyFactory, T2, T3, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2, T3>(this CombinedResult<T1, InnerRoutingProfileMediaConcurrencyFactory, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRoutingProfileMediaConcurrencyFactory, T3, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2, T3>(this CombinedResult<T1, T2, InnerRoutingProfileMediaConcurrencyFactory, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRoutingProfileMediaConcurrencyFactory, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRoutingProfileMediaConcurrencyFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRoutingProfileMediaConcurrencyFactory, T1, T2, T3, T4, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2, T3, T4>(this CombinedResult<InnerRoutingProfileMediaConcurrencyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRoutingProfileMediaConcurrencyFactory, T2, T3, T4, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2, T3, T4>(this CombinedResult<T1, InnerRoutingProfileMediaConcurrencyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRoutingProfileMediaConcurrencyFactory, T3, T4, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRoutingProfileMediaConcurrencyFactory, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRoutingProfileMediaConcurrencyFactory, T4, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRoutingProfileMediaConcurrencyFactory, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRoutingProfileMediaConcurrencyFactory, InnerRoutingProfileCrossChannelBehaviorFactory> WithCrossChannelBehavior<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRoutingProfileMediaConcurrencyFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossChannelBehavior(combinedResult.T5, subFactoryAction));
}
