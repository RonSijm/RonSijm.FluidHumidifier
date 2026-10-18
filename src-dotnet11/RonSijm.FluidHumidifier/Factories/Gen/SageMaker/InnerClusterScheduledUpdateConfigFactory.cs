// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterScheduledUpdateConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.ScheduledUpdateConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ScheduledUpdateConfig>
{

    internal InnerClusterDeploymentConfigFactory DeploymentConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.ScheduledUpdateConfig Create()
    {
        var scheduledUpdateConfigResult = CreateScheduledUpdateConfig();
        factoryAction?.Invoke(scheduledUpdateConfigResult);

        return scheduledUpdateConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ScheduledUpdateConfig CreateScheduledUpdateConfig()
    {
        var scheduledUpdateConfigResult = new Humidifier.SageMaker.ClusterTypes.ScheduledUpdateConfig();

        return scheduledUpdateConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.ScheduledUpdateConfig result)
    {
        base.CreateChildren(result);

        result.DeploymentConfig ??= DeploymentConfigFactory?.Build();
    }

} // End Of Class

public static class InnerClusterScheduledUpdateConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterScheduledUpdateConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig(this InnerClusterScheduledUpdateConfigFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null)
    {
        parentFactory.DeploymentConfigFactory = new InnerClusterDeploymentConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeploymentConfigFactory);
    }

    public static CombinedResult<InnerClusterScheduledUpdateConfigFactory, T1, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1>(this CombinedResult<InnerClusterScheduledUpdateConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterScheduledUpdateConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1>(this CombinedResult<T1, InnerClusterScheduledUpdateConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterScheduledUpdateConfigFactory, T1, T2, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2>(this CombinedResult<InnerClusterScheduledUpdateConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterScheduledUpdateConfigFactory, T2, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2>(this CombinedResult<T1, InnerClusterScheduledUpdateConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterScheduledUpdateConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2>(this CombinedResult<T1, T2, InnerClusterScheduledUpdateConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterScheduledUpdateConfigFactory, T1, T2, T3, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<InnerClusterScheduledUpdateConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterScheduledUpdateConfigFactory, T2, T3, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<T1, InnerClusterScheduledUpdateConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterScheduledUpdateConfigFactory, T3, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterScheduledUpdateConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterScheduledUpdateConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterScheduledUpdateConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterScheduledUpdateConfigFactory, T1, T2, T3, T4, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<InnerClusterScheduledUpdateConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterScheduledUpdateConfigFactory, T2, T3, T4, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterScheduledUpdateConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterScheduledUpdateConfigFactory, T3, T4, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterScheduledUpdateConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterScheduledUpdateConfigFactory, T4, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterScheduledUpdateConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterScheduledUpdateConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterScheduledUpdateConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T5, subFactoryAction).T2);
}
