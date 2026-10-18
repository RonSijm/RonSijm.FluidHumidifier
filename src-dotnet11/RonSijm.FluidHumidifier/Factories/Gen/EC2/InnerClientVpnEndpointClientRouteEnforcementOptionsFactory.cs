// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointClientRouteEnforcementOptionsFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.ClientRouteEnforcementOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.ClientRouteEnforcementOptions>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.ClientRouteEnforcementOptions Create()
    {
        var clientRouteEnforcementOptionsResult = CreateClientRouteEnforcementOptions();
        factoryAction?.Invoke(clientRouteEnforcementOptionsResult);

        return clientRouteEnforcementOptionsResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.ClientRouteEnforcementOptions CreateClientRouteEnforcementOptions()
    {
        var clientRouteEnforcementOptionsResult = new Humidifier.EC2.ClientVpnEndpointTypes.ClientRouteEnforcementOptions();

        return clientRouteEnforcementOptionsResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointClientRouteEnforcementOptionsFactoryExtensions
{
}
