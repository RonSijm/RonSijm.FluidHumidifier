// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallAvailabilityZoneMappingFactory(Action<Humidifier.NetworkFirewall.FirewallTypes.AvailabilityZoneMapping> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallTypes.AvailabilityZoneMapping>
{

    protected override Humidifier.NetworkFirewall.FirewallTypes.AvailabilityZoneMapping Create()
    {
        var availabilityZoneMappingResult = CreateAvailabilityZoneMapping();
        factoryAction?.Invoke(availabilityZoneMappingResult);

        return availabilityZoneMappingResult;
    }

    private Humidifier.NetworkFirewall.FirewallTypes.AvailabilityZoneMapping CreateAvailabilityZoneMapping()
    {
        var availabilityZoneMappingResult = new Humidifier.NetworkFirewall.FirewallTypes.AvailabilityZoneMapping();

        return availabilityZoneMappingResult;
    }

} // End Of Class

public static class InnerFirewallAvailabilityZoneMappingFactoryExtensions
{
}
