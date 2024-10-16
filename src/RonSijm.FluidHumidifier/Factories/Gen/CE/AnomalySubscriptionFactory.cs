// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CE;

public class AnomalySubscriptionFactory(string resourceName = null, Action<Humidifier.CE.AnomalySubscription> factoryAction = null) : ResourceFactory<Humidifier.CE.AnomalySubscription>(resourceName)
{

    internal List<InnerAnomalySubscriptionResourceTagFactory> ResourceTagsFactories { get; set; } = [];

    internal List<InnerAnomalySubscriptionSubscriberFactory> SubscribersFactories { get; set; } = [];

    protected override Humidifier.CE.AnomalySubscription Create()
    {
        var anomalySubscriptionResult = CreateAnomalySubscription();
        factoryAction?.Invoke(anomalySubscriptionResult);

        return anomalySubscriptionResult;
    }

    private Humidifier.CE.AnomalySubscription CreateAnomalySubscription()
    {
        var anomalySubscriptionResult = new Humidifier.CE.AnomalySubscription
        {
            GivenName = InputResourceName,
        };

        return anomalySubscriptionResult;
    }
    public override void CreateChildren(Humidifier.CE.AnomalySubscription result)
    {
        base.CreateChildren(result);

        result.ResourceTags = ResourceTagsFactories.Any() ? ResourceTagsFactories.Select(x => x.Build()).ToList() : null;
        result.Subscribers = SubscribersFactories.Any() ? SubscribersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AnomalySubscriptionFactoryExtensions
{
    public static CombinedResult<AnomalySubscriptionFactory, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags(this AnomalySubscriptionFactory parentFactory, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerAnomalySubscriptionResourceTagFactory(subFactoryAction);
        parentFactory.ResourceTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AnomalySubscriptionFactory, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers(this AnomalySubscriptionFactory parentFactory, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null)
    {
        var factory = new InnerAnomalySubscriptionSubscriberFactory(subFactoryAction);
        parentFactory.SubscribersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AnomalySubscriptionFactory, T1, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1>(this CombinedResult<AnomalySubscriptionFactory, T1> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalySubscriptionFactory, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1>(this CombinedResult<T1, AnomalySubscriptionFactory> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnomalySubscriptionFactory, T1, T2, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<AnomalySubscriptionFactory, T1, T2> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalySubscriptionFactory, T2, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, AnomalySubscriptionFactory, T2> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalySubscriptionFactory, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, T2, AnomalySubscriptionFactory> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnomalySubscriptionFactory, T1, T2, T3, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<AnomalySubscriptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalySubscriptionFactory, T2, T3, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, AnomalySubscriptionFactory, T2, T3> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalySubscriptionFactory, T3, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, AnomalySubscriptionFactory, T3> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalySubscriptionFactory, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnomalySubscriptionFactory> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnomalySubscriptionFactory, T1, T2, T3, T4, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<AnomalySubscriptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalySubscriptionFactory, T2, T3, T4, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, AnomalySubscriptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalySubscriptionFactory, T3, T4, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnomalySubscriptionFactory, T3, T4> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalySubscriptionFactory, T4, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnomalySubscriptionFactory, T4> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnomalySubscriptionFactory, InnerAnomalySubscriptionResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnomalySubscriptionFactory> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AnomalySubscriptionFactory, T1, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1>(this CombinedResult<AnomalySubscriptionFactory, T1> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscribers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalySubscriptionFactory, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1>(this CombinedResult<T1, AnomalySubscriptionFactory> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscribers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnomalySubscriptionFactory, T1, T2, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2>(this CombinedResult<AnomalySubscriptionFactory, T1, T2> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalySubscriptionFactory, T2, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2>(this CombinedResult<T1, AnomalySubscriptionFactory, T2> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalySubscriptionFactory, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2>(this CombinedResult<T1, T2, AnomalySubscriptionFactory> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnomalySubscriptionFactory, T1, T2, T3, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2, T3>(this CombinedResult<AnomalySubscriptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalySubscriptionFactory, T2, T3, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2, T3>(this CombinedResult<T1, AnomalySubscriptionFactory, T2, T3> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalySubscriptionFactory, T3, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2, T3>(this CombinedResult<T1, T2, AnomalySubscriptionFactory, T3> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalySubscriptionFactory, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnomalySubscriptionFactory> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnomalySubscriptionFactory, T1, T2, T3, T4, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2, T3, T4>(this CombinedResult<AnomalySubscriptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalySubscriptionFactory, T2, T3, T4, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2, T3, T4>(this CombinedResult<T1, AnomalySubscriptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalySubscriptionFactory, T3, T4, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnomalySubscriptionFactory, T3, T4> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalySubscriptionFactory, T4, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnomalySubscriptionFactory, T4> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnomalySubscriptionFactory, InnerAnomalySubscriptionSubscriberFactory> WithSubscribers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnomalySubscriptionFactory> combinedResult, Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscribers(combinedResult.T5, subFactoryAction));
}
