// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class SubscriberFactory(string resourceName = null, Action<Humidifier.SecurityLake.Subscriber> factoryAction = null) : ResourceFactory<Humidifier.SecurityLake.Subscriber>(resourceName)
{

    internal List<InnerSubscriberSourceFactory> SourcesFactories { get; set; } = [];

    internal InnerSubscriberSubscriberIdentityFactory SubscriberIdentityFactory { get; set; }

    protected override Humidifier.SecurityLake.Subscriber Create()
    {
        var subscriberResult = CreateSubscriber();
        factoryAction?.Invoke(subscriberResult);

        return subscriberResult;
    }

    private Humidifier.SecurityLake.Subscriber CreateSubscriber()
    {
        var subscriberResult = new Humidifier.SecurityLake.Subscriber
        {
            GivenName = InputResourceName,
        };

        return subscriberResult;
    }
    public override void CreateChildren(Humidifier.SecurityLake.Subscriber result)
    {
        base.CreateChildren(result);

        result.Sources = SourcesFactories.Any() ? SourcesFactories.Select(x => x.Build()).ToList() : null;
        result.SubscriberIdentity ??= SubscriberIdentityFactory?.Build();
    }

} // End Of Class

public static class SubscriberFactoryExtensions
{
    public static CombinedResult<SubscriberFactory, InnerSubscriberSourceFactory> WithSources(this SubscriberFactory parentFactory, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null)
    {
        var factory = new InnerSubscriberSourceFactory(subFactoryAction);
        parentFactory.SourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SubscriberFactory, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity(this SubscriberFactory parentFactory, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null)
    {
        parentFactory.SubscriberIdentityFactory = new InnerSubscriberSubscriberIdentityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SubscriberIdentityFactory);
    }

    public static CombinedResult<SubscriberFactory, T1, InnerSubscriberSourceFactory> WithSources<T1>(this CombinedResult<SubscriberFactory, T1> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberFactory, InnerSubscriberSourceFactory> WithSources<T1>(this CombinedResult<T1, SubscriberFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SubscriberFactory, T1, T2, InnerSubscriberSourceFactory> WithSources<T1, T2>(this CombinedResult<SubscriberFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberFactory, T2, InnerSubscriberSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, SubscriberFactory, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriberFactory, InnerSubscriberSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, T2, SubscriberFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SubscriberFactory, T1, T2, T3, InnerSubscriberSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<SubscriberFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberFactory, T2, T3, InnerSubscriberSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, SubscriberFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriberFactory, T3, InnerSubscriberSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, SubscriberFactory, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriberFactory, InnerSubscriberSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, SubscriberFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SubscriberFactory, T1, T2, T3, T4, InnerSubscriberSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<SubscriberFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberFactory, T2, T3, T4, InnerSubscriberSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, SubscriberFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriberFactory, T3, T4, InnerSubscriberSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, SubscriberFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriberFactory, T4, InnerSubscriberSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SubscriberFactory, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SubscriberFactory, InnerSubscriberSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SubscriberFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SubscriberFactory, T1, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1>(this CombinedResult<SubscriberFactory, T1> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberFactory, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1>(this CombinedResult<T1, SubscriberFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SubscriberFactory, T1, T2, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2>(this CombinedResult<SubscriberFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberFactory, T2, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2>(this CombinedResult<T1, SubscriberFactory, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriberFactory, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2>(this CombinedResult<T1, T2, SubscriberFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SubscriberFactory, T1, T2, T3, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2, T3>(this CombinedResult<SubscriberFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberFactory, T2, T3, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2, T3>(this CombinedResult<T1, SubscriberFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriberFactory, T3, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2, T3>(this CombinedResult<T1, T2, SubscriberFactory, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriberFactory, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2, T3>(this CombinedResult<T1, T2, T3, SubscriberFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SubscriberFactory, T1, T2, T3, T4, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2, T3, T4>(this CombinedResult<SubscriberFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberFactory, T2, T3, T4, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2, T3, T4>(this CombinedResult<T1, SubscriberFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriberFactory, T3, T4, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, SubscriberFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriberFactory, T4, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SubscriberFactory, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SubscriberFactory, InnerSubscriberSubscriberIdentityFactory> WithSubscriberIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SubscriberFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.SubscriberIdentity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscriberIdentity(combinedResult.T5, subFactoryAction));
}
