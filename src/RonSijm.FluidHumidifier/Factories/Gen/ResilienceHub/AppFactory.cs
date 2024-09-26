// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHub;

public class AppFactory(string resourceName = null, Action<Humidifier.ResilienceHub.App> factoryAction = null) : ResourceFactory<Humidifier.ResilienceHub.App>(resourceName)
{

    internal List<InnerAppResourceMappingFactory> ResourceMappingsFactories { get; set; } = [];

    internal List<InnerAppEventSubscriptionFactory> EventSubscriptionsFactories { get; set; } = [];

    internal InnerAppPermissionModelFactory PermissionModelFactory { get; set; }

    protected override Humidifier.ResilienceHub.App Create()
    {
        var appResult = CreateApp();
        factoryAction?.Invoke(appResult);

        return appResult;
    }

    private Humidifier.ResilienceHub.App CreateApp()
    {
        var appResult = new Humidifier.ResilienceHub.App
        {
            GivenName = InputResourceName,
        };

        return appResult;
    }
    public override void CreateChildren(Humidifier.ResilienceHub.App result)
    {
        base.CreateChildren(result);

        result.ResourceMappings = ResourceMappingsFactories.Any() ? ResourceMappingsFactories.Select(x => x.Build()).ToList() : null;
        result.EventSubscriptions = EventSubscriptionsFactories.Any() ? EventSubscriptionsFactories.Select(x => x.Build()).ToList() : null;
        result.PermissionModel ??= PermissionModelFactory?.Build();
    }

} // End Of Class

public static class AppFactoryExtensions
{
    public static CombinedResult<AppFactory, InnerAppResourceMappingFactory> WithResourceMappings(this AppFactory parentFactory, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null)
    {
        var factory = new InnerAppResourceMappingFactory(subFactoryAction);
        parentFactory.ResourceMappingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AppFactory, InnerAppEventSubscriptionFactory> WithEventSubscriptions(this AppFactory parentFactory, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null)
    {
        var factory = new InnerAppEventSubscriptionFactory(subFactoryAction);
        parentFactory.EventSubscriptionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AppFactory, InnerAppPermissionModelFactory> WithPermissionModel(this AppFactory parentFactory, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null)
    {
        parentFactory.PermissionModelFactory = new InnerAppPermissionModelFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PermissionModelFactory);
    }

    public static CombinedResult<AppFactory, T1, InnerAppResourceMappingFactory> WithResourceMappings<T1>(this CombinedResult<AppFactory, T1> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, InnerAppResourceMappingFactory> WithResourceMappings<T1>(this CombinedResult<T1, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2>(this CombinedResult<AppFactory, T1, T2> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2>(this CombinedResult<T1, AppFactory, T2> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2>(this CombinedResult<T1, T2, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2, T3>(this CombinedResult<AppFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2, T3>(this CombinedResult<T1, AppFactory, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2, T3>(this CombinedResult<T1, T2, AppFactory, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, T4, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2, T3, T4>(this CombinedResult<AppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, T4, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2, T3, T4>(this CombinedResult<T1, AppFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, T4, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppFactory, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, T4, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppFactory, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppFactory, InnerAppResourceMappingFactory> WithResourceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceMappings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AppFactory, T1, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1>(this CombinedResult<AppFactory, T1> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1>(this CombinedResult<T1, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2>(this CombinedResult<AppFactory, T1, T2> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2>(this CombinedResult<T1, AppFactory, T2> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2>(this CombinedResult<T1, T2, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2, T3>(this CombinedResult<AppFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2, T3>(this CombinedResult<T1, AppFactory, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2, T3>(this CombinedResult<T1, T2, AppFactory, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, T4, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2, T3, T4>(this CombinedResult<AppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, T4, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, AppFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, T4, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppFactory, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, T4, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppFactory, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppFactory, InnerAppEventSubscriptionFactory> WithEventSubscriptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSubscriptions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AppFactory, T1, InnerAppPermissionModelFactory> WithPermissionModel<T1>(this CombinedResult<AppFactory, T1> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissionModel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, InnerAppPermissionModelFactory> WithPermissionModel<T1>(this CombinedResult<T1, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissionModel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2>(this CombinedResult<AppFactory, T1, T2> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2>(this CombinedResult<T1, AppFactory, T2> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2>(this CombinedResult<T1, T2, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2, T3>(this CombinedResult<AppFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2, T3>(this CombinedResult<T1, AppFactory, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2, T3>(this CombinedResult<T1, T2, AppFactory, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, T4, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2, T3, T4>(this CombinedResult<AppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, T4, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2, T3, T4>(this CombinedResult<T1, AppFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, T4, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppFactory, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, T4, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppFactory, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppFactory, InnerAppPermissionModelFactory> WithPermissionModel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionModel(combinedResult.T5, subFactoryAction));
}
