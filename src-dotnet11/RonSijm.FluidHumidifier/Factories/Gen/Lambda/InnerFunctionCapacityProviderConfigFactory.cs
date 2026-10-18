// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionCapacityProviderConfigFactory(Action<Humidifier.Lambda.FunctionTypes.CapacityProviderConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.CapacityProviderConfig>
{

    internal InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory LambdaManagedInstancesCapacityProviderConfigFactory { get; set; }

    protected override Humidifier.Lambda.FunctionTypes.CapacityProviderConfig Create()
    {
        var capacityProviderConfigResult = CreateCapacityProviderConfig();
        factoryAction?.Invoke(capacityProviderConfigResult);

        return capacityProviderConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.CapacityProviderConfig CreateCapacityProviderConfig()
    {
        var capacityProviderConfigResult = new Humidifier.Lambda.FunctionTypes.CapacityProviderConfig();

        return capacityProviderConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.FunctionTypes.CapacityProviderConfig result)
    {
        base.CreateChildren(result);

        result.LambdaManagedInstancesCapacityProviderConfig ??= LambdaManagedInstancesCapacityProviderConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionCapacityProviderConfigFactoryExtensions
{
    public static CombinedResult<InnerFunctionCapacityProviderConfigFactory, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig(this InnerFunctionCapacityProviderConfigFactory parentFactory, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null)
    {
        parentFactory.LambdaManagedInstancesCapacityProviderConfigFactory = new InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaManagedInstancesCapacityProviderConfigFactory);
    }

    public static CombinedResult<InnerFunctionCapacityProviderConfigFactory, T1, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1>(this CombinedResult<InnerFunctionCapacityProviderConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFunctionCapacityProviderConfigFactory, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1>(this CombinedResult<T1, InnerFunctionCapacityProviderConfigFactory> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFunctionCapacityProviderConfigFactory, T1, T2, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2>(this CombinedResult<InnerFunctionCapacityProviderConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFunctionCapacityProviderConfigFactory, T2, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2>(this CombinedResult<T1, InnerFunctionCapacityProviderConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFunctionCapacityProviderConfigFactory, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2>(this CombinedResult<T1, T2, InnerFunctionCapacityProviderConfigFactory> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFunctionCapacityProviderConfigFactory, T1, T2, T3, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2, T3>(this CombinedResult<InnerFunctionCapacityProviderConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFunctionCapacityProviderConfigFactory, T2, T3, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2, T3>(this CombinedResult<T1, InnerFunctionCapacityProviderConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFunctionCapacityProviderConfigFactory, T3, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionCapacityProviderConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFunctionCapacityProviderConfigFactory, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionCapacityProviderConfigFactory> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFunctionCapacityProviderConfigFactory, T1, T2, T3, T4, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2, T3, T4>(this CombinedResult<InnerFunctionCapacityProviderConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFunctionCapacityProviderConfigFactory, T2, T3, T4, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionCapacityProviderConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFunctionCapacityProviderConfigFactory, T3, T4, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionCapacityProviderConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFunctionCapacityProviderConfigFactory, T4, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionCapacityProviderConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionCapacityProviderConfigFactory, InnerFunctionLambdaManagedInstancesCapacityProviderConfigFactory> WithLambdaManagedInstancesCapacityProviderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionCapacityProviderConfigFactory> combinedResult, Action<Humidifier.Lambda.FunctionTypes.LambdaManagedInstancesCapacityProviderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaManagedInstancesCapacityProviderConfig(combinedResult.T5, subFactoryAction).T2);
}
