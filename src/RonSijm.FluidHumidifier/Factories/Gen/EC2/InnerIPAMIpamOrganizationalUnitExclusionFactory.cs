// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerIPAMIpamOrganizationalUnitExclusionFactory(Action<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion> factoryAction = null) : SubResourceFactory<Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion>
{

    protected override Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion Create()
    {
        var ipamOrganizationalUnitExclusionResult = CreateIpamOrganizationalUnitExclusion();
        factoryAction?.Invoke(ipamOrganizationalUnitExclusionResult);

        return ipamOrganizationalUnitExclusionResult;
    }

    private Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion CreateIpamOrganizationalUnitExclusion()
    {
        var ipamOrganizationalUnitExclusionResult = new Humidifier.EC2.IPAMTypes.IpamOrganizationalUnitExclusion();

        return ipamOrganizationalUnitExclusionResult;
    }

} // End Of Class

public static class InnerIPAMIpamOrganizationalUnitExclusionFactoryExtensions
{
}
