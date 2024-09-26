// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceDeploymentConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.DeploymentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.DeploymentConfiguration>
{

    internal InnerServiceDeploymentAlarmsFactory AlarmsFactory { get; set; }

    internal InnerServiceDeploymentCircuitBreakerFactory DeploymentCircuitBreakerFactory { get; set; }

    protected override Humidifier.ECS.ServiceTypes.DeploymentConfiguration Create()
    {
        var deploymentConfigurationResult = CreateDeploymentConfiguration();
        factoryAction?.Invoke(deploymentConfigurationResult);

        return deploymentConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.DeploymentConfiguration CreateDeploymentConfiguration()
    {
        var deploymentConfigurationResult = new Humidifier.ECS.ServiceTypes.DeploymentConfiguration();

        return deploymentConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.ServiceTypes.DeploymentConfiguration result)
    {
        base.CreateChildren(result);

        result.Alarms ??= AlarmsFactory?.Build();
        result.DeploymentCircuitBreaker ??= DeploymentCircuitBreakerFactory?.Build();
    }

} // End Of Class

public static class InnerServiceDeploymentConfigurationFactoryExtensions
{
    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentAlarmsFactory> WithAlarms(this InnerServiceDeploymentConfigurationFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null)
    {
        parentFactory.AlarmsFactory = new InnerServiceDeploymentAlarmsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmsFactory);
    }

    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker(this InnerServiceDeploymentConfigurationFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null)
    {
        parentFactory.DeploymentCircuitBreakerFactory = new InnerServiceDeploymentCircuitBreakerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeploymentCircuitBreakerFactory);
    }

    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1>(this CombinedResult<InnerServiceDeploymentConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1>(this CombinedResult<T1, InnerServiceDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2>(this CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2>(this CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2>(this CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, T3, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2, T3>(this CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, T3, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2, T3>(this CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, T3, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, T3, T4, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, T3, T4, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, T3, T4, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceDeploymentConfigurationFactory, T4, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceDeploymentConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1>(this CombinedResult<InnerServiceDeploymentConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1>(this CombinedResult<T1, InnerServiceDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2>(this CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2>(this CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2>(this CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, T3, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2, T3>(this CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, T3, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2, T3>(this CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, T3, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, T3, T4, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<InnerServiceDeploymentConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, T3, T4, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceDeploymentConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, T3, T4, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceDeploymentConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceDeploymentConfigurationFactory, T4, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceDeploymentConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceDeploymentConfigurationFactory, InnerServiceDeploymentCircuitBreakerFactory> WithDeploymentCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCircuitBreaker(combinedResult.T5, subFactoryAction));
}
