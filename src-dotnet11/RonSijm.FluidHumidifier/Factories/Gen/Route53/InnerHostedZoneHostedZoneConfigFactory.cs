// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerHostedZoneHostedZoneConfigFactory(Action<Humidifier.Route53.HostedZoneTypes.HostedZoneConfig> factoryAction = null) : SubResourceFactory<Humidifier.Route53.HostedZoneTypes.HostedZoneConfig>
{

    protected override Humidifier.Route53.HostedZoneTypes.HostedZoneConfig Create()
    {
        var hostedZoneConfigResult = CreateHostedZoneConfig();
        factoryAction?.Invoke(hostedZoneConfigResult);

        return hostedZoneConfigResult;
    }

    private Humidifier.Route53.HostedZoneTypes.HostedZoneConfig CreateHostedZoneConfig()
    {
        var hostedZoneConfigResult = new Humidifier.Route53.HostedZoneTypes.HostedZoneConfig();

        return hostedZoneConfigResult;
    }

} // End Of Class

public static class InnerHostedZoneHostedZoneConfigFactoryExtensions
{
}
