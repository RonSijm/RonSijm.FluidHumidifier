// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVPNConnectionVpnTunnelOptionsSpecificationFactory(Action<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification>
{

    protected override Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification Create()
    {
        var vpnTunnelOptionsSpecificationResult = CreateVpnTunnelOptionsSpecification();
        factoryAction?.Invoke(vpnTunnelOptionsSpecificationResult);

        return vpnTunnelOptionsSpecificationResult;
    }

    private Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification CreateVpnTunnelOptionsSpecification()
    {
        var vpnTunnelOptionsSpecificationResult = new Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification();

        return vpnTunnelOptionsSpecificationResult;
    }

} // End Of Class

public static class InnerVPNConnectionVpnTunnelOptionsSpecificationFactoryExtensions
{
}
