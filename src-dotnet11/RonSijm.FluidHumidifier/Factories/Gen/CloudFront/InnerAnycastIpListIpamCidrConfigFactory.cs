// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerAnycastIpListIpamCidrConfigFactory(Action<Humidifier.CloudFront.AnycastIpListTypes.IpamCidrConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.AnycastIpListTypes.IpamCidrConfig>
{

    protected override Humidifier.CloudFront.AnycastIpListTypes.IpamCidrConfig Create()
    {
        var ipamCidrConfigResult = CreateIpamCidrConfig();
        factoryAction?.Invoke(ipamCidrConfigResult);

        return ipamCidrConfigResult;
    }

    private Humidifier.CloudFront.AnycastIpListTypes.IpamCidrConfig CreateIpamCidrConfig()
    {
        var ipamCidrConfigResult = new Humidifier.CloudFront.AnycastIpListTypes.IpamCidrConfig();

        return ipamCidrConfigResult;
    }

} // End Of Class

public static class InnerAnycastIpListIpamCidrConfigFactoryExtensions
{
}
