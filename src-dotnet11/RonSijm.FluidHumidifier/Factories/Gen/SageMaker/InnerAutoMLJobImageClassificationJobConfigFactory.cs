// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobImageClassificationJobConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.ImageClassificationJobConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.ImageClassificationJobConfig>
{

    internal InnerAutoMLJobAutoMLJobCompletionCriteriaFactory CompletionCriteriaFactory { get; set; }

    protected override Humidifier.SageMaker.AutoMLJobTypes.ImageClassificationJobConfig Create()
    {
        var imageClassificationJobConfigResult = CreateImageClassificationJobConfig();
        factoryAction?.Invoke(imageClassificationJobConfigResult);

        return imageClassificationJobConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.ImageClassificationJobConfig CreateImageClassificationJobConfig()
    {
        var imageClassificationJobConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.ImageClassificationJobConfig();

        return imageClassificationJobConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AutoMLJobTypes.ImageClassificationJobConfig result)
    {
        base.CreateChildren(result);

        result.CompletionCriteria ??= CompletionCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerAutoMLJobImageClassificationJobConfigFactoryExtensions
{
    public static CombinedResult<InnerAutoMLJobImageClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria(this InnerAutoMLJobImageClassificationJobConfigFactory parentFactory, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null)
    {
        parentFactory.CompletionCriteriaFactory = new InnerAutoMLJobAutoMLJobCompletionCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CompletionCriteriaFactory);
    }

    public static CombinedResult<InnerAutoMLJobImageClassificationJobConfigFactory, T1, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1>(this CombinedResult<InnerAutoMLJobImageClassificationJobConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobImageClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1>(this CombinedResult<T1, InnerAutoMLJobImageClassificationJobConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobImageClassificationJobConfigFactory, T1, T2, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2>(this CombinedResult<InnerAutoMLJobImageClassificationJobConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobImageClassificationJobConfigFactory, T2, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2>(this CombinedResult<T1, InnerAutoMLJobImageClassificationJobConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobImageClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2>(this CombinedResult<T1, T2, InnerAutoMLJobImageClassificationJobConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobImageClassificationJobConfigFactory, T1, T2, T3, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3>(this CombinedResult<InnerAutoMLJobImageClassificationJobConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobImageClassificationJobConfigFactory, T2, T3, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3>(this CombinedResult<T1, InnerAutoMLJobImageClassificationJobConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobImageClassificationJobConfigFactory, T3, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutoMLJobImageClassificationJobConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobImageClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutoMLJobImageClassificationJobConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobImageClassificationJobConfigFactory, T1, T2, T3, T4, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<InnerAutoMLJobImageClassificationJobConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobImageClassificationJobConfigFactory, T2, T3, T4, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutoMLJobImageClassificationJobConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobImageClassificationJobConfigFactory, T3, T4, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutoMLJobImageClassificationJobConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobImageClassificationJobConfigFactory, T4, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutoMLJobImageClassificationJobConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAutoMLJobImageClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutoMLJobImageClassificationJobConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T5, subFactoryAction).T2);
}
