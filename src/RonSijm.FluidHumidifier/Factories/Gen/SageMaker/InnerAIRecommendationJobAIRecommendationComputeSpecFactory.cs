// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIRecommendationJobAIRecommendationComputeSpecFactory(Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationComputeSpec> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationComputeSpec>
{

    internal InnerAIRecommendationJobAICapacityReservationConfigFactory CapacityReservationConfigFactory { get; set; }

    protected override Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationComputeSpec Create()
    {
        var aIRecommendationComputeSpecResult = CreateAIRecommendationComputeSpec();
        factoryAction?.Invoke(aIRecommendationComputeSpecResult);

        return aIRecommendationComputeSpecResult;
    }

    private Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationComputeSpec CreateAIRecommendationComputeSpec()
    {
        var aIRecommendationComputeSpecResult = new Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationComputeSpec();

        return aIRecommendationComputeSpecResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationComputeSpec result)
    {
        base.CreateChildren(result);

        result.CapacityReservationConfig ??= CapacityReservationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerAIRecommendationJobAIRecommendationComputeSpecFactoryExtensions
{
    public static CombinedResult<InnerAIRecommendationJobAIRecommendationComputeSpecFactory, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig(this InnerAIRecommendationJobAIRecommendationComputeSpecFactory parentFactory, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null)
    {
        parentFactory.CapacityReservationConfigFactory = new InnerAIRecommendationJobAICapacityReservationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationConfigFactory);
    }

    public static CombinedResult<InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T1, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1>(this CombinedResult<InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T1> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1>(this CombinedResult<T1, InnerAIRecommendationJobAIRecommendationComputeSpecFactory> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T1, T2, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2>(this CombinedResult<InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T2, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2>(this CombinedResult<T1, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T2> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2>(this CombinedResult<T1, T2, InnerAIRecommendationJobAIRecommendationComputeSpecFactory> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T1, T2, T3, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2, T3>(this CombinedResult<InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T2, T3, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2, T3>(this CombinedResult<T1, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T3, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T3> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAIRecommendationJobAIRecommendationComputeSpecFactory> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T1, T2, T3, T4, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2, T3, T4>(this CombinedResult<InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T2, T3, T4, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T3, T4, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T4, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, T4> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAIRecommendationJobAIRecommendationComputeSpecFactory, InnerAIRecommendationJobAICapacityReservationConfigFactory> WithCapacityReservationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAIRecommendationJobAIRecommendationComputeSpecFactory> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationConfig(combinedResult.T5, subFactoryAction).T2);
}
