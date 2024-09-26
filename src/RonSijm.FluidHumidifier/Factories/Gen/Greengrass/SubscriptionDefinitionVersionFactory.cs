// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class SubscriptionDefinitionVersionFactory(string resourceName = null, Action<Humidifier.Greengrass.SubscriptionDefinitionVersion> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.SubscriptionDefinitionVersion>(resourceName)
{

    internal List<InnerSubscriptionDefinitionVersionSubscriptionFactory> SubscriptionsFactories { get; set; } = [];

    protected override Humidifier.Greengrass.SubscriptionDefinitionVersion Create()
    {
        var subscriptionDefinitionVersionResult = CreateSubscriptionDefinitionVersion();
        factoryAction?.Invoke(subscriptionDefinitionVersionResult);

        return subscriptionDefinitionVersionResult;
    }

    private Humidifier.Greengrass.SubscriptionDefinitionVersion CreateSubscriptionDefinitionVersion()
    {
        var subscriptionDefinitionVersionResult = new Humidifier.Greengrass.SubscriptionDefinitionVersion
        {
            GivenName = InputResourceName,
        };

        return subscriptionDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.SubscriptionDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Subscriptions = SubscriptionsFactories.Any() ? SubscriptionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SubscriptionDefinitionVersionFactoryExtensions
{
    public static CombinedResult<SubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions(this SubscriptionDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null)
    {
        var factory = new InnerSubscriptionDefinitionVersionSubscriptionFactory(subFactoryAction);
        parentFactory.SubscriptionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SubscriptionDefinitionVersionFactory, T1, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1>(this CombinedResult<SubscriptionDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1>(this CombinedResult<T1, SubscriptionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SubscriptionDefinitionVersionFactory, T1, T2, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2>(this CombinedResult<SubscriptionDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionDefinitionVersionFactory, T2, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2>(this CombinedResult<T1, SubscriptionDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2>(this CombinedResult<T1, T2, SubscriptionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SubscriptionDefinitionVersionFactory, T1, T2, T3, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2, T3>(this CombinedResult<SubscriptionDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionDefinitionVersionFactory, T2, T3, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2, T3>(this CombinedResult<T1, SubscriptionDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriptionDefinitionVersionFactory, T3, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2, T3>(this CombinedResult<T1, T2, SubscriptionDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, SubscriptionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SubscriptionDefinitionVersionFactory, T1, T2, T3, T4, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<SubscriptionDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriptionDefinitionVersionFactory, T2, T3, T4, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, SubscriptionDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriptionDefinitionVersionFactory, T3, T4, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, SubscriptionDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriptionDefinitionVersionFactory, T4, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SubscriptionDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SubscriptionDefinitionVersionFactory, InnerSubscriptionDefinitionVersionSubscriptionFactory> WithSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SubscriptionDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriptions(combinedResult.T5, subFactoryAction));
}
