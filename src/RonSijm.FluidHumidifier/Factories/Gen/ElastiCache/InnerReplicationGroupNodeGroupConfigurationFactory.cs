// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerReplicationGroupNodeGroupConfigurationFactory(Action<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration>
{

    protected override Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration Create()
    {
        var nodeGroupConfigurationResult = CreateNodeGroupConfiguration();
        factoryAction?.Invoke(nodeGroupConfigurationResult);

        return nodeGroupConfigurationResult;
    }

    private Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration CreateNodeGroupConfiguration()
    {
        var nodeGroupConfigurationResult = new Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration();

        return nodeGroupConfigurationResult;
    }

} // End Of Class

public static class InnerReplicationGroupNodeGroupConfigurationFactoryExtensions
{
}
