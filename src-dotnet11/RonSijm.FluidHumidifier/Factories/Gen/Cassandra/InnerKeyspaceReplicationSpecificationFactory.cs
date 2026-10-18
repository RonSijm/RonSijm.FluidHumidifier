// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerKeyspaceReplicationSpecificationFactory(Action<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification>
{

    protected override Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification Create()
    {
        var replicationSpecificationResult = CreateReplicationSpecification();
        factoryAction?.Invoke(replicationSpecificationResult);

        return replicationSpecificationResult;
    }

    private Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification CreateReplicationSpecification()
    {
        var replicationSpecificationResult = new Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification();

        return replicationSpecificationResult;
    }

} // End Of Class

public static class InnerKeyspaceReplicationSpecificationFactoryExtensions
{
}
