// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceDeploymentCircuitBreakerFactory(Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker>
{

    internal InnerServiceThresholdConfigurationFactory ThresholdConfigurationFactory { get; set; }

    protected override Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker Create()
    {
        var deploymentCircuitBreakerResult = CreateDeploymentCircuitBreaker();
        factoryAction?.Invoke(deploymentCircuitBreakerResult);

        return deploymentCircuitBreakerResult;
    }

    private Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker CreateDeploymentCircuitBreaker()
    {
        var deploymentCircuitBreakerResult = new Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker();

        return deploymentCircuitBreakerResult;
    }
    public override void CreateChildren(Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker result)
    {
        base.CreateChildren(result);

        result.ThresholdConfiguration ??= ThresholdConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceDeploymentCircuitBreakerFactoryExtensions
{
    public static CombinedResult<InnerServiceDeploymentCircuitBreakerFactory, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration(this InnerServiceDeploymentCircuitBreakerFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null)
    {
        parentFactory.ThresholdConfigurationFactory = new InnerServiceThresholdConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ThresholdConfigurationFactory);
    }

    public static CombinedResult<InnerServiceDeploymentCircuitBreakerFactory, T1, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1>(this CombinedResult<InnerServiceDeploymentCircuitBreakerFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDeploymentCircuitBreakerFactory, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1>(this CombinedResult<T1, InnerServiceDeploymentCircuitBreakerFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceDeploymentCircuitBreakerFactory, T1, T2, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2>(this CombinedResult<InnerServiceDeploymentCircuitBreakerFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDeploymentCircuitBreakerFactory, T2, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceDeploymentCircuitBreakerFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceDeploymentCircuitBreakerFactory, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceDeploymentCircuitBreakerFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceDeploymentCircuitBreakerFactory, T1, T2, T3, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceDeploymentCircuitBreakerFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDeploymentCircuitBreakerFactory, T2, T3, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceDeploymentCircuitBreakerFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceDeploymentCircuitBreakerFactory, T3, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceDeploymentCircuitBreakerFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceDeploymentCircuitBreakerFactory, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceDeploymentCircuitBreakerFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceDeploymentCircuitBreakerFactory, T1, T2, T3, T4, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceDeploymentCircuitBreakerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDeploymentCircuitBreakerFactory, T2, T3, T4, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceDeploymentCircuitBreakerFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceDeploymentCircuitBreakerFactory, T3, T4, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceDeploymentCircuitBreakerFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceDeploymentCircuitBreakerFactory, T4, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceDeploymentCircuitBreakerFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceDeploymentCircuitBreakerFactory, InnerServiceThresholdConfigurationFactory> WithThresholdConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceDeploymentCircuitBreakerFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.ThresholdConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThresholdConfiguration(combinedResult.T5, subFactoryAction).T2);
}
