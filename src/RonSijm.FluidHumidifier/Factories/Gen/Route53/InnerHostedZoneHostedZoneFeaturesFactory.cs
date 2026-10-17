// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerHostedZoneHostedZoneFeaturesFactory(Action<Humidifier.Route53.HostedZoneTypes.HostedZoneFeatures> factoryAction = null) : SubResourceFactory<Humidifier.Route53.HostedZoneTypes.HostedZoneFeatures>
{

    protected override Humidifier.Route53.HostedZoneTypes.HostedZoneFeatures Create()
    {
        var hostedZoneFeaturesResult = CreateHostedZoneFeatures();
        factoryAction?.Invoke(hostedZoneFeaturesResult);

        return hostedZoneFeaturesResult;
    }

    private Humidifier.Route53.HostedZoneTypes.HostedZoneFeatures CreateHostedZoneFeatures()
    {
        var hostedZoneFeaturesResult = new Humidifier.Route53.HostedZoneTypes.HostedZoneFeatures();

        return hostedZoneFeaturesResult;
    }

} // End Of Class

public static class InnerHostedZoneHostedZoneFeaturesFactoryExtensions
{
}
