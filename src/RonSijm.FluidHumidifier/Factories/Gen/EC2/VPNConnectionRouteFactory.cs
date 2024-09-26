// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPNConnectionRouteFactory(string resourceName = null, Action<Humidifier.EC2.VPNConnectionRoute> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPNConnectionRoute>(resourceName)
{

    protected override Humidifier.EC2.VPNConnectionRoute Create()
    {
        var vPNConnectionRouteResult = CreateVPNConnectionRoute();
        factoryAction?.Invoke(vPNConnectionRouteResult);

        return vPNConnectionRouteResult;
    }

    private Humidifier.EC2.VPNConnectionRoute CreateVPNConnectionRoute()
    {
        var vPNConnectionRouteResult = new Humidifier.EC2.VPNConnectionRoute
        {
            GivenName = InputResourceName,
        };

        return vPNConnectionRouteResult;
    }

} // End Of Class

public static class VPNConnectionRouteFactoryExtensions
{
}
