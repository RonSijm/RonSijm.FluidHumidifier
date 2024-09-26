// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class KeyspaceFactory(string resourceName = null, Action<Humidifier.Cassandra.Keyspace> factoryAction = null) : ResourceFactory<Humidifier.Cassandra.Keyspace>(resourceName)
{

    internal InnerKeyspaceReplicationSpecificationFactory ReplicationSpecificationFactory { get; set; }

    protected override Humidifier.Cassandra.Keyspace Create()
    {
        var keyspaceResult = CreateKeyspace();
        factoryAction?.Invoke(keyspaceResult);

        return keyspaceResult;
    }

    private Humidifier.Cassandra.Keyspace CreateKeyspace()
    {
        var keyspaceResult = new Humidifier.Cassandra.Keyspace
        {
            GivenName = InputResourceName,
        };

        return keyspaceResult;
    }
    public override void CreateChildren(Humidifier.Cassandra.Keyspace result)
    {
        base.CreateChildren(result);

        result.ReplicationSpecification ??= ReplicationSpecificationFactory?.Build();
    }

} // End Of Class

public static class KeyspaceFactoryExtensions
{
    public static CombinedResult<KeyspaceFactory, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification(this KeyspaceFactory parentFactory, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null)
    {
        parentFactory.ReplicationSpecificationFactory = new InnerKeyspaceReplicationSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReplicationSpecificationFactory);
    }

    public static CombinedResult<KeyspaceFactory, T1, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1>(this CombinedResult<KeyspaceFactory, T1> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyspaceFactory, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1>(this CombinedResult<T1, KeyspaceFactory> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<KeyspaceFactory, T1, T2, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2>(this CombinedResult<KeyspaceFactory, T1, T2> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyspaceFactory, T2, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2>(this CombinedResult<T1, KeyspaceFactory, T2> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyspaceFactory, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2>(this CombinedResult<T1, T2, KeyspaceFactory> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<KeyspaceFactory, T1, T2, T3, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2, T3>(this CombinedResult<KeyspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyspaceFactory, T2, T3, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2, T3>(this CombinedResult<T1, KeyspaceFactory, T2, T3> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyspaceFactory, T3, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2, T3>(this CombinedResult<T1, T2, KeyspaceFactory, T3> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KeyspaceFactory, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, KeyspaceFactory> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<KeyspaceFactory, T1, T2, T3, T4, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2, T3, T4>(this CombinedResult<KeyspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KeyspaceFactory, T2, T3, T4, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2, T3, T4>(this CombinedResult<T1, KeyspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KeyspaceFactory, T3, T4, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, KeyspaceFactory, T3, T4> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KeyspaceFactory, T4, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, KeyspaceFactory, T4> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, KeyspaceFactory, InnerKeyspaceReplicationSpecificationFactory> WithReplicationSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, KeyspaceFactory> combinedResult, Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationSpecification(combinedResult.T5, subFactoryAction));
}
