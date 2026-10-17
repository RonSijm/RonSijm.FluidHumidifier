// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterDeploymentConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.DeploymentConfig>
{

    internal InnerClusterRollingUpdatePolicyFactory RollingUpdatePolicyFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.DeploymentConfig Create()
    {
        var deploymentConfigResult = CreateDeploymentConfig();
        factoryAction?.Invoke(deploymentConfigResult);

        return deploymentConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.DeploymentConfig CreateDeploymentConfig()
    {
        var deploymentConfigResult = new Humidifier.SageMaker.ClusterTypes.DeploymentConfig();

        return deploymentConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.DeploymentConfig result)
    {
        base.CreateChildren(result);

        result.RollingUpdatePolicy ??= RollingUpdatePolicyFactory?.Build();
    }

} // End Of Class

public static class InnerClusterDeploymentConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterDeploymentConfigFactory, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy(this InnerClusterDeploymentConfigFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null)
    {
        parentFactory.RollingUpdatePolicyFactory = new InnerClusterRollingUpdatePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RollingUpdatePolicyFactory);
    }

    public static CombinedResult<InnerClusterDeploymentConfigFactory, T1, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1>(this CombinedResult<InnerClusterDeploymentConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterDeploymentConfigFactory, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1>(this CombinedResult<T1, InnerClusterDeploymentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterDeploymentConfigFactory, T1, T2, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2>(this CombinedResult<InnerClusterDeploymentConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterDeploymentConfigFactory, T2, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2>(this CombinedResult<T1, InnerClusterDeploymentConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterDeploymentConfigFactory, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2>(this CombinedResult<T1, T2, InnerClusterDeploymentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterDeploymentConfigFactory, T1, T2, T3, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2, T3>(this CombinedResult<InnerClusterDeploymentConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterDeploymentConfigFactory, T2, T3, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2, T3>(this CombinedResult<T1, InnerClusterDeploymentConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterDeploymentConfigFactory, T3, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterDeploymentConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterDeploymentConfigFactory, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterDeploymentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterDeploymentConfigFactory, T1, T2, T3, T4, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2, T3, T4>(this CombinedResult<InnerClusterDeploymentConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterDeploymentConfigFactory, T2, T3, T4, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterDeploymentConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterDeploymentConfigFactory, T3, T4, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterDeploymentConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterDeploymentConfigFactory, T4, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterDeploymentConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterDeploymentConfigFactory, InnerClusterRollingUpdatePolicyFactory> WithRollingUpdatePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterDeploymentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollingUpdatePolicy(combinedResult.T5, subFactoryAction).T2);
}
