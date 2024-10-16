// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigAsyncInferenceOutputConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceOutputConfig>
{

    internal InnerEndpointConfigAsyncInferenceNotificationConfigFactory NotificationConfigFactory { get; set; }

    protected override Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceOutputConfig Create()
    {
        var asyncInferenceOutputConfigResult = CreateAsyncInferenceOutputConfig();
        factoryAction?.Invoke(asyncInferenceOutputConfigResult);

        return asyncInferenceOutputConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceOutputConfig CreateAsyncInferenceOutputConfig()
    {
        var asyncInferenceOutputConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceOutputConfig();

        return asyncInferenceOutputConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceOutputConfig result)
    {
        base.CreateChildren(result);

        result.NotificationConfig ??= NotificationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointConfigAsyncInferenceOutputConfigFactoryExtensions
{
    public static CombinedResult<InnerEndpointConfigAsyncInferenceOutputConfigFactory, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig(this InnerEndpointConfigAsyncInferenceOutputConfigFactory parentFactory, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null)
    {
        parentFactory.NotificationConfigFactory = new InnerEndpointConfigAsyncInferenceNotificationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NotificationConfigFactory);
    }

    public static CombinedResult<InnerEndpointConfigAsyncInferenceOutputConfigFactory, T1, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1>(this CombinedResult<InnerEndpointConfigAsyncInferenceOutputConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigAsyncInferenceOutputConfigFactory, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1>(this CombinedResult<T1, InnerEndpointConfigAsyncInferenceOutputConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointConfigAsyncInferenceOutputConfigFactory, T1, T2, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2>(this CombinedResult<InnerEndpointConfigAsyncInferenceOutputConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T2, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2>(this CombinedResult<T1, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointConfigAsyncInferenceOutputConfigFactory, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2>(this CombinedResult<T1, T2, InnerEndpointConfigAsyncInferenceOutputConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointConfigAsyncInferenceOutputConfigFactory, T1, T2, T3, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2, T3>(this CombinedResult<InnerEndpointConfigAsyncInferenceOutputConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T2, T3, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2, T3>(this CombinedResult<T1, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T3, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigAsyncInferenceOutputConfigFactory, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointConfigAsyncInferenceOutputConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointConfigAsyncInferenceOutputConfigFactory, T1, T2, T3, T4, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2, T3, T4>(this CombinedResult<InnerEndpointConfigAsyncInferenceOutputConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T2, T3, T4, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T3, T4, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T4, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointConfigAsyncInferenceOutputConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointConfigAsyncInferenceOutputConfigFactory, InnerEndpointConfigAsyncInferenceNotificationConfigFactory> WithNotificationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointConfigAsyncInferenceOutputConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfig(combinedResult.T5, subFactoryAction));
}
