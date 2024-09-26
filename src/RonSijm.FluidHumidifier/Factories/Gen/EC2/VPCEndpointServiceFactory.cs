// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCEndpointServiceFactory(string resourceName = null, Action<Humidifier.EC2.VPCEndpointService> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCEndpointService>(resourceName)
{

    protected override Humidifier.EC2.VPCEndpointService Create()
    {
        var vPCEndpointServiceResult = CreateVPCEndpointService();
        factoryAction?.Invoke(vPCEndpointServiceResult);

        return vPCEndpointServiceResult;
    }

    private Humidifier.EC2.VPCEndpointService CreateVPCEndpointService()
    {
        var vPCEndpointServiceResult = new Humidifier.EC2.VPCEndpointService
        {
            GivenName = InputResourceName,
        };

        return vPCEndpointServiceResult;
    }

} // End Of Class

public static class VPCEndpointServiceFactoryExtensions
{
}
