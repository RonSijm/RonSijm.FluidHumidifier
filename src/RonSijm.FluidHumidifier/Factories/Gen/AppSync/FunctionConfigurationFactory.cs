// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class FunctionConfigurationFactory(string resourceName = null, Action<Humidifier.AppSync.FunctionConfiguration> factoryAction = null) : ResourceFactory<Humidifier.AppSync.FunctionConfiguration>(resourceName)
{

    internal InnerFunctionConfigurationSyncConfigFactory SyncConfigFactory { get; set; }

    internal InnerFunctionConfigurationAppSyncRuntimeFactory RuntimeFactory { get; set; }

    protected override Humidifier.AppSync.FunctionConfiguration Create()
    {
        var functionConfigurationResult = CreateFunctionConfiguration();
        factoryAction?.Invoke(functionConfigurationResult);

        return functionConfigurationResult;
    }

    private Humidifier.AppSync.FunctionConfiguration CreateFunctionConfiguration()
    {
        var functionConfigurationResult = new Humidifier.AppSync.FunctionConfiguration
        {
            GivenName = InputResourceName,
        };

        return functionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AppSync.FunctionConfiguration result)
    {
        base.CreateChildren(result);

        result.SyncConfig ??= SyncConfigFactory?.Build();
        result.Runtime ??= RuntimeFactory?.Build();
    }

} // End Of Class

public static class FunctionConfigurationFactoryExtensions
{
    public static CombinedResult<FunctionConfigurationFactory, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig(this FunctionConfigurationFactory parentFactory, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null)
    {
        parentFactory.SyncConfigFactory = new InnerFunctionConfigurationSyncConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SyncConfigFactory);
    }

    public static CombinedResult<FunctionConfigurationFactory, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime(this FunctionConfigurationFactory parentFactory, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null)
    {
        parentFactory.RuntimeFactory = new InnerFunctionConfigurationAppSyncRuntimeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuntimeFactory);
    }

    public static CombinedResult<FunctionConfigurationFactory, T1, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1>(this CombinedResult<FunctionConfigurationFactory, T1> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionConfigurationFactory, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1>(this CombinedResult<T1, FunctionConfigurationFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FunctionConfigurationFactory, T1, T2, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2>(this CombinedResult<FunctionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionConfigurationFactory, T2, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2>(this CombinedResult<T1, FunctionConfigurationFactory, T2> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionConfigurationFactory, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2>(this CombinedResult<T1, T2, FunctionConfigurationFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FunctionConfigurationFactory, T1, T2, T3, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2, T3>(this CombinedResult<FunctionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionConfigurationFactory, T2, T3, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2, T3>(this CombinedResult<T1, FunctionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionConfigurationFactory, T3, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2, T3>(this CombinedResult<T1, T2, FunctionConfigurationFactory, T3> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionConfigurationFactory, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, FunctionConfigurationFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FunctionConfigurationFactory, T1, T2, T3, T4, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<FunctionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionConfigurationFactory, T2, T3, T4, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, FunctionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionConfigurationFactory, T3, T4, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, FunctionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionConfigurationFactory, T4, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FunctionConfigurationFactory, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FunctionConfigurationFactory, InnerFunctionConfigurationSyncConfigFactory> WithSyncConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FunctionConfigurationFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FunctionConfigurationFactory, T1, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1>(this CombinedResult<FunctionConfigurationFactory, T1> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionConfigurationFactory, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1>(this CombinedResult<T1, FunctionConfigurationFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FunctionConfigurationFactory, T1, T2, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2>(this CombinedResult<FunctionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionConfigurationFactory, T2, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2>(this CombinedResult<T1, FunctionConfigurationFactory, T2> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionConfigurationFactory, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2>(this CombinedResult<T1, T2, FunctionConfigurationFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FunctionConfigurationFactory, T1, T2, T3, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2, T3>(this CombinedResult<FunctionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionConfigurationFactory, T2, T3, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2, T3>(this CombinedResult<T1, FunctionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionConfigurationFactory, T3, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2, T3>(this CombinedResult<T1, T2, FunctionConfigurationFactory, T3> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionConfigurationFactory, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2, T3>(this CombinedResult<T1, T2, T3, FunctionConfigurationFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FunctionConfigurationFactory, T1, T2, T3, T4, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<FunctionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionConfigurationFactory, T2, T3, T4, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<T1, FunctionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionConfigurationFactory, T3, T4, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<T1, T2, FunctionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionConfigurationFactory, T4, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FunctionConfigurationFactory, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FunctionConfigurationFactory, InnerFunctionConfigurationAppSyncRuntimeFactory> WithRuntime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FunctionConfigurationFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.AppSyncRuntime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntime(combinedResult.T5, subFactoryAction));
}
