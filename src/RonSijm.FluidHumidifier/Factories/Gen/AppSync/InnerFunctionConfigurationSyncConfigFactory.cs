// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerFunctionConfigurationSyncConfigFactory(Action<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig>
{

    internal InnerFunctionConfigurationLambdaConflictHandlerConfigFactory LambdaConflictHandlerConfigFactory { get; set; }

    protected override Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig Create()
    {
        var syncConfigResult = CreateSyncConfig();
        factoryAction?.Invoke(syncConfigResult);

        return syncConfigResult;
    }

    private Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig CreateSyncConfig()
    {
        var syncConfigResult = new Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig();

        return syncConfigResult;
    }
    public override void CreateChildren(Humidifier.AppSync.FunctionConfigurationTypes.SyncConfig result)
    {
        base.CreateChildren(result);

        result.LambdaConflictHandlerConfig ??= LambdaConflictHandlerConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionConfigurationSyncConfigFactoryExtensions
{
    public static CombinedResult<InnerFunctionConfigurationSyncConfigFactory, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig(this InnerFunctionConfigurationSyncConfigFactory parentFactory, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null)
    {
        parentFactory.LambdaConflictHandlerConfigFactory = new InnerFunctionConfigurationLambdaConflictHandlerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaConflictHandlerConfigFactory);
    }

    public static CombinedResult<InnerFunctionConfigurationSyncConfigFactory, T1, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1>(this CombinedResult<InnerFunctionConfigurationSyncConfigFactory, T1> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionConfigurationSyncConfigFactory, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1>(this CombinedResult<T1, InnerFunctionConfigurationSyncConfigFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionConfigurationSyncConfigFactory, T1, T2, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2>(this CombinedResult<InnerFunctionConfigurationSyncConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionConfigurationSyncConfigFactory, T2, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2>(this CombinedResult<T1, InnerFunctionConfigurationSyncConfigFactory, T2> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionConfigurationSyncConfigFactory, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2>(this CombinedResult<T1, T2, InnerFunctionConfigurationSyncConfigFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionConfigurationSyncConfigFactory, T1, T2, T3, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3>(this CombinedResult<InnerFunctionConfigurationSyncConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionConfigurationSyncConfigFactory, T2, T3, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3>(this CombinedResult<T1, InnerFunctionConfigurationSyncConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionConfigurationSyncConfigFactory, T3, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionConfigurationSyncConfigFactory, T3> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionConfigurationSyncConfigFactory, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionConfigurationSyncConfigFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionConfigurationSyncConfigFactory, T1, T2, T3, T4, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<InnerFunctionConfigurationSyncConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionConfigurationSyncConfigFactory, T2, T3, T4, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionConfigurationSyncConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionConfigurationSyncConfigFactory, T3, T4, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionConfigurationSyncConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionConfigurationSyncConfigFactory, T4, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionConfigurationSyncConfigFactory, T4> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionConfigurationSyncConfigFactory, InnerFunctionConfigurationLambdaConflictHandlerConfigFactory> WithLambdaConflictHandlerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionConfigurationSyncConfigFactory> combinedResult, Action<Humidifier.AppSync.FunctionConfigurationTypes.LambdaConflictHandlerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConflictHandlerConfig(combinedResult.T5, subFactoryAction));
}
