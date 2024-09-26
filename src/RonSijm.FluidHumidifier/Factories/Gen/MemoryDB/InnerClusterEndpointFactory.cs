// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class InnerClusterEndpointFactory(Action<Humidifier.MemoryDB.ClusterTypes.Endpoint> factoryAction = null) : SubResourceFactory<Humidifier.MemoryDB.ClusterTypes.Endpoint>
{

    protected override Humidifier.MemoryDB.ClusterTypes.Endpoint Create()
    {
        var endpointResult = CreateEndpoint();
        factoryAction?.Invoke(endpointResult);

        return endpointResult;
    }

    private Humidifier.MemoryDB.ClusterTypes.Endpoint CreateEndpoint()
    {
        var endpointResult = new Humidifier.MemoryDB.ClusterTypes.Endpoint();

        return endpointResult;
    }

} // End Of Class

public static class InnerClusterEndpointFactoryExtensions
{
}
