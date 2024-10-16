// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class ResolverFactory(string resourceName = null, Action<Humidifier.AppSync.Resolver> factoryAction = null) : ResourceFactory<Humidifier.AppSync.Resolver>(resourceName)
{

    internal InnerResolverPipelineConfigFactory PipelineConfigFactory { get; set; }

    internal InnerResolverSyncConfigFactory SyncConfigFactory { get; set; }

    internal InnerResolverAppSyncRuntimeFactory RuntimeFactory { get; set; }

    internal InnerResolverCachingConfigFactory CachingConfigFactory { get; set; }

    protected override Humidifier.AppSync.Resolver Create()
    {
        var resolverResult = CreateResolver();
        factoryAction?.Invoke(resolverResult);

        return resolverResult;
    }

    private Humidifier.AppSync.Resolver CreateResolver()
    {
        var resolverResult = new Humidifier.AppSync.Resolver
        {
            GivenName = InputResourceName,
        };

        return resolverResult;
    }
    public override void CreateChildren(Humidifier.AppSync.Resolver result)
    {
        base.CreateChildren(result);

        result.PipelineConfig ??= PipelineConfigFactory?.Build();
        result.SyncConfig ??= SyncConfigFactory?.Build();
        result.Runtime ??= RuntimeFactory?.Build();
        result.CachingConfig ??= CachingConfigFactory?.Build();
    }

} // End Of Class

public static class ResolverFactoryExtensions
{
    public static CombinedResult<ResolverFactory, InnerResolverPipelineConfigFactory> WithPipelineConfig(this ResolverFactory parentFactory, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null)
    {
        parentFactory.PipelineConfigFactory = new InnerResolverPipelineConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PipelineConfigFactory);
    }

    public static CombinedResult<ResolverFactory, InnerResolverSyncConfigFactory> WithSyncConfig(this ResolverFactory parentFactory, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null)
    {
        parentFactory.SyncConfigFactory = new InnerResolverSyncConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SyncConfigFactory);
    }

    public static CombinedResult<ResolverFactory, InnerResolverAppSyncRuntimeFactory> WithRuntime(this ResolverFactory parentFactory, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null)
    {
        parentFactory.RuntimeFactory = new InnerResolverAppSyncRuntimeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuntimeFactory);
    }

    public static CombinedResult<ResolverFactory, InnerResolverCachingConfigFactory> WithCachingConfig(this ResolverFactory parentFactory, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null)
    {
        parentFactory.CachingConfigFactory = new InnerResolverCachingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CachingConfigFactory);
    }

    public static CombinedResult<ResolverFactory, T1, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1>(this CombinedResult<ResolverFactory, T1> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPipelineConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1>(this CombinedResult<T1, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPipelineConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2>(this CombinedResult<ResolverFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2>(this CombinedResult<T1, ResolverFactory, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2>(this CombinedResult<T1, T2, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, T3, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2, T3>(this CombinedResult<ResolverFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, T3, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2, T3>(this CombinedResult<T1, ResolverFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, T3, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2, T3>(this CombinedResult<T1, T2, ResolverFactory, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverFactory, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, T3, T4, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2, T3, T4>(this CombinedResult<ResolverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, T3, T4, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2, T3, T4>(this CombinedResult<T1, ResolverFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, T3, T4, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResolverFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverFactory, T4, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResolverFactory, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResolverFactory, InnerResolverPipelineConfigFactory> WithPipelineConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.PipelineConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, InnerResolverSyncConfigFactory> WithSyncConfig<T1>(this CombinedResult<ResolverFactory, T1> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, InnerResolverSyncConfigFactory> WithSyncConfig<T1>(this CombinedResult<T1, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2>(this CombinedResult<ResolverFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2>(this CombinedResult<T1, ResolverFactory, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2>(this CombinedResult<T1, T2, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, T3, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2, T3>(this CombinedResult<ResolverFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, T3, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2, T3>(this CombinedResult<T1, ResolverFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, T3, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2, T3>(this CombinedResult<T1, T2, ResolverFactory, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverFactory, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, T3, T4, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<ResolverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, T3, T4, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, ResolverFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, T3, T4, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResolverFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverFactory, T4, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResolverFactory, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResolverFactory, InnerResolverSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1>(this CombinedResult<ResolverFactory, T1> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1>(this CombinedResult<T1, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2>(this CombinedResult<ResolverFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2>(this CombinedResult<T1, ResolverFactory, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2>(this CombinedResult<T1, T2, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, T3, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2, T3>(this CombinedResult<ResolverFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, T3, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2, T3>(this CombinedResult<T1, ResolverFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, T3, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2, T3>(this CombinedResult<T1, T2, ResolverFactory, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverFactory, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, T3, T4, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<ResolverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, T3, T4, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<T1, ResolverFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, T3, T4, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResolverFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverFactory, T4, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResolverFactory, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResolverFactory, InnerResolverAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, InnerResolverCachingConfigFactory> WithCachingConfig<T1>(this CombinedResult<ResolverFactory, T1> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCachingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, InnerResolverCachingConfigFactory> WithCachingConfig<T1>(this CombinedResult<T1, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCachingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2>(this CombinedResult<ResolverFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2>(this CombinedResult<T1, ResolverFactory, T2> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2>(this CombinedResult<T1, T2, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, T3, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2, T3>(this CombinedResult<ResolverFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, T3, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2, T3>(this CombinedResult<T1, ResolverFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, T3, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2, T3>(this CombinedResult<T1, T2, ResolverFactory, T3> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverFactory, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResolverFactory, T1, T2, T3, T4, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2, T3, T4>(this CombinedResult<ResolverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverFactory, T2, T3, T4, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2, T3, T4>(this CombinedResult<T1, ResolverFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverFactory, T3, T4, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResolverFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverFactory, T4, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResolverFactory, T4> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResolverFactory, InnerResolverCachingConfigFactory> WithCachingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResolverFactory> combinedResult, Action<Humidifier.AppSync.ResolverTypes.CachingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCachingConfig(combinedResult.T5, subFactoryAction));
}
