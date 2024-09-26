// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory(Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion>
{

    internal List<InnerSubscriptionDefinitionSubscriptionFactory> SubscriptionsFactories { get; set; } = [];

    protected override Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion Create()
    {
        var subscriptionDefinitionVersionResult = CreateSubscriptionDefinitionVersion();
        factoryAction?.Invoke(subscriptionDefinitionVersionResult);

        return subscriptionDefinitionVersionResult;
    }

    private Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion CreateSubscriptionDefinitionVersion()
    {
        var subscriptionDefinitionVersionResult = new Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion();

        return subscriptionDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Subscriptions = SubscriptionsFactories.Any() ? SubscriptionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactoryExtensions
{
    public static CombinedResult<InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions(this InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null)
    {
        var factory = new InnerSubscriptionDefinitionSubscriptionFactory(subFactoryAction);
        parentFactory.SubscriptionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T1, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1>(this CombinedResult<InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1>(this CombinedResult<T1, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T1, T2, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2>(this CombinedResult<InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T2, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2>(this CombinedResult<T1, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2>(this CombinedResult<T1, T2, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T1, T2, T3, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2, T3>(this CombinedResult<InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T2, T3, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2, T3>(this CombinedResult<T1, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T3, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T1, T2, T3, T4, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T2, T3, T4, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T3, T4, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T4, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSubscriptionDefinitionSubscriptionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T5, subFactoryAction));
}
