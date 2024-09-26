// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerIPAMResourceDiscoveryIpamOperatingRegionFactory(Action<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion> factoryAction = null) : SubResourceFactory<Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion>
{

    protected override Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion Create()
    {
        var ipamOperatingRegionResult = CreateIpamOperatingRegion();
        factoryAction?.Invoke(ipamOperatingRegionResult);

        return ipamOperatingRegionResult;
    }

    private Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion CreateIpamOperatingRegion()
    {
        var ipamOperatingRegionResult = new Humidifier.EC2.IPAMResourceDiscoveryTypes.IpamOperatingRegion();

        return ipamOperatingRegionResult;
    }

} // End Of Class

public static class InnerIPAMResourceDiscoveryIpamOperatingRegionFactoryExtensions
{
}
