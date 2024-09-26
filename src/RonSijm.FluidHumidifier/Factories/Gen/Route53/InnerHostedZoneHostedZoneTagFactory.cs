// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerHostedZoneHostedZoneTagFactory(Action<Humidifier.Route53.HostedZoneTypes.HostedZoneTag> factoryAction = null) : SubResourceFactory<Humidifier.Route53.HostedZoneTypes.HostedZoneTag>
{

    protected override Humidifier.Route53.HostedZoneTypes.HostedZoneTag Create()
    {
        var hostedZoneTagResult = CreateHostedZoneTag();
        factoryAction?.Invoke(hostedZoneTagResult);

        return hostedZoneTagResult;
    }

    private Humidifier.Route53.HostedZoneTypes.HostedZoneTag CreateHostedZoneTag()
    {
        var hostedZoneTagResult = new Humidifier.Route53.HostedZoneTypes.HostedZoneTag();

        return hostedZoneTagResult;
    }

} // End Of Class

public static class InnerHostedZoneHostedZoneTagFactoryExtensions
{
}
