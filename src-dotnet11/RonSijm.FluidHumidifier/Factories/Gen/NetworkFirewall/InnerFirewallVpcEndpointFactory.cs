// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallVpcEndpointFactory(Action<Humidifier.NetworkFirewall.FirewallTypes.VpcEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallTypes.VpcEndpoint>
{

    protected override Humidifier.NetworkFirewall.FirewallTypes.VpcEndpoint Create()
    {
        var vpcEndpointResult = CreateVpcEndpoint();
        factoryAction?.Invoke(vpcEndpointResult);

        return vpcEndpointResult;
    }

    private Humidifier.NetworkFirewall.FirewallTypes.VpcEndpoint CreateVpcEndpoint()
    {
        var vpcEndpointResult = new Humidifier.NetworkFirewall.FirewallTypes.VpcEndpoint();

        return vpcEndpointResult;
    }

} // End Of Class

public static class InnerFirewallVpcEndpointFactoryExtensions
{
}
