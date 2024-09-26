// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class InnerClusterEndpointFactory(Action<Humidifier.Redshift.ClusterTypes.Endpoint> factoryAction = null) : SubResourceFactory<Humidifier.Redshift.ClusterTypes.Endpoint>
{

    protected override Humidifier.Redshift.ClusterTypes.Endpoint Create()
    {
        var endpointResult = CreateEndpoint();
        factoryAction?.Invoke(endpointResult);

        return endpointResult;
    }

    private Humidifier.Redshift.ClusterTypes.Endpoint CreateEndpoint()
    {
        var endpointResult = new Humidifier.Redshift.ClusterTypes.Endpoint();

        return endpointResult;
    }

} // End Of Class

public static class InnerClusterEndpointFactoryExtensions
{
}
