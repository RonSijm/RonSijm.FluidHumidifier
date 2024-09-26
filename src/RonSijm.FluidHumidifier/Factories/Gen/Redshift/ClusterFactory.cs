// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class ClusterFactory(string resourceName = null, Action<Humidifier.Redshift.Cluster> factoryAction = null) : ResourceFactory<Humidifier.Redshift.Cluster>(resourceName)
{

    internal InnerClusterEndpointFactory EndpointFactory { get; set; }

    internal InnerClusterLoggingPropertiesFactory LoggingPropertiesFactory { get; set; }

    protected override Humidifier.Redshift.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.Redshift.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.Redshift.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }
    public override void CreateChildren(Humidifier.Redshift.Cluster result)
    {
        base.CreateChildren(result);

        result.Endpoint ??= EndpointFactory?.Build();
        result.LoggingProperties ??= LoggingPropertiesFactory?.Build();
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
    public static CombinedResult<ClusterFactory, InnerClusterEndpointFactory> WithEndpoint(this ClusterFactory parentFactory, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null)
    {
        parentFactory.EndpointFactory = new InnerClusterEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndpointFactory);
    }

    public static CombinedResult<ClusterFactory, InnerClusterLoggingPropertiesFactory> WithLoggingProperties(this ClusterFactory parentFactory, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null)
    {
        parentFactory.LoggingPropertiesFactory = new InnerClusterLoggingPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingPropertiesFactory);
    }

    public static CombinedResult<ClusterFactory, T1, InnerClusterEndpointFactory> WithEndpoint<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterEndpointFactory> WithEndpoint<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterEndpointFactory> WithEndpoint<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterEndpointFactory> WithEndpoint<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterEndpointFactory> WithEndpoint<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.Redshift.ClusterTypes.Endpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterLoggingPropertiesFactory> WithLoggingProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingProperties(combinedResult.T5, subFactoryAction));
}
