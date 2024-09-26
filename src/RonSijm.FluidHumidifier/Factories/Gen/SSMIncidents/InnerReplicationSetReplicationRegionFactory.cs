// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class InnerReplicationSetReplicationRegionFactory(Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> factoryAction = null) : SubResourceFactory<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion>
{

    internal InnerReplicationSetRegionConfigurationFactory RegionConfigurationFactory { get; set; }

    protected override Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion Create()
    {
        var replicationRegionResult = CreateReplicationRegion();
        factoryAction?.Invoke(replicationRegionResult);

        return replicationRegionResult;
    }

    private Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion CreateReplicationRegion()
    {
        var replicationRegionResult = new Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion();

        return replicationRegionResult;
    }
    public override void CreateChildren(Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion result)
    {
        base.CreateChildren(result);

        result.RegionConfiguration ??= RegionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerReplicationSetReplicationRegionFactoryExtensions
{
    public static CombinedResult<InnerReplicationSetReplicationRegionFactory, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration(this InnerReplicationSetReplicationRegionFactory parentFactory, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null)
    {
        parentFactory.RegionConfigurationFactory = new InnerReplicationSetRegionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RegionConfigurationFactory);
    }

    public static CombinedResult<InnerReplicationSetReplicationRegionFactory, T1, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1>(this CombinedResult<InnerReplicationSetReplicationRegionFactory, T1> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationSetReplicationRegionFactory, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1>(this CombinedResult<T1, InnerReplicationSetReplicationRegionFactory> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerReplicationSetReplicationRegionFactory, T1, T2, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2>(this CombinedResult<InnerReplicationSetReplicationRegionFactory, T1, T2> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationSetReplicationRegionFactory, T2, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2>(this CombinedResult<T1, InnerReplicationSetReplicationRegionFactory, T2> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicationSetReplicationRegionFactory, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerReplicationSetReplicationRegionFactory> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerReplicationSetReplicationRegionFactory, T1, T2, T3, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2, T3>(this CombinedResult<InnerReplicationSetReplicationRegionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationSetReplicationRegionFactory, T2, T3, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerReplicationSetReplicationRegionFactory, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicationSetReplicationRegionFactory, T3, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerReplicationSetReplicationRegionFactory, T3> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicationSetReplicationRegionFactory, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReplicationSetReplicationRegionFactory> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerReplicationSetReplicationRegionFactory, T1, T2, T3, T4, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerReplicationSetReplicationRegionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicationSetReplicationRegionFactory, T2, T3, T4, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerReplicationSetReplicationRegionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicationSetReplicationRegionFactory, T3, T4, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReplicationSetReplicationRegionFactory, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicationSetReplicationRegionFactory, T4, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReplicationSetReplicationRegionFactory, T4> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerReplicationSetReplicationRegionFactory, InnerReplicationSetRegionConfigurationFactory> WithRegionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReplicationSetReplicationRegionFactory> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.RegionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegionConfiguration(combinedResult.T5, subFactoryAction));
}
