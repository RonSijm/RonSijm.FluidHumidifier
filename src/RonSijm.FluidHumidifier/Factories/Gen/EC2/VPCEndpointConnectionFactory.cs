// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCEndpointConnectionFactory(string resourceName = null, Action<Humidifier.EC2.VPCEndpointConnection> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCEndpointConnection>(resourceName)
{

    protected override Humidifier.EC2.VPCEndpointConnection Create()
    {
        var vPCEndpointConnectionResult = CreateVPCEndpointConnection();
        factoryAction?.Invoke(vPCEndpointConnectionResult);

        return vPCEndpointConnectionResult;
    }

    private Humidifier.EC2.VPCEndpointConnection CreateVPCEndpointConnection()
    {
        var vPCEndpointConnectionResult = new Humidifier.EC2.VPCEndpointConnection
        {
            GivenName = InputResourceName,
        };

        return vPCEndpointConnectionResult;
    }

} // End Of Class

public static class VPCEndpointConnectionFactoryExtensions
{
}
