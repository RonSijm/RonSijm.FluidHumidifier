// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class ReplicationSubnetGroupFactory(string resourceName = null, Action<Humidifier.DMS.ReplicationSubnetGroup> factoryAction = null) : ResourceFactory<Humidifier.DMS.ReplicationSubnetGroup>(resourceName)
{

    protected override Humidifier.DMS.ReplicationSubnetGroup Create()
    {
        var replicationSubnetGroupResult = CreateReplicationSubnetGroup();
        factoryAction?.Invoke(replicationSubnetGroupResult);

        return replicationSubnetGroupResult;
    }

    private Humidifier.DMS.ReplicationSubnetGroup CreateReplicationSubnetGroup()
    {
        var replicationSubnetGroupResult = new Humidifier.DMS.ReplicationSubnetGroup
        {
            GivenName = InputResourceName,
        };

        return replicationSubnetGroupResult;
    }

} // End Of Class

public static class ReplicationSubnetGroupFactoryExtensions
{
}
