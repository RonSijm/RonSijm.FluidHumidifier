// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallNatGatewayMappingFactory(Action<Humidifier.NetworkFirewall.FirewallTypes.NatGatewayMapping> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallTypes.NatGatewayMapping>
{

    protected override Humidifier.NetworkFirewall.FirewallTypes.NatGatewayMapping Create()
    {
        var natGatewayMappingResult = CreateNatGatewayMapping();
        factoryAction?.Invoke(natGatewayMappingResult);

        return natGatewayMappingResult;
    }

    private Humidifier.NetworkFirewall.FirewallTypes.NatGatewayMapping CreateNatGatewayMapping()
    {
        var natGatewayMappingResult = new Humidifier.NetworkFirewall.FirewallTypes.NatGatewayMapping();

        return natGatewayMappingResult;
    }

} // End Of Class

public static class InnerFirewallNatGatewayMappingFactoryExtensions
{
}
