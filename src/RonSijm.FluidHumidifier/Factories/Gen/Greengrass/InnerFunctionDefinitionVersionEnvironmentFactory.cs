// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionVersionEnvironmentFactory(Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment>
{

    internal InnerFunctionDefinitionVersionExecutionFactory ExecutionFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment();

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionVersionTypes.Environment result)
    {
        base.CreateChildren(result);

        result.Execution ??= ExecutionFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionVersionEnvironmentFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionVersionEnvironmentFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution(this InnerFunctionDefinitionVersionEnvironmentFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null)
    {
        parentFactory.ExecutionFactory = new InnerFunctionDefinitionVersionExecutionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExecutionFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionVersionEnvironmentFactory, T1, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1>(this CombinedResult<InnerFunctionDefinitionVersionEnvironmentFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionEnvironmentFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1>(this CombinedResult<T1, InnerFunctionDefinitionVersionEnvironmentFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionEnvironmentFactory, T1, T2, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<InnerFunctionDefinitionVersionEnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionEnvironmentFactory, T2, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionVersionEnvironmentFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionEnvironmentFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionEnvironmentFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionEnvironmentFactory, T1, T2, T3, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionVersionEnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionEnvironmentFactory, T2, T3, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionVersionEnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionEnvironmentFactory, T3, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionEnvironmentFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionEnvironmentFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionEnvironmentFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionEnvironmentFactory, T1, T2, T3, T4, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionVersionEnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionEnvironmentFactory, T2, T3, T4, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionVersionEnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionEnvironmentFactory, T3, T4, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionEnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionEnvironmentFactory, T4, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionEnvironmentFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionEnvironmentFactory, InnerFunctionDefinitionVersionExecutionFactory> WithExecution<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionEnvironmentFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecution(combinedResult.T5, subFactoryAction));
}
