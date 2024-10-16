// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointBlueGreenUpdatePolicyFactory(Action<Humidifier.SageMaker.EndpointTypes.BlueGreenUpdatePolicy> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointTypes.BlueGreenUpdatePolicy>
{

    internal InnerEndpointTrafficRoutingConfigFactory TrafficRoutingConfigurationFactory { get; set; }

    protected override Humidifier.SageMaker.EndpointTypes.BlueGreenUpdatePolicy Create()
    {
        var blueGreenUpdatePolicyResult = CreateBlueGreenUpdatePolicy();
        factoryAction?.Invoke(blueGreenUpdatePolicyResult);

        return blueGreenUpdatePolicyResult;
    }

    private Humidifier.SageMaker.EndpointTypes.BlueGreenUpdatePolicy CreateBlueGreenUpdatePolicy()
    {
        var blueGreenUpdatePolicyResult = new Humidifier.SageMaker.EndpointTypes.BlueGreenUpdatePolicy();

        return blueGreenUpdatePolicyResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.EndpointTypes.BlueGreenUpdatePolicy result)
    {
        base.CreateChildren(result);

        result.TrafficRoutingConfiguration ??= TrafficRoutingConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointBlueGreenUpdatePolicyFactoryExtensions
{
    public static CombinedResult<InnerEndpointBlueGreenUpdatePolicyFactory, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration(this InnerEndpointBlueGreenUpdatePolicyFactory parentFactory, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null)
    {
        parentFactory.TrafficRoutingConfigurationFactory = new InnerEndpointTrafficRoutingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TrafficRoutingConfigurationFactory);
    }

    public static CombinedResult<InnerEndpointBlueGreenUpdatePolicyFactory, T1, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1>(this CombinedResult<InnerEndpointBlueGreenUpdatePolicyFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointBlueGreenUpdatePolicyFactory, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1>(this CombinedResult<T1, InnerEndpointBlueGreenUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointBlueGreenUpdatePolicyFactory, T1, T2, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2>(this CombinedResult<InnerEndpointBlueGreenUpdatePolicyFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointBlueGreenUpdatePolicyFactory, T2, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2>(this CombinedResult<T1, InnerEndpointBlueGreenUpdatePolicyFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointBlueGreenUpdatePolicyFactory, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerEndpointBlueGreenUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointBlueGreenUpdatePolicyFactory, T1, T2, T3, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2, T3>(this CombinedResult<InnerEndpointBlueGreenUpdatePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointBlueGreenUpdatePolicyFactory, T2, T3, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerEndpointBlueGreenUpdatePolicyFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointBlueGreenUpdatePolicyFactory, T3, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointBlueGreenUpdatePolicyFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointBlueGreenUpdatePolicyFactory, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointBlueGreenUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointBlueGreenUpdatePolicyFactory, T1, T2, T3, T4, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerEndpointBlueGreenUpdatePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointBlueGreenUpdatePolicyFactory, T2, T3, T4, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointBlueGreenUpdatePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointBlueGreenUpdatePolicyFactory, T3, T4, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointBlueGreenUpdatePolicyFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointBlueGreenUpdatePolicyFactory, T4, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointBlueGreenUpdatePolicyFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointBlueGreenUpdatePolicyFactory, InnerEndpointTrafficRoutingConfigFactory> WithTrafficRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointBlueGreenUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrafficRoutingConfiguration(combinedResult.T5, subFactoryAction));
}
