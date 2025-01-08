// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class ClusterFactory(string resourceName = null, Action<Humidifier.PCS.Cluster> factoryAction = null) : ResourceFactory<Humidifier.PCS.Cluster>(resourceName)
{

    internal InnerClusterNetworkingFactory NetworkingFactory { get; set; }

    internal InnerClusterSchedulerFactory SchedulerFactory { get; set; }

    internal InnerClusterSlurmConfigurationFactory SlurmConfigurationFactory { get; set; }

    protected override Humidifier.PCS.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.PCS.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.PCS.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }
    public override void CreateChildren(Humidifier.PCS.Cluster result)
    {
        base.CreateChildren(result);

        result.Networking ??= NetworkingFactory?.Build();
        result.Scheduler ??= SchedulerFactory?.Build();
        result.SlurmConfiguration ??= SlurmConfigurationFactory?.Build();
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
    public static CombinedResult<ClusterFactory, InnerClusterNetworkingFactory> WithNetworking(this ClusterFactory parentFactory, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null)
    {
        parentFactory.NetworkingFactory = new InnerClusterNetworkingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkingFactory);
    }

    public static CombinedResult<ClusterFactory, InnerClusterSchedulerFactory> WithScheduler(this ClusterFactory parentFactory, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null)
    {
        parentFactory.SchedulerFactory = new InnerClusterSchedulerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchedulerFactory);
    }

    public static CombinedResult<ClusterFactory, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration(this ClusterFactory parentFactory, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null)
    {
        parentFactory.SlurmConfigurationFactory = new InnerClusterSlurmConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SlurmConfigurationFactory);
    }

    public static CombinedResult<ClusterFactory, T1, InnerClusterNetworkingFactory> WithNetworking<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworking(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterNetworkingFactory> WithNetworking<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworking(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterNetworkingFactory> WithNetworking<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterNetworkingFactory> WithNetworking<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterNetworkingFactory> WithNetworking<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterNetworkingFactory> WithNetworking<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterNetworkingFactory> WithNetworking<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterNetworkingFactory> WithNetworking<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterNetworkingFactory> WithNetworking<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterNetworkingFactory> WithNetworking<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.Networking> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworking(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, InnerClusterSchedulerFactory> WithScheduler<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduler(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterSchedulerFactory> WithScheduler<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduler(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterSchedulerFactory> WithScheduler<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterSchedulerFactory> WithScheduler<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterSchedulerFactory> WithScheduler<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterSchedulerFactory> WithScheduler<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterSchedulerFactory> WithScheduler<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterSchedulerFactory> WithScheduler<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterSchedulerFactory> WithScheduler<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterSchedulerFactory> WithScheduler<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterSchedulerFactory> WithScheduler<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterSchedulerFactory> WithScheduler<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterSchedulerFactory> WithScheduler<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterSchedulerFactory> WithScheduler<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.Scheduler> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduler(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterSlurmConfigurationFactory> WithSlurmConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.PCS.ClusterTypes.SlurmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSlurmConfiguration(combinedResult.T5, subFactoryAction));
}
