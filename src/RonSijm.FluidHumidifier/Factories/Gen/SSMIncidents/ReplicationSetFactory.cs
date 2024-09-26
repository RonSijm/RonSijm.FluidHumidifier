// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class ReplicationSetFactory(string resourceName = null, Action<Humidifier.SSMIncidents.ReplicationSet> factoryAction = null) : ResourceFactory<Humidifier.SSMIncidents.ReplicationSet>(resourceName)
{

    internal List<InnerReplicationSetReplicationRegionFactory> RegionsFactories { get; set; } = [];

    protected override Humidifier.SSMIncidents.ReplicationSet Create()
    {
        var replicationSetResult = CreateReplicationSet();
        factoryAction?.Invoke(replicationSetResult);

        return replicationSetResult;
    }

    private Humidifier.SSMIncidents.ReplicationSet CreateReplicationSet()
    {
        var replicationSetResult = new Humidifier.SSMIncidents.ReplicationSet
        {
            GivenName = InputResourceName,
        };

        return replicationSetResult;
    }
    public override void CreateChildren(Humidifier.SSMIncidents.ReplicationSet result)
    {
        base.CreateChildren(result);

        result.Regions = RegionsFactories.Any() ? RegionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ReplicationSetFactoryExtensions
{
    public static CombinedResult<ReplicationSetFactory, InnerReplicationSetReplicationRegionFactory> WithRegions(this ReplicationSetFactory parentFactory, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null)
    {
        var factory = new InnerReplicationSetReplicationRegionFactory(subFactoryAction);
        parentFactory.RegionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ReplicationSetFactory, T1, InnerReplicationSetReplicationRegionFactory> WithRegions<T1>(this CombinedResult<ReplicationSetFactory, T1> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationSetFactory, InnerReplicationSetReplicationRegionFactory> WithRegions<T1>(this CombinedResult<T1, ReplicationSetFactory> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReplicationSetFactory, T1, T2, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2>(this CombinedResult<ReplicationSetFactory, T1, T2> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationSetFactory, T2, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2>(this CombinedResult<T1, ReplicationSetFactory, T2> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationSetFactory, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2>(this CombinedResult<T1, T2, ReplicationSetFactory> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReplicationSetFactory, T1, T2, T3, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2, T3>(this CombinedResult<ReplicationSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationSetFactory, T2, T3, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2, T3>(this CombinedResult<T1, ReplicationSetFactory, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationSetFactory, T3, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2, T3>(this CombinedResult<T1, T2, ReplicationSetFactory, T3> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationSetFactory, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReplicationSetFactory> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReplicationSetFactory, T1, T2, T3, T4, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<ReplicationSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReplicationSetFactory, T2, T3, T4, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<T1, ReplicationSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReplicationSetFactory, T3, T4, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReplicationSetFactory, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReplicationSetFactory, T4, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReplicationSetFactory, T4> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReplicationSetFactory, InnerReplicationSetReplicationRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReplicationSetFactory> combinedResult, Action<Humidifier.SSMIncidents.ReplicationSetTypes.ReplicationRegion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T5, subFactoryAction));
}
