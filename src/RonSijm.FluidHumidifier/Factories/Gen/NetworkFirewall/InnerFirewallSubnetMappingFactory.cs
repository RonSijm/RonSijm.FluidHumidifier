// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallSubnetMappingFactory(Action<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping>
{

    protected override Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping Create()
    {
        var subnetMappingResult = CreateSubnetMapping();
        factoryAction?.Invoke(subnetMappingResult);

        return subnetMappingResult;
    }

    private Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping CreateSubnetMapping()
    {
        var subnetMappingResult = new Humidifier.NetworkFirewall.FirewallTypes.SubnetMapping();

        return subnetMappingResult;
    }

} // End Of Class

public static class InnerFirewallSubnetMappingFactoryExtensions
{
}
