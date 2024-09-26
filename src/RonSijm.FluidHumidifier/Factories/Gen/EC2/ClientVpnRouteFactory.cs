// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ClientVpnRouteFactory(string resourceName = null, Action<Humidifier.EC2.ClientVpnRoute> factoryAction = null) : ResourceFactory<Humidifier.EC2.ClientVpnRoute>(resourceName)
{

    protected override Humidifier.EC2.ClientVpnRoute Create()
    {
        var clientVpnRouteResult = CreateClientVpnRoute();
        factoryAction?.Invoke(clientVpnRouteResult);

        return clientVpnRouteResult;
    }

    private Humidifier.EC2.ClientVpnRoute CreateClientVpnRoute()
    {
        var clientVpnRouteResult = new Humidifier.EC2.ClientVpnRoute
        {
            GivenName = InputResourceName,
        };

        return clientVpnRouteResult;
    }

} // End Of Class

public static class ClientVpnRouteFactoryExtensions
{
}
