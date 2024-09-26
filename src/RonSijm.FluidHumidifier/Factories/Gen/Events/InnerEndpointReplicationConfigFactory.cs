// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerEndpointReplicationConfigFactory(Action<Humidifier.Events.EndpointTypes.ReplicationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Events.EndpointTypes.ReplicationConfig>
{

    protected override Humidifier.Events.EndpointTypes.ReplicationConfig Create()
    {
        var replicationConfigResult = CreateReplicationConfig();
        factoryAction?.Invoke(replicationConfigResult);

        return replicationConfigResult;
    }

    private Humidifier.Events.EndpointTypes.ReplicationConfig CreateReplicationConfig()
    {
        var replicationConfigResult = new Humidifier.Events.EndpointTypes.ReplicationConfig();

        return replicationConfigResult;
    }

} // End Of Class

public static class InnerEndpointReplicationConfigFactoryExtensions
{
}
