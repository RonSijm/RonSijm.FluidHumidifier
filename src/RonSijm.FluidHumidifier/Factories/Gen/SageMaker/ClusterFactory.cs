// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ClusterFactory(string resourceName = null, Action<Humidifier.SageMaker.Cluster> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Cluster>(resourceName)
{

    internal List<InnerClusterClusterInstanceGroupFactory> InstanceGroupsFactories { get; set; } = [];

    internal InnerClusterVpcConfigFactory VpcConfigFactory { get; set; }

    internal InnerClusterOrchestratorFactory OrchestratorFactory { get; set; }

    protected override Humidifier.SageMaker.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.SageMaker.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.SageMaker.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Cluster result)
    {
        base.CreateChildren(result);

        result.InstanceGroups = InstanceGroupsFactories.Any() ? InstanceGroupsFactories.Select(x => x.Build()).ToList() : null;
        result.VpcConfig ??= VpcConfigFactory?.Build();
        result.Orchestrator ??= OrchestratorFactory?.Build();
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
    public static CombinedResult<ClusterFactory, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups(this ClusterFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null)
    {
        var factory = new InnerClusterClusterInstanceGroupFactory(subFactoryAction);
        parentFactory.InstanceGroupsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ClusterFactory, InnerClusterVpcConfigFactory> WithVpcConfig(this ClusterFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerClusterVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<ClusterFactory, InnerClusterOrchestratorFactory> WithOrchestrator(this ClusterFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null)
    {
        parentFactory.OrchestratorFactory = new InnerClusterOrchestratorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OrchestratorFactory);
    }

    public static CombinedResult<ClusterFactory, T1, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterClusterInstanceGroupFactory> WithInstanceGroups<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceGroups(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, InnerClusterVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, InnerClusterOrchestratorFactory> WithOrchestrator<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, WithOrchestrator(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterOrchestratorFactory> WithOrchestrator<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, WithOrchestrator(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterOrchestratorFactory> WithOrchestrator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrchestrator(combinedResult.T5, subFactoryAction));
}
