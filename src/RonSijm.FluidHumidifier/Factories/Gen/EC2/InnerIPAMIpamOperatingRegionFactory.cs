// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerIPAMIpamOperatingRegionFactory(Action<Humidifier.EC2.IPAMTypes.IpamOperatingRegion> factoryAction = null) : SubResourceFactory<Humidifier.EC2.IPAMTypes.IpamOperatingRegion>
{

    protected override Humidifier.EC2.IPAMTypes.IpamOperatingRegion Create()
    {
        var ipamOperatingRegionResult = CreateIpamOperatingRegion();
        factoryAction?.Invoke(ipamOperatingRegionResult);

        return ipamOperatingRegionResult;
    }

    private Humidifier.EC2.IPAMTypes.IpamOperatingRegion CreateIpamOperatingRegion()
    {
        var ipamOperatingRegionResult = new Humidifier.EC2.IPAMTypes.IpamOperatingRegion();

        return ipamOperatingRegionResult;
    }

} // End Of Class

public static class InnerIPAMIpamOperatingRegionFactoryExtensions
{
}
