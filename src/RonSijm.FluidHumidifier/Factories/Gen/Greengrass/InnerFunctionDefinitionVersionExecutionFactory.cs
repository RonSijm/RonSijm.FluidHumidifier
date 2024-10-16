// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerFunctionDefinitionVersionExecutionFactory(Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution>
{

    internal InnerFunctionDefinitionVersionRunAsFactory RunAsFactory { get; set; }

    protected override Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution Create()
    {
        var executionResult = CreateExecution();
        factoryAction?.Invoke(executionResult);

        return executionResult;
    }

    private Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution CreateExecution()
    {
        var executionResult = new Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution();

        return executionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.FunctionDefinitionVersionTypes.Execution result)
    {
        base.CreateChildren(result);

        result.RunAs ??= RunAsFactory?.Build();
    }

} // End Of Class

public static class InnerFunctionDefinitionVersionExecutionFactoryExtensions
{
    public static CombinedResult<InnerFunctionDefinitionVersionExecutionFactory, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs(this InnerFunctionDefinitionVersionExecutionFactory parentFactory, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null)
    {
        parentFactory.RunAsFactory = new InnerFunctionDefinitionVersionRunAsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RunAsFactory);
    }

    public static CombinedResult<InnerFunctionDefinitionVersionExecutionFactory, T1, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1>(this CombinedResult<InnerFunctionDefinitionVersionExecutionFactory, T1> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, WithRunAs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionExecutionFactory, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1>(this CombinedResult<T1, InnerFunctionDefinitionVersionExecutionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, WithRunAs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionExecutionFactory, T1, T2, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2>(this CombinedResult<InnerFunctionDefinitionVersionExecutionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionExecutionFactory, T2, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2>(this CombinedResult<T1, InnerFunctionDefinitionVersionExecutionFactory, T2> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionExecutionFactory, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionExecutionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionExecutionFactory, T1, T2, T3, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2, T3>(this CombinedResult<InnerFunctionDefinitionVersionExecutionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionExecutionFactory, T2, T3, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2, T3>(this CombinedResult<T1, InnerFunctionDefinitionVersionExecutionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionExecutionFactory, T3, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2, T3>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionExecutionFactory, T3> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionExecutionFactory, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionExecutionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFunctionDefinitionVersionExecutionFactory, T1, T2, T3, T4, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<InnerFunctionDefinitionVersionExecutionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFunctionDefinitionVersionExecutionFactory, T2, T3, T4, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<T1, InnerFunctionDefinitionVersionExecutionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFunctionDefinitionVersionExecutionFactory, T3, T4, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFunctionDefinitionVersionExecutionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionExecutionFactory, T4, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFunctionDefinitionVersionExecutionFactory, T4> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionExecutionFactory, InnerFunctionDefinitionVersionRunAsFactory> WithRunAs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFunctionDefinitionVersionExecutionFactory> combinedResult, Action<Humidifier.Greengrass.FunctionDefinitionVersionTypes.RunAs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunAs(combinedResult.T5, subFactoryAction));
}
