// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerResolverSyncConfigFactory(Action<Humidifier.AppSync.ResolverTypes.SyncConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.ResolverTypes.SyncConfig>
{

    internal InnerResolverLambdaConflictHandlerConfigFactory LambdaConflictHandlerConfigFactory { get; set; }

    protected override Humidifier.AppSync.ResolverTypes.SyncConfig Create()
    {
        var syncConfigResult = CreateSyncConfig();
        factoryAction?.Invoke(syncConfigResult);

        return syncConfigResult;
    }

    private Humidifier.AppSync.ResolverTypes.SyncConfig CreateSyncConfig()
    {
        var syncConfigResult = new Humidifier.AppSync.ResolverTypes.SyncConfig();

        return syncConfigResult;
    }
    public override void CreateChildren(Humidifier.AppSync.ResolverTypes.SyncConfig result)
    {
        base.CreateChildren(result);

        result.LambdaConflictHandlerConfig ??= LambdaConflictHandlerConfigFactory?.Build();
    }

} // End Of Class

public static class InnerResolverSyncConfigFactoryExtensions
{
    public static CombinedResult<InnerResolverSyncConfigFactory, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig(this InnerResolverSyncConfigFactory parentFactory, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null)
    {
        parentFactory.LambdaConflictHandlerConfigFactory = new InnerResolverLambdaConflictHandlerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaConflictHandlerConfigFactory);
    }

    public static CombinedResult<InnerResolverSyncConfigFactory, T1, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1>(this CombinedResult<InnerResolverSyncConfigFactory, T1> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResolverSyncConfigFactory, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1>(this CombinedResult<T1, InnerResolverSyncConfigFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResolverSyncConfigFactory, T1, T2, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2>(this CombinedResult<InnerResolverSyncConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResolverSyncConfigFactory, T2, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2>(this CombinedResult<T1, InnerResolverSyncConfigFactory, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResolverSyncConfigFactory, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2>(this CombinedResult<T1, T2, InnerResolverSyncConfigFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResolverSyncConfigFactory, T1, T2, T3, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3>(this CombinedResult<InnerResolverSyncConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResolverSyncConfigFactory, T2, T3, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3>(this CombinedResult<T1, InnerResolverSyncConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResolverSyncConfigFactory, T3, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerResolverSyncConfigFactory, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResolverSyncConfigFactory, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResolverSyncConfigFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResolverSyncConfigFactory, T1, T2, T3, T4, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<InnerResolverSyncConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResolverSyncConfigFactory, T2, T3, T4, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerResolverSyncConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResolverSyncConfigFactory, T3, T4, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResolverSyncConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResolverSyncConfigFactory, T4, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResolverSyncConfigFactory, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResolverSyncConfigFactory, InnerResolverLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResolverSyncConfigFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T5, subFactoryAction));
}
