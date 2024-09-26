// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardModelOverviewFactory(Action<Humidifier.SageMaker.ModelCardTypes.ModelOverview> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.ModelOverview>
{

    internal InnerModelCardInferenceEnvironmentFactory InferenceEnvironmentFactory { get; set; }

    protected override Humidifier.SageMaker.ModelCardTypes.ModelOverview Create()
    {
        var modelOverviewResult = CreateModelOverview();
        factoryAction?.Invoke(modelOverviewResult);

        return modelOverviewResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.ModelOverview CreateModelOverview()
    {
        var modelOverviewResult = new Humidifier.SageMaker.ModelCardTypes.ModelOverview();

        return modelOverviewResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelCardTypes.ModelOverview result)
    {
        base.CreateChildren(result);

        result.InferenceEnvironment ??= InferenceEnvironmentFactory?.Build();
    }

} // End Of Class

public static class InnerModelCardModelOverviewFactoryExtensions
{
    public static CombinedResult<InnerModelCardModelOverviewFactory, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment(this InnerModelCardModelOverviewFactory parentFactory, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null)
    {
        parentFactory.InferenceEnvironmentFactory = new InnerModelCardInferenceEnvironmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InferenceEnvironmentFactory);
    }

    public static CombinedResult<InnerModelCardModelOverviewFactory, T1, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1>(this CombinedResult<InnerModelCardModelOverviewFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelOverviewFactory, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1>(this CombinedResult<T1, InnerModelCardModelOverviewFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelCardModelOverviewFactory, T1, T2, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2>(this CombinedResult<InnerModelCardModelOverviewFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelOverviewFactory, T2, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2>(this CombinedResult<T1, InnerModelCardModelOverviewFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardModelOverviewFactory, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2>(this CombinedResult<T1, T2, InnerModelCardModelOverviewFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelCardModelOverviewFactory, T1, T2, T3, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2, T3>(this CombinedResult<InnerModelCardModelOverviewFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelOverviewFactory, T2, T3, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2, T3>(this CombinedResult<T1, InnerModelCardModelOverviewFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardModelOverviewFactory, T3, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelCardModelOverviewFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardModelOverviewFactory, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelCardModelOverviewFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelCardModelOverviewFactory, T1, T2, T3, T4, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2, T3, T4>(this CombinedResult<InnerModelCardModelOverviewFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelCardModelOverviewFactory, T2, T3, T4, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelCardModelOverviewFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelCardModelOverviewFactory, T3, T4, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelCardModelOverviewFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelCardModelOverviewFactory, T4, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelCardModelOverviewFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelCardModelOverviewFactory, InnerModelCardInferenceEnvironmentFactory> WithInferenceEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelCardModelOverviewFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceEnvironment(combinedResult.T5, subFactoryAction));
}
