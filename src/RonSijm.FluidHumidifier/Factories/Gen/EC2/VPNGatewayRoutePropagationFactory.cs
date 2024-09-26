// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPNGatewayRoutePropagationFactory(string resourceName = null, Action<Humidifier.EC2.VPNGatewayRoutePropagation> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPNGatewayRoutePropagation>(resourceName)
{

    protected override Humidifier.EC2.VPNGatewayRoutePropagation Create()
    {
        var vPNGatewayRoutePropagationResult = CreateVPNGatewayRoutePropagation();
        factoryAction?.Invoke(vPNGatewayRoutePropagationResult);

        return vPNGatewayRoutePropagationResult;
    }

    private Humidifier.EC2.VPNGatewayRoutePropagation CreateVPNGatewayRoutePropagation()
    {
        var vPNGatewayRoutePropagationResult = new Humidifier.EC2.VPNGatewayRoutePropagation
        {
            GivenName = InputResourceName,
        };

        return vPNGatewayRoutePropagationResult;
    }

} // End Of Class

public static class VPNGatewayRoutePropagationFactoryExtensions
{
}
