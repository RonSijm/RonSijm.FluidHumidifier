// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterAutoPatchConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.AutoPatchConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.AutoPatchConfig>
{

    internal InnerClusterPatchScheduleFactory PatchScheduleFactory { get; set; }

    internal InnerClusterDeploymentConfigFactory DeploymentConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.AutoPatchConfig Create()
    {
        var autoPatchConfigResult = CreateAutoPatchConfig();
        factoryAction?.Invoke(autoPatchConfigResult);

        return autoPatchConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.AutoPatchConfig CreateAutoPatchConfig()
    {
        var autoPatchConfigResult = new Humidifier.SageMaker.ClusterTypes.AutoPatchConfig();

        return autoPatchConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.AutoPatchConfig result)
    {
        base.CreateChildren(result);

        result.PatchSchedule ??= PatchScheduleFactory?.Build();
        result.DeploymentConfig ??= DeploymentConfigFactory?.Build();
    }

} // End Of Class

public static class InnerClusterAutoPatchConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterAutoPatchConfigFactory, InnerClusterPatchScheduleFactory> WithPatchSchedule(this InnerClusterAutoPatchConfigFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null)
    {
        parentFactory.PatchScheduleFactory = new InnerClusterPatchScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PatchScheduleFactory);
    }

    public static CombinedResult<InnerClusterAutoPatchConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig(this InnerClusterAutoPatchConfigFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null)
    {
        parentFactory.DeploymentConfigFactory = new InnerClusterDeploymentConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeploymentConfigFactory);
    }

    public static CombinedResult<InnerClusterAutoPatchConfigFactory, T1, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1>(this CombinedResult<InnerClusterAutoPatchConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithPatchSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAutoPatchConfigFactory, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1>(this CombinedResult<T1, InnerClusterAutoPatchConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithPatchSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2>(this CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2>(this CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2>(this CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, T3, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2, T3>(this CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, T3, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2, T3>(this CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, T3, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAutoPatchConfigFactory, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterAutoPatchConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, T3, T4, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2, T3, T4>(this CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, T3, T4, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, T3, T4, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAutoPatchConfigFactory, T4, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterAutoPatchConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterAutoPatchConfigFactory, InnerClusterPatchScheduleFactory> WithPatchSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterAutoPatchConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatchSchedule(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAutoPatchConfigFactory, T1, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1>(this CombinedResult<InnerClusterAutoPatchConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAutoPatchConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1>(this CombinedResult<T1, InnerClusterAutoPatchConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2>(this CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2>(this CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2>(this CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, T3, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, T3, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, T3, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAutoPatchConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterAutoPatchConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, T3, T4, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<InnerClusterAutoPatchConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, T3, T4, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterAutoPatchConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, T3, T4, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterAutoPatchConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAutoPatchConfigFactory, T4, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterAutoPatchConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterAutoPatchConfigFactory, InnerClusterDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterAutoPatchConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T5, subFactoryAction).T2);
}
