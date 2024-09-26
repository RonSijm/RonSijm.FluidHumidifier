// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class ClusterFactory(string resourceName = null, Action<Humidifier.MemoryDB.Cluster> factoryAction = null) : ResourceFactory<Humidifier.MemoryDB.Cluster>(resourceName)
{

    internal InnerClusterEndpointFactory ClusterEndpointFactory { get; set; }

    protected override Humidifier.MemoryDB.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.MemoryDB.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.MemoryDB.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }
    public override void CreateChildren(Humidifier.MemoryDB.Cluster result)
    {
        base.CreateChildren(result);

        result.ClusterEndpoint ??= ClusterEndpointFactory?.Build();
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
    public static CombinedResult<ClusterFactory, InnerClusterEndpointFactory> WithClusterEndpoint(this ClusterFactory parentFactory, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null)
    {
        parentFactory.ClusterEndpointFactory = new InnerClusterEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClusterEndpointFactory);
    }

    public static CombinedResult<ClusterFactory, T1, InnerClusterEndpointFactory> WithClusterEndpoint<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterEndpointFactory> WithClusterEndpoint<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterEndpointFactory> WithClusterEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterEndpoint(combinedResult.T5, subFactoryAction));
}
