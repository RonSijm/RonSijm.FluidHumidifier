// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionVersionDefaultConfigFactory(Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig>
{

    internal InnerFunctionDefinitionVersionExecutionFactory ExecutionFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig Create()
    {
        var defaultConfigResult = CreateDefaultConfig();
        factoryAction?.Invoke(defaultConfigResult);

        return defaultConfigResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig CreateDefaultConfig()
    {
        var defaultConfigResult = new Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig();

        return defaultConfigResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionVersionTypes.DefaultConfig result)
    {
        base.CreateChildren(result);

        result.Execution ??= ExecutionFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionVersionDefaultConfigFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionVersionDefaultConfigFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution(this InnerFunctionDefinitionVersionDefaultConfigFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null)
    {
        parentFactory.ExecutionFactory = new InnerFunctionDefinitionVersionExecutionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExecutionFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionVersionDefaultConfigFactory, T1, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1>(this CombinedResult<InnerFunctionDefinitionVersionDefaultConfigFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionDefaultConfigFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1>(this CombinedResult<T1, InnerFunctionDefinitionVersionDefaultConfigFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionDefaultConfigFactory, T1, T2, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<InnerFunctionDefinitionVersionDefaultConfigFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionDefaultConfigFactory, T2, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionVersionDefaultConfigFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionDefaultConfigFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionDefaultConfigFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionDefaultConfigFactory, T1, T2, T3, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionVersionDefaultConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionDefaultConfigFactory, T2, T3, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionVersionDefaultConfigFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionDefaultConfigFactory, T3, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionDefaultConfigFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionDefaultConfigFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionDefaultConfigFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionDefaultConfigFactory, T1, T2, T3, T4, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionVersionDefaultConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionDefaultConfigFactory, T2, T3, T4, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionVersionDefaultConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionDefaultConfigFactory, T3, T4, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionDefaultConfigFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionDefaultConfigFactory, T4, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionDefaultConfigFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionDefaultConfigFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionDefaultConfigFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T5, subFactoryAction));
}
