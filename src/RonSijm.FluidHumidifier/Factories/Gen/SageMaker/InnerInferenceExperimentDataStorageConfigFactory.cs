// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceExperimentDataStorageConfigFactory(Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig>
{

    internal InnerInferenceExperimentCaptureContentTypeHeaderFactory ContentTypeFactory { get; set; }

    protected override Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig Create()
    {
        var dataStorageConfigResult = CreateDataStorageConfig();
        factoryAction?.Invoke(dataStorageConfigResult);

        return dataStorageConfigResult;
    }

    private Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig CreateDataStorageConfig()
    {
        var dataStorageConfigResult = new Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig();

        return dataStorageConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig result)
    {
        base.CreateChildren(result);

        result.ContentType ??= ContentTypeFactory?.Build();
    }

} // End Of Class

public static class InnerInferenceExperimentDataStorageConfigFactoryExtensions
{
    public static CombinedResult<InnerInferenceExperimentDataStorageConfigFactory, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType(this InnerInferenceExperimentDataStorageConfigFactory parentFactory, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null)
    {
        parentFactory.ContentTypeFactory = new InnerInferenceExperimentCaptureContentTypeHeaderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentTypeFactory);
    }

    public static CombinedResult<InnerInferenceExperimentDataStorageConfigFactory, T1, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1>(this CombinedResult<InnerInferenceExperimentDataStorageConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, WithContentType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentDataStorageConfigFactory, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1>(this CombinedResult<T1, InnerInferenceExperimentDataStorageConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, WithContentType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInferenceExperimentDataStorageConfigFactory, T1, T2, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2>(this CombinedResult<InnerInferenceExperimentDataStorageConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentDataStorageConfigFactory, T2, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2>(this CombinedResult<T1, InnerInferenceExperimentDataStorageConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceExperimentDataStorageConfigFactory, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2>(this CombinedResult<T1, T2, InnerInferenceExperimentDataStorageConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInferenceExperimentDataStorageConfigFactory, T1, T2, T3, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2, T3>(this CombinedResult<InnerInferenceExperimentDataStorageConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentDataStorageConfigFactory, T2, T3, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2, T3>(this CombinedResult<T1, InnerInferenceExperimentDataStorageConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceExperimentDataStorageConfigFactory, T3, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2, T3>(this CombinedResult<T1, T2, InnerInferenceExperimentDataStorageConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceExperimentDataStorageConfigFactory, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInferenceExperimentDataStorageConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInferenceExperimentDataStorageConfigFactory, T1, T2, T3, T4, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2, T3, T4>(this CombinedResult<InnerInferenceExperimentDataStorageConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentDataStorageConfigFactory, T2, T3, T4, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2, T3, T4>(this CombinedResult<T1, InnerInferenceExperimentDataStorageConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceExperimentDataStorageConfigFactory, T3, T4, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInferenceExperimentDataStorageConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceExperimentDataStorageConfigFactory, T4, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInferenceExperimentDataStorageConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInferenceExperimentDataStorageConfigFactory, InnerInferenceExperimentCaptureContentTypeHeaderFactory> WithContentType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInferenceExperimentDataStorageConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentType(combinedResult.T5, subFactoryAction));
}
