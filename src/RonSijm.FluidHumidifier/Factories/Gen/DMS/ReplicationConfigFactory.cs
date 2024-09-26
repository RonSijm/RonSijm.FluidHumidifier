// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class ReplicationConfigFactory(string resourceName = null, Action<Humidifier.DMS.ReplicationConfig> factoryAction = null) : ResourceFactory<Humidifier.DMS.ReplicationConfig>(resourceName)
{

    internal InnerReplicationConfigComputeConfigFactory ComputeConfigFactory { get; set; }

    protected override Humidifier.DMS.ReplicationConfig Create()
    {
        var replicationConfigResult = CreateReplicationConfig();
        factoryAction?.Invoke(replicationConfigResult);

        return replicationConfigResult;
    }

    private Humidifier.DMS.ReplicationConfig CreateReplicationConfig()
    {
        var replicationConfigResult = new Humidifier.DMS.ReplicationConfig
        {
            GivenName = InputResourceName,
        };

        return replicationConfigResult;
    }
    public override void CreateChildren(Humidifier.DMS.ReplicationConfig result)
    {
        base.CreateChildren(result);

        result.ComputeConfig ??= ComputeConfigFactory?.Build();
    }

} // End Of Class

public static class ReplicationConfigFactoryExtensions
{
    public static CombinedResult<ReplicationConfigFactory, InnerReplicationConfigComputeConfigFactory> WithComputeConfig(this ReplicationConfigFactory parentFactory, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null)
    {
        parentFactory.ComputeConfigFactory = new InnerReplicationConfigComputeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComputeConfigFactory);
    }

    public static CombinedResult<ReplicationConfigFactory, T1, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1>(this CombinedResult<ReplicationConfigFactory, T1> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationConfigFactory, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1>(this CombinedResult<T1, ReplicationConfigFactory> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReplicationConfigFactory, T1, T2, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2>(this CombinedResult<ReplicationConfigFactory, T1, T2> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationConfigFactory, T2, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2>(this CombinedResult<T1, ReplicationConfigFactory, T2> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationConfigFactory, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2>(this CombinedResult<T1, T2, ReplicationConfigFactory> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReplicationConfigFactory, T1, T2, T3, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2, T3>(this CombinedResult<ReplicationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationConfigFactory, T2, T3, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2, T3>(this CombinedResult<T1, ReplicationConfigFactory, T2, T3> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationConfigFactory, T3, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2, T3>(this CombinedResult<T1, T2, ReplicationConfigFactory, T3> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationConfigFactory, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReplicationConfigFactory> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReplicationConfigFactory, T1, T2, T3, T4, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2, T3, T4>(this CombinedResult<ReplicationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationConfigFactory, T2, T3, T4, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2, T3, T4>(this CombinedResult<T1, ReplicationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationConfigFactory, T3, T4, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReplicationConfigFactory, T3, T4> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationConfigFactory, T4, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReplicationConfigFactory, T4> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReplicationConfigFactory, InnerReplicationConfigComputeConfigFactory> WithComputeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReplicationConfigFactory> combinedResult, Action<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfig(combinedResult.T5, subFactoryAction));
}
