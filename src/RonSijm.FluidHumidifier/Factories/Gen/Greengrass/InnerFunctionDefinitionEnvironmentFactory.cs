// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionEnvironmentFactory(Action<Humidifier.Greengrass.FunctionDefinitionTypes.Environment> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionTypes.Environment>
{

    internal InnerFunctionDefinitionExecutionFactory ExecutionFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionTypes.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionTypes.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.Greengrass.FunctionDefinitionTypes.Environment();

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionTypes.Environment result)
    {
        base.CreateChildren(result);

        result.Execution ??= ExecutionFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionEnvironmentFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionEnvironmentFactory, InnerFunctionDefinitionExecutionFactory> WithExecution(this InnerFunctionDefinitionEnvironmentFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null)
    {
        parentFactory.ExecutionFactory = new InnerFunctionDefinitionExecutionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExecutionFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionEnvironmentFactory, T1, InnerFunctionDefinitionExecutionFactory> WithExecution<T1>(this CombinedResult<InnerFunctionDefinitionEnvironmentFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionEnvironmentFactory, InnerFunctionDefinitionExecutionFactory> WithExecution<T1>(this CombinedResult<T1, InnerFunctionDefinitionEnvironmentFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionEnvironmentFactory, T1, T2, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<InnerFunctionDefinitionEnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionEnvironmentFactory, T2, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionEnvironmentFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionEnvironmentFactory, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionEnvironmentFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionEnvironmentFactory, T1, T2, T3, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionEnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionEnvironmentFactory, T2, T3, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionEnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionEnvironmentFactory, T3, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionEnvironmentFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionEnvironmentFactory, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionEnvironmentFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionEnvironmentFactory, T1, T2, T3, T4, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionEnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionEnvironmentFactory, T2, T3, T4, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionEnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionEnvironmentFactory, T3, T4, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionEnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionEnvironmentFactory, T4, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionEnvironmentFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionEnvironmentFactory, InnerFunctionDefinitionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionEnvironmentFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T5, subFactoryAction));
}
