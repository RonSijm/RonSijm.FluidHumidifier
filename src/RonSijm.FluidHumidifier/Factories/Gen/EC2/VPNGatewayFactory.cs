// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPNGatewayFactory(string resourceName = null, Action<Humidifier.EC2.VPNGateway> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPNGateway>(resourceName)
{

    protected override Humidifier.EC2.VPNGateway Create()
    {
        var vPNGatewayResult = CreateVPNGateway();
        factoryAction?.Invoke(vPNGatewayResult);

        return vPNGatewayResult;
    }

    private Humidifier.EC2.VPNGateway CreateVPNGateway()
    {
        var vPNGatewayResult = new Humidifier.EC2.VPNGateway
        {
            GivenName = InputResourceName,
        };

        return vPNGatewayResult;
    }

} // End Of Class

public static class VPNGatewayFactoryExtensions
{
}
