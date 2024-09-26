// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardObjectiveFunctionFactory(Action<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction>
{

    internal InnerModelCardFunctionFactory FunctionFactory { get; set; }

    protected override Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction Create()
    {
        var objectiveFunctionResult = CreateObjectiveFunction();
        factoryAction?.Invoke(objectiveFunctionResult);

        return objectiveFunctionResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction CreateObjectiveFunction()
    {
        var objectiveFunctionResult = new Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction();

        return objectiveFunctionResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelCardTypes.ObjectiveFunction result)
    {
        base.CreateChildren(result);

        result.Function ??= FunctionFactory?.Build();
    }

} // End Of Class

public static class InnerModelCardObjectiveFunctionFactoryExtensions
{
    public static CombinedResult<InnerModelCardObjectiveFunctionFactory, InnerModelCardFunctionFactory> WithFunction(this InnerModelCardObjectiveFunctionFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null)
    {
        parentFactory.FunctionFactory = new InnerModelCardFunctionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FunctionFactory);
    }

    public static CombinedResult<InnerModelCardObjectiveFunctionFactory, T1, InnerModelCardFunctionFactory> WithFunction<T1>(this CombinedResult<InnerModelCardObjectiveFunctionFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardObjectiveFunctionFactory, InnerModelCardFunctionFactory> WithFunction<T1>(this CombinedResult<T1, InnerModelCardObjectiveFunctionFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelCardObjectiveFunctionFactory, T1, T2, InnerModelCardFunctionFactory> WithFunction<T1, T2>(this CombinedResult<InnerModelCardObjectiveFunctionFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardObjectiveFunctionFactory, T2, InnerModelCardFunctionFactory> WithFunction<T1, T2>(this CombinedResult<T1, InnerModelCardObjectiveFunctionFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardObjectiveFunctionFactory, InnerModelCardFunctionFactory> WithFunction<T1, T2>(this CombinedResult<T1, T2, InnerModelCardObjectiveFunctionFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelCardObjectiveFunctionFactory, T1, T2, T3, InnerModelCardFunctionFactory> WithFunction<T1, T2, T3>(this CombinedResult<InnerModelCardObjectiveFunctionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardObjectiveFunctionFactory, T2, T3, InnerModelCardFunctionFactory> WithFunction<T1, T2, T3>(this CombinedResult<T1, InnerModelCardObjectiveFunctionFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardObjectiveFunctionFactory, T3, InnerModelCardFunctionFactory> WithFunction<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelCardObjectiveFunctionFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardObjectiveFunctionFactory, InnerModelCardFunctionFactory> WithFunction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelCardObjectiveFunctionFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelCardObjectiveFunctionFactory, T1, T2, T3, T4, InnerModelCardFunctionFactory> WithFunction<T1, T2, T3, T4>(this CombinedResult<InnerModelCardObjectiveFunctionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardObjectiveFunctionFactory, T2, T3, T4, InnerModelCardFunctionFactory> WithFunction<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelCardObjectiveFunctionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardObjectiveFunctionFactory, T3, T4, InnerModelCardFunctionFactory> WithFunction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelCardObjectiveFunctionFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardObjectiveFunctionFactory, T4, InnerModelCardFunctionFactory> WithFunction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelCardObjectiveFunctionFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelCardObjectiveFunctionFactory, InnerModelCardFunctionFactory> WithFunction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelCardObjectiveFunctionFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.Function> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunction(combinedResult.T5, subFactoryAction));
}
