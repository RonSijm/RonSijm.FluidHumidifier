// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerRouteServerPeerBgpOptionsFactory(Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.RouteServerPeerTypes.BgpOptions>
{

    protected override Humidifier.EC2.RouteServerPeerTypes.BgpOptions Create()
    {
        var bgpOptionsResult = CreateBgpOptions();
        factoryAction?.Invoke(bgpOptionsResult);

        return bgpOptionsResult;
    }

    private Humidifier.EC2.RouteServerPeerTypes.BgpOptions CreateBgpOptions()
    {
        var bgpOptionsResult = new Humidifier.EC2.RouteServerPeerTypes.BgpOptions();

        return bgpOptionsResult;
    }

} // End Of Class

public static class InnerRouteServerPeerBgpOptionsFactoryExtensions
{
}
