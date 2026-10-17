// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIRecommendationJobAIModelSourceFactory(Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSource>
{

    internal InnerAIRecommendationJobAIModelSourceS3Factory S3Factory { get; set; }

    protected override Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSource Create()
    {
        var aIModelSourceResult = CreateAIModelSource();
        factoryAction?.Invoke(aIModelSourceResult);

        return aIModelSourceResult;
    }

    private Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSource CreateAIModelSource()
    {
        var aIModelSourceResult = new Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSource();

        return aIModelSourceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSource result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerAIRecommendationJobAIModelSourceFactoryExtensions
{
    public static CombinedResult<InnerAIRecommendationJobAIModelSourceFactory, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3(this InnerAIRecommendationJobAIModelSourceFactory parentFactory, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerAIRecommendationJobAIModelSourceS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerAIRecommendationJobAIModelSourceFactory, T1, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1>(this CombinedResult<InnerAIRecommendationJobAIModelSourceFactory, T1> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIRecommendationJobAIModelSourceFactory, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1>(this CombinedResult<T1, InnerAIRecommendationJobAIModelSourceFactory> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAIRecommendationJobAIModelSourceFactory, T1, T2, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2>(this CombinedResult<InnerAIRecommendationJobAIModelSourceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIRecommendationJobAIModelSourceFactory, T2, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2>(this CombinedResult<T1, InnerAIRecommendationJobAIModelSourceFactory, T2> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIRecommendationJobAIModelSourceFactory, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerAIRecommendationJobAIModelSourceFactory> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAIRecommendationJobAIModelSourceFactory, T1, T2, T3, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<InnerAIRecommendationJobAIModelSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIRecommendationJobAIModelSourceFactory, T2, T3, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerAIRecommendationJobAIModelSourceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIRecommendationJobAIModelSourceFactory, T3, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerAIRecommendationJobAIModelSourceFactory, T3> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIRecommendationJobAIModelSourceFactory, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAIRecommendationJobAIModelSourceFactory> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAIRecommendationJobAIModelSourceFactory, T1, T2, T3, T4, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerAIRecommendationJobAIModelSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIRecommendationJobAIModelSourceFactory, T2, T3, T4, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerAIRecommendationJobAIModelSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIRecommendationJobAIModelSourceFactory, T3, T4, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAIRecommendationJobAIModelSourceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIRecommendationJobAIModelSourceFactory, T4, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAIRecommendationJobAIModelSourceFactory, T4> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAIRecommendationJobAIModelSourceFactory, InnerAIRecommendationJobAIModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAIRecommendationJobAIModelSourceFactory> combinedResult, Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
}
