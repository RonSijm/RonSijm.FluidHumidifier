// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigExplainerConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.ExplainerConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.ExplainerConfig>
{

    internal InnerEndpointConfigClarifyExplainerConfigFactory ClarifyExplainerConfigFactory { get; set; }

    protected override Humidifier.SageMaker.EndpointConfigTypes.ExplainerConfig Create()
    {
        var explainerConfigResult = CreateExplainerConfig();
        factoryAction?.Invoke(explainerConfigResult);

        return explainerConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.ExplainerConfig CreateExplainerConfig()
    {
        var explainerConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.ExplainerConfig();

        return explainerConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.EndpointConfigTypes.ExplainerConfig result)
    {
        base.CreateChildren(result);

        result.ClarifyExplainerConfig ??= ClarifyExplainerConfigFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointConfigExplainerConfigFactoryExtensions
{
    public static CombinedResult<InnerEndpointConfigExplainerConfigFactory, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig(this InnerEndpointConfigExplainerConfigFactory parentFactory, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null)
    {
        parentFactory.ClarifyExplainerConfigFactory = new InnerEndpointConfigClarifyExplainerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClarifyExplainerConfigFactory);
    }

    public static CombinedResult<InnerEndpointConfigExplainerConfigFactory, T1, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1>(this CombinedResult<InnerEndpointConfigExplainerConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigExplainerConfigFactory, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1>(this CombinedResult<T1, InnerEndpointConfigExplainerConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointConfigExplainerConfigFactory, T1, T2, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2>(this CombinedResult<InnerEndpointConfigExplainerConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigExplainerConfigFactory, T2, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2>(this CombinedResult<T1, InnerEndpointConfigExplainerConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointConfigExplainerConfigFactory, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2>(this CombinedResult<T1, T2, InnerEndpointConfigExplainerConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointConfigExplainerConfigFactory, T1, T2, T3, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2, T3>(this CombinedResult<InnerEndpointConfigExplainerConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigExplainerConfigFactory, T2, T3, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2, T3>(this CombinedResult<T1, InnerEndpointConfigExplainerConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointConfigExplainerConfigFactory, T3, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointConfigExplainerConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigExplainerConfigFactory, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointConfigExplainerConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointConfigExplainerConfigFactory, T1, T2, T3, T4, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2, T3, T4>(this CombinedResult<InnerEndpointConfigExplainerConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointConfigExplainerConfigFactory, T2, T3, T4, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointConfigExplainerConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointConfigExplainerConfigFactory, T3, T4, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointConfigExplainerConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigExplainerConfigFactory, T4, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointConfigExplainerConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointConfigExplainerConfigFactory, InnerEndpointConfigClarifyExplainerConfigFactory> WithClarifyExplainerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointConfigExplainerConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyExplainerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClarifyExplainerConfig(combinedResult.T5, subFactoryAction));
}
