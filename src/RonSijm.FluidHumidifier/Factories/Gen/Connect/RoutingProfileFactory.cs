// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class RoutingProfileFactory(string resourceName = null, Action<Humidifier.Connect.RoutingProfile> factoryAction = null) : ResourceFactory<Humidifier.Connect.RoutingProfile>(resourceName)
{

    internal List<InnerRoutingProfileMediaConcurrencyFactory> MediaConcurrenciesFactories { get; set; } = [];

    internal List<InnerRoutingProfileRoutingProfileQueueConfigFactory> QueueConfigsFactories { get; set; } = [];

    protected override Humidifier.Connect.RoutingProfile Create()
    {
        var routingProfileResult = CreateRoutingProfile();
        factoryAction?.Invoke(routingProfileResult);

        return routingProfileResult;
    }

    private Humidifier.Connect.RoutingProfile CreateRoutingProfile()
    {
        var routingProfileResult = new Humidifier.Connect.RoutingProfile
        {
            GivenName = InputResourceName,
        };

        return routingProfileResult;
    }
    public override void CreateChildren(Humidifier.Connect.RoutingProfile result)
    {
        base.CreateChildren(result);

        result.MediaConcurrencies = MediaConcurrenciesFactories.Any() ? MediaConcurrenciesFactories.Select(x => x.Build()).ToList() : null;
        result.QueueConfigs = QueueConfigsFactories.Any() ? QueueConfigsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RoutingProfileFactoryExtensions
{
    public static CombinedResult<RoutingProfileFactory, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies(this RoutingProfileFactory parentFactory, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null)
    {
        var factory = new InnerRoutingProfileMediaConcurrencyFactory(subFactoryAction);
        parentFactory.MediaConcurrenciesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RoutingProfileFactory, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs(this RoutingProfileFactory parentFactory, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null)
    {
        var factory = new InnerRoutingProfileRoutingProfileQueueConfigFactory(subFactoryAction);
        parentFactory.QueueConfigsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RoutingProfileFactory, T1, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1>(this CombinedResult<RoutingProfileFactory, T1> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoutingProfileFactory, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1>(this CombinedResult<T1, RoutingProfileFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RoutingProfileFactory, T1, T2, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2>(this CombinedResult<RoutingProfileFactory, T1, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoutingProfileFactory, T2, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2>(this CombinedResult<T1, RoutingProfileFactory, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoutingProfileFactory, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2>(this CombinedResult<T1, T2, RoutingProfileFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RoutingProfileFactory, T1, T2, T3, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2, T3>(this CombinedResult<RoutingProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoutingProfileFactory, T2, T3, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2, T3>(this CombinedResult<T1, RoutingProfileFactory, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoutingProfileFactory, T3, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2, T3>(this CombinedResult<T1, T2, RoutingProfileFactory, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RoutingProfileFactory, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2, T3>(this CombinedResult<T1, T2, T3, RoutingProfileFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RoutingProfileFactory, T1, T2, T3, T4, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2, T3, T4>(this CombinedResult<RoutingProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoutingProfileFactory, T2, T3, T4, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2, T3, T4>(this CombinedResult<T1, RoutingProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoutingProfileFactory, T3, T4, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2, T3, T4>(this CombinedResult<T1, T2, RoutingProfileFactory, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RoutingProfileFactory, T4, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RoutingProfileFactory, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RoutingProfileFactory, InnerRoutingProfileMediaConcurrencyFactory> WithMediaConcurrencies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RoutingProfileFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMediaConcurrencies(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RoutingProfileFactory, T1, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1>(this CombinedResult<RoutingProfileFactory, T1> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueueConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoutingProfileFactory, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1>(this CombinedResult<T1, RoutingProfileFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueueConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RoutingProfileFactory, T1, T2, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2>(this CombinedResult<RoutingProfileFactory, T1, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoutingProfileFactory, T2, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2>(this CombinedResult<T1, RoutingProfileFactory, T2> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoutingProfileFactory, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2>(this CombinedResult<T1, T2, RoutingProfileFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RoutingProfileFactory, T1, T2, T3, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2, T3>(this CombinedResult<RoutingProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoutingProfileFactory, T2, T3, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2, T3>(this CombinedResult<T1, RoutingProfileFactory, T2, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoutingProfileFactory, T3, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2, T3>(this CombinedResult<T1, T2, RoutingProfileFactory, T3> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RoutingProfileFactory, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2, T3>(this CombinedResult<T1, T2, T3, RoutingProfileFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RoutingProfileFactory, T1, T2, T3, T4, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2, T3, T4>(this CombinedResult<RoutingProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoutingProfileFactory, T2, T3, T4, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2, T3, T4>(this CombinedResult<T1, RoutingProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoutingProfileFactory, T3, T4, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, RoutingProfileFactory, T3, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RoutingProfileFactory, T4, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RoutingProfileFactory, T4> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RoutingProfileFactory, InnerRoutingProfileRoutingProfileQueueConfigFactory> WithQueueConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RoutingProfileFactory> combinedResult, Action<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueueConfigs(combinedResult.T5, subFactoryAction));
}
