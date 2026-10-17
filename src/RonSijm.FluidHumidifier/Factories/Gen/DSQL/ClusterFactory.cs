// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DSQL;

public class ClusterFactory(string resourceName = null, Action<Humidifier.DSQL.Cluster> factoryAction = null) : ResourceFactory<Humidifier.DSQL.Cluster>(resourceName)
{

    internal InnerClusterMultiRegionPropertiesFactory MultiRegionPropertiesFactory { get; set; }

    protected override Humidifier.DSQL.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.DSQL.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.DSQL.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }
    public override void CreateChildren(Humidifier.DSQL.Cluster result)
    {
        base.CreateChildren(result);

        result.MultiRegionProperties ??= MultiRegionPropertiesFactory?.Build();
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
    public static CombinedResult<ClusterFactory, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties(this ClusterFactory parentFactory, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null)
    {
        parentFactory.MultiRegionPropertiesFactory = new InnerClusterMultiRegionPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MultiRegionPropertiesFactory);
    }

    public static CombinedResult<ClusterFactory, T1, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterMultiRegionPropertiesFactory> WithMultiRegionProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.DSQL.ClusterTypes.MultiRegionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMultiRegionProperties(combinedResult.T5, subFactoryAction).T2);
}
