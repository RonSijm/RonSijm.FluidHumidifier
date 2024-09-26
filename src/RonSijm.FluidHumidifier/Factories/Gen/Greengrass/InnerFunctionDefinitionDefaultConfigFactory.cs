// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionDefaultConfigFactory(Action<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig>
{

    internal InnerFunctionDefinitionExecutionFactory ExecutionFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig Create()
    {
        var defaultConfigResult = CreateDefaultConfig();
        factoryAction?.Invoke(defaultConfigResult);

        return defaultConfigResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig CreateDefaultConfig()
    {
        var defaultConfigResult = new Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig();

        return defaultConfigResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionTypes.DefaultConfig result)
    {
        base.CreateChildren(result);

        result.Execution ??= ExecutionFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionDefaultConfigFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionDefaultConfigFactory, InnerFunctionDefinitionExecutionFactory> WithExecution(this InnerFunctionDefinitionDefaultConfigFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null)
    {
        parentFactory.ExecutionFactory = new InnerFunctionDefinitionExecutionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExecutionFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionDefaultConfigFactory, T1, InnerFunctionDefinitionExecutionFactory> WithExecution<T1>(this CombinedResult<InnerFunctionDefinitionDefaultConfigFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionDefaultConfigFactory, InnerFunctionDefinitionExecutionFactory> WithExecution<T1>(this CombinedResult<T1, InnerFunctionDefinitionDefaultConfigFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionDefaultConfigFactory, T1, T2, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<InnerFunctionDefinitionDefaultConfigFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionDefaultConfigFactory, T2, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionDefaultConfigFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionDefaultConfigFactory, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionDefaultConfigFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionDefaultConfigFactory, T1, T2, T3, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionDefaultConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionDefaultConfigFactory, T2, T3, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionDefaultConfigFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionDefaultConfigFactory, T3, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionDefaultConfigFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionDefaultConfigFactory, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionDefaultConfigFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionDefaultConfigFactory, T1, T2, T3, T4, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionDefaultConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionDefaultConfigFactory, T2, T3, T4, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionDefaultConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionDefaultConfigFactory, T3, T4, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionDefaultConfigFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionDefaultConfigFactory, T4, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionDefaultConfigFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionDefaultConfigFactory, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionDefaultConfigFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T5, subFactoryAction));
}
