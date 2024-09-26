// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigDataCaptureConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.DataCaptureConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.DataCaptureConfig>
{

    internal InnerEndpointConfigCaptureContentTypeHeaderFactory CaptureContentTypeHeaderFactory { get; set; }

    protected override Humidifier.SageMaker.EndpointConfigTypes.DataCaptureConfig Create()
    {
        var dataCaptureConfigResult = CreateDataCaptureConfig();
        factoryAction?.Invoke(dataCaptureConfigResult);

        return dataCaptureConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.DataCaptureConfig CreateDataCaptureConfig()
    {
        var dataCaptureConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.DataCaptureConfig();

        return dataCaptureConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.EndpointConfigTypes.DataCaptureConfig result)
    {
        base.CreateChildren(result);

        result.CaptureContentTypeHeader ??= CaptureContentTypeHeaderFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointConfigDataCaptureConfigFactoryExtensions
{
    public static CombinedResult<InnerEndpointConfigDataCaptureConfigFactory, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader(this InnerEndpointConfigDataCaptureConfigFactory parentFactory, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null)
    {
        parentFactory.CaptureContentTypeHeaderFactory = new InnerEndpointConfigCaptureContentTypeHeaderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CaptureContentTypeHeaderFactory);
    }

    public static CombinedResult<InnerEndpointConfigDataCaptureConfigFactory, T1, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1>(this CombinedResult<InnerEndpointConfigDataCaptureConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigDataCaptureConfigFactory, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1>(this CombinedResult<T1, InnerEndpointConfigDataCaptureConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointConfigDataCaptureConfigFactory, T1, T2, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2>(this CombinedResult<InnerEndpointConfigDataCaptureConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigDataCaptureConfigFactory, T2, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2>(this CombinedResult<T1, InnerEndpointConfigDataCaptureConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointConfigDataCaptureConfigFactory, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2>(this CombinedResult<T1, T2, InnerEndpointConfigDataCaptureConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointConfigDataCaptureConfigFactory, T1, T2, T3, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2, T3>(this CombinedResult<InnerEndpointConfigDataCaptureConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigDataCaptureConfigFactory, T2, T3, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2, T3>(this CombinedResult<T1, InnerEndpointConfigDataCaptureConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointConfigDataCaptureConfigFactory, T3, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointConfigDataCaptureConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigDataCaptureConfigFactory, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointConfigDataCaptureConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointConfigDataCaptureConfigFactory, T1, T2, T3, T4, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2, T3, T4>(this CombinedResult<InnerEndpointConfigDataCaptureConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigDataCaptureConfigFactory, T2, T3, T4, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointConfigDataCaptureConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointConfigDataCaptureConfigFactory, T3, T4, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointConfigDataCaptureConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigDataCaptureConfigFactory, T4, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointConfigDataCaptureConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointConfigDataCaptureConfigFactory, InnerEndpointConfigCaptureContentTypeHeaderFactory> WithCaptureContentTypeHeader<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointConfigDataCaptureConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureContentTypeHeader(combinedResult.T5, subFactoryAction));
}
