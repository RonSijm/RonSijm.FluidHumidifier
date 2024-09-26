// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCEndpointFactory(string resourceName = null, Action<Humidifier.EC2.VPCEndpoint> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCEndpoint>(resourceName)
{

    protected override Humidifier.EC2.VPCEndpoint Create()
    {
        var vPCEndpointResult = CreateVPCEndpoint();
        factoryAction?.Invoke(vPCEndpointResult);

        return vPCEndpointResult;
    }

    private Humidifier.EC2.VPCEndpoint CreateVPCEndpoint()
    {
        var vPCEndpointResult = new Humidifier.EC2.VPCEndpoint
        {
            GivenName = InputResourceName,
        };

        return vPCEndpointResult;
    }

} // End Of Class

public static class VPCEndpointFactoryExtensions
{
}
