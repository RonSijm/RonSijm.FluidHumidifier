// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionExecutionFactory(Action<Humidifier.Greengrass.FunctionDefinitionTypes.Execution> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionTypes.Execution>
{

    internal InnerFunctionDefinitionRunAsFactory RunAsFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionTypes.Execution Create()
    {
        var executionResult = CreateExecution();
        factoryAction?.Invoke(executionResult);

        return executionResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionTypes.Execution CreateExecution()
    {
        var executionResult = new Humidifier.Greengrass.FunctionDefinitionTypes.Execution();

        return executionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionTypes.Execution result)
    {
        base.CreateChildren(result);

        result.RunAs ??= RunAsFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionExecutionFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionExecutionFactory, InnerFunctionDefinitionRunAsFactory> WithRunAs(this InnerFunctionDefinitionExecutionFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null)
    {
        parentFactory.RunAsFactory = new InnerFunctionDefinitionRunAsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RunAsFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionExecutionFactory, T1, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1>(this CombinedResult<InnerFunctionDefinitionExecutionFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, WithRunAs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionExecutionFactory, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1>(this CombinedResult<T1, InnerFunctionDefinitionExecutionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, WithRunAs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionExecutionFactory, T1, T2, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2>(this CombinedResult<InnerFunctionDefinitionExecutionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionExecutionFactory, T2, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionExecutionFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionExecutionFactory, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionExecutionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionExecutionFactory, T1, T2, T3, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionExecutionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionExecutionFactory, T2, T3, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionExecutionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionExecutionFactory, T3, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionExecutionFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionExecutionFactory, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionExecutionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionExecutionFactory, T1, T2, T3, T4, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionExecutionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionExecutionFactory, T2, T3, T4, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionExecutionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionExecutionFactory, T3, T4, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionExecutionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionExecutionFactory, T4, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionExecutionFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionExecutionFactory, InnerFunctionDefinitionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionExecutionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T5, subFactoryAction));
}
