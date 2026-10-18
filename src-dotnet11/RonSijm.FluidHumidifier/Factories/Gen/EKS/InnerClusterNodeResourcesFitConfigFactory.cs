// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterNodeResourcesFitConfigFactory(Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig>
{

    internal InnerClusterScoringStrategyFactory ScoringStrategyFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig Create()
    {
        var nodeResourcesFitConfigResult = CreateNodeResourcesFitConfig();
        factoryAction?.Invoke(nodeResourcesFitConfigResult);

        return nodeResourcesFitConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig CreateNodeResourcesFitConfig()
    {
        var nodeResourcesFitConfigResult = new Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig();

        return nodeResourcesFitConfigResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig result)
    {
        base.CreateChildren(result);

        result.ScoringStrategy ??= ScoringStrategyFactory?.Build();
    }

} // End Of Class

public static class InnerClusterNodeResourcesFitConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterNodeResourcesFitConfigFactory, InnerClusterScoringStrategyFactory> WithScoringStrategy(this InnerClusterNodeResourcesFitConfigFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null)
    {
        parentFactory.ScoringStrategyFactory = new InnerClusterScoringStrategyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScoringStrategyFactory);
    }

    public static CombinedResult<InnerClusterNodeResourcesFitConfigFactory, T1, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1>(this CombinedResult<InnerClusterNodeResourcesFitConfigFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScoringStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterNodeResourcesFitConfigFactory, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1>(this CombinedResult<T1, InnerClusterNodeResourcesFitConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithScoringStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterNodeResourcesFitConfigFactory, T1, T2, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2>(this CombinedResult<InnerClusterNodeResourcesFitConfigFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterNodeResourcesFitConfigFactory, T2, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2>(this CombinedResult<T1, InnerClusterNodeResourcesFitConfigFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterNodeResourcesFitConfigFactory, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2>(this CombinedResult<T1, T2, InnerClusterNodeResourcesFitConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterNodeResourcesFitConfigFactory, T1, T2, T3, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2, T3>(this CombinedResult<InnerClusterNodeResourcesFitConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterNodeResourcesFitConfigFactory, T2, T3, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2, T3>(this CombinedResult<T1, InnerClusterNodeResourcesFitConfigFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterNodeResourcesFitConfigFactory, T3, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterNodeResourcesFitConfigFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterNodeResourcesFitConfigFactory, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterNodeResourcesFitConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterNodeResourcesFitConfigFactory, T1, T2, T3, T4, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<InnerClusterNodeResourcesFitConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterNodeResourcesFitConfigFactory, T2, T3, T4, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterNodeResourcesFitConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterNodeResourcesFitConfigFactory, T3, T4, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterNodeResourcesFitConfigFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterNodeResourcesFitConfigFactory, T4, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterNodeResourcesFitConfigFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterNodeResourcesFitConfigFactory, InnerClusterScoringStrategyFactory> WithScoringStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterNodeResourcesFitConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ScoringStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScoringStrategy(combinedResult.T5, subFactoryAction).T2);
}
