// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerIPAMResourceDiscoveryIpamResourceDiscoveryOrganizationalUnitExclusionFactory(Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamResourceDiscoveryOrganizationalUnitExclusion> factoryAction = null) : SubResourceFactory<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamResourceDiscoveryOrganizationalUnitExclusion>
{

    protected override Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamResourceDiscoveryOrganizationalUnitExclusion Create()
    {
        var ipamResourceDiscoveryOrganizationalUnitExclusionResult = CreateIpamResourceDiscoveryOrganizationalUnitExclusion();
        factoryAction?.Invoke(ipamResourceDiscoveryOrganizationalUnitExclusionResult);

        return ipamResourceDiscoveryOrganizationalUnitExclusionResult;
    }

    private Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamResourceDiscoveryOrganizationalUnitExclusion CreateIpamResourceDiscoveryOrganizationalUnitExclusion()
    {
        var ipamResourceDiscoveryOrganizationalUnitExclusionResult = new Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamResourceDiscoveryOrganizationalUnitExclusion();

        return ipamResourceDiscoveryOrganizationalUnitExclusionResult;
    }

} // End Of Class

public static class InnerIPAMResourceDiscoveryIpamResourceDiscoveryOrganizationalUnitExclusionFactoryExtensions
{
}
