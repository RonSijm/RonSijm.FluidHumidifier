// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerServerlessCacheEndpointFactory(Action<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint>
{

    protected override Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint Create()
    {
        var endpointResult = CreateEndpoint();
        factoryAction?.Invoke(endpointResult);

        return endpointResult;
    }

    private Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint CreateEndpoint()
    {
        var endpointResult = new Humidifier.ElastiCache.ServerlessCacheTypes.Endpoint();

        return endpointResult;
    }

} // End Of Class

public static class InnerServerlessCacheEndpointFactoryExtensions
{
}
