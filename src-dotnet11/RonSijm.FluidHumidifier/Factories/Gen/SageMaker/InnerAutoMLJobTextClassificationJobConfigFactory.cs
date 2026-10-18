// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobTextClassificationJobConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.TextClassificationJobConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.TextClassificationJobConfig>
{

    internal InnerAutoMLJobAutoMLJobCompletionCriteriaFactory CompletionCriteriaFactory { get; set; }

    protected override Humidifier.SageMaker.AutoMLJobTypes.TextClassificationJobConfig Create()
    {
        var textClassificationJobConfigResult = CreateTextClassificationJobConfig();
        factoryAction?.Invoke(textClassificationJobConfigResult);

        return textClassificationJobConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.TextClassificationJobConfig CreateTextClassificationJobConfig()
    {
        var textClassificationJobConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.TextClassificationJobConfig();

        return textClassificationJobConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AutoMLJobTypes.TextClassificationJobConfig result)
    {
        base.CreateChildren(result);

        result.CompletionCriteria ??= CompletionCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerAutoMLJobTextClassificationJobConfigFactoryExtensions
{
    public static CombinedResult<InnerAutoMLJobTextClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria(this InnerAutoMLJobTextClassificationJobConfigFactory parentFactory, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null)
    {
        parentFactory.CompletionCriteriaFactory = new InnerAutoMLJobAutoMLJobCompletionCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CompletionCriteriaFactory);
    }

    public static CombinedResult<InnerAutoMLJobTextClassificationJobConfigFactory, T1, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1>(this CombinedResult<InnerAutoMLJobTextClassificationJobConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobTextClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1>(this CombinedResult<T1, InnerAutoMLJobTextClassificationJobConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobTextClassificationJobConfigFactory, T1, T2, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2>(this CombinedResult<InnerAutoMLJobTextClassificationJobConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobTextClassificationJobConfigFactory, T2, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2>(this CombinedResult<T1, InnerAutoMLJobTextClassificationJobConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobTextClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2>(this CombinedResult<T1, T2, InnerAutoMLJobTextClassificationJobConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobTextClassificationJobConfigFactory, T1, T2, T3, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3>(this CombinedResult<InnerAutoMLJobTextClassificationJobConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobTextClassificationJobConfigFactory, T2, T3, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3>(this CombinedResult<T1, InnerAutoMLJobTextClassificationJobConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobTextClassificationJobConfigFactory, T3, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutoMLJobTextClassificationJobConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobTextClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutoMLJobTextClassificationJobConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobTextClassificationJobConfigFactory, T1, T2, T3, T4, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<InnerAutoMLJobTextClassificationJobConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobTextClassificationJobConfigFactory, T2, T3, T4, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutoMLJobTextClassificationJobConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobTextClassificationJobConfigFactory, T3, T4, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutoMLJobTextClassificationJobConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobTextClassificationJobConfigFactory, T4, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutoMLJobTextClassificationJobConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAutoMLJobTextClassificationJobConfigFactory, InnerAutoMLJobAutoMLJobCompletionCriteriaFactory> WithCompletionCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutoMLJobTextClassificationJobConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompletionCriteria(combinedResult.T5, subFactoryAction).T2);
}
