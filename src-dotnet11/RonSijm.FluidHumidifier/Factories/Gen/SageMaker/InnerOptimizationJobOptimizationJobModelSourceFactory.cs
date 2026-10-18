// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerOptimizationJobOptimizationJobModelSourceFactory(Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSource>
{

    internal InnerOptimizationJobOptimizationJobModelSourceS3Factory S3Factory { get; set; }

    protected override Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSource Create()
    {
        var optimizationJobModelSourceResult = CreateOptimizationJobModelSource();
        factoryAction?.Invoke(optimizationJobModelSourceResult);

        return optimizationJobModelSourceResult;
    }

    private Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSource CreateOptimizationJobModelSource()
    {
        var optimizationJobModelSourceResult = new Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSource();

        return optimizationJobModelSourceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSource result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerOptimizationJobOptimizationJobModelSourceFactoryExtensions
{
    public static CombinedResult<InnerOptimizationJobOptimizationJobModelSourceFactory, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3(this InnerOptimizationJobOptimizationJobModelSourceFactory parentFactory, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerOptimizationJobOptimizationJobModelSourceS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerOptimizationJobOptimizationJobModelSourceFactory, T1, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1>(this CombinedResult<InnerOptimizationJobOptimizationJobModelSourceFactory, T1> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOptimizationJobOptimizationJobModelSourceFactory, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1>(this CombinedResult<T1, InnerOptimizationJobOptimizationJobModelSourceFactory> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOptimizationJobOptimizationJobModelSourceFactory, T1, T2, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2>(this CombinedResult<InnerOptimizationJobOptimizationJobModelSourceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOptimizationJobOptimizationJobModelSourceFactory, T2, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2>(this CombinedResult<T1, InnerOptimizationJobOptimizationJobModelSourceFactory, T2> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOptimizationJobOptimizationJobModelSourceFactory, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerOptimizationJobOptimizationJobModelSourceFactory> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOptimizationJobOptimizationJobModelSourceFactory, T1, T2, T3, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<InnerOptimizationJobOptimizationJobModelSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOptimizationJobOptimizationJobModelSourceFactory, T2, T3, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerOptimizationJobOptimizationJobModelSourceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOptimizationJobOptimizationJobModelSourceFactory, T3, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerOptimizationJobOptimizationJobModelSourceFactory, T3> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOptimizationJobOptimizationJobModelSourceFactory, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOptimizationJobOptimizationJobModelSourceFactory> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOptimizationJobOptimizationJobModelSourceFactory, T1, T2, T3, T4, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerOptimizationJobOptimizationJobModelSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOptimizationJobOptimizationJobModelSourceFactory, T2, T3, T4, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerOptimizationJobOptimizationJobModelSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOptimizationJobOptimizationJobModelSourceFactory, T3, T4, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOptimizationJobOptimizationJobModelSourceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOptimizationJobOptimizationJobModelSourceFactory, T4, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOptimizationJobOptimizationJobModelSourceFactory, T4> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOptimizationJobOptimizationJobModelSourceFactory, InnerOptimizationJobOptimizationJobModelSourceS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOptimizationJobOptimizationJobModelSourceFactory> combinedResult, Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
}
