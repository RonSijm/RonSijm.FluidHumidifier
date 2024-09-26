// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DAX;

public class ClusterFactory(string resourceName = null, Action<Humidifier.DAX.Cluster> factoryAction = null) : ResourceFactory<Humidifier.DAX.Cluster>(resourceName)
{

    internal InnerClusterSSESpecificationFactory SSESpecificationFactory { get; set; }

    protected override Humidifier.DAX.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.DAX.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.DAX.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }
    public override void CreateChildren(Humidifier.DAX.Cluster result)
    {
        base.CreateChildren(result);

        result.SSESpecification ??= SSESpecificationFactory?.Build();
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
    public static CombinedResult<ClusterFactory, InnerClusterSSESpecificationFactory> WithSSESpecification(this ClusterFactory parentFactory, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null)
    {
        parentFactory.SSESpecificationFactory = new InnerClusterSSESpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SSESpecificationFactory);
    }

    public static CombinedResult<ClusterFactory, T1, InnerClusterSSESpecificationFactory> WithSSESpecification<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithSSESpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterSSESpecificationFactory> WithSSESpecification<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithSSESpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterSSESpecificationFactory> WithSSESpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.DAX.ClusterTypes.SSESpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSESpecification(combinedResult.T5, subFactoryAction));
}
