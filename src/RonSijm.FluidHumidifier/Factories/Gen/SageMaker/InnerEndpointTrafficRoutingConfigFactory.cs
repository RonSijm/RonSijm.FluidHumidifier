// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointTrafficRoutingConfigFactory(Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig>
{

    internal InnerEndpointCapacitySizeFactory LinearStepSizeFactory { get; set; }

    internal InnerEndpointCapacitySizeFactory CanarySizeFactory { get; set; }

    protected override Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig Create()
    {
        var trafficRoutingConfigResult = CreateTrafficRoutingConfig();
        factoryAction?.Invoke(trafficRoutingConfigResult);

        return trafficRoutingConfigResult;
    }

    private Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig CreateTrafficRoutingConfig()
    {
        var trafficRoutingConfigResult = new Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig();

        return trafficRoutingConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig result)
    {
        base.CreateChildren(result);

        result.LinearStepSize ??= LinearStepSizeFactory?.Build();
        result.CanarySize ??= CanarySizeFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointTrafficRoutingConfigFactoryExtensions
{
    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithLinearStepSize(this InnerEndpointTrafficRoutingConfigFactory parentFactory, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null)
    {
        parentFactory.LinearStepSizeFactory = new InnerEndpointCapacitySizeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinearStepSizeFactory);
    }

    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithCanarySize(this InnerEndpointTrafficRoutingConfigFactory parentFactory, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null)
    {
        parentFactory.CanarySizeFactory = new InnerEndpointCapacitySizeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanarySizeFactory);
    }

    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1>(this CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinearStepSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1>(this CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinearStepSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2>(this CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2>(this CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2>(this CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, T3, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2, T3>(this CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, T3, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2, T3>(this CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, T3, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointTrafficRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, T3, T4, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2, T3, T4>(this CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, T3, T4, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, T3, T4, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointTrafficRoutingConfigFactory, T4, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointTrafficRoutingConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithLinearStepSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointTrafficRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinearStepSize(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, InnerEndpointCapacitySizeFactory> WithCanarySize<T1>(this CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanarySize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithCanarySize<T1>(this CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanarySize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2>(this CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2>(this CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2>(this CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, T3, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2, T3>(this CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, T3, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2, T3>(this CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, T3, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointTrafficRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, T3, T4, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2, T3, T4>(this CombinedResult<InnerEndpointTrafficRoutingConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, T3, T4, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointTrafficRoutingConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, T3, T4, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointTrafficRoutingConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointTrafficRoutingConfigFactory, T4, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointTrafficRoutingConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointTrafficRoutingConfigFactory, InnerEndpointCapacitySizeFactory> WithCanarySize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointTrafficRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.CapacitySize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanarySize(combinedResult.T5, subFactoryAction));
}
