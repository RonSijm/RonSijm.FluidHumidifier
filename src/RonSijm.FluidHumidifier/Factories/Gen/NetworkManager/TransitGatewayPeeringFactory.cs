// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class TransitGatewayPeeringFactory(string resourceName = null, Action<Humidifier.NetworkManager.TransitGatewayPeering> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.TransitGatewayPeering>(resourceName)
{

    protected override Humidifier.NetworkManager.TransitGatewayPeering Create()
    {
        var transitGatewayPeeringResult = CreateTransitGatewayPeering();
        factoryAction?.Invoke(transitGatewayPeeringResult);

        return transitGatewayPeeringResult;
    }

    private Humidifier.NetworkManager.TransitGatewayPeering CreateTransitGatewayPeering()
    {
        var transitGatewayPeeringResult = new Humidifier.NetworkManager.TransitGatewayPeering
        {
            GivenName = InputResourceName,
        };

        return transitGatewayPeeringResult;
    }

} // End Of Class

public static class TransitGatewayPeeringFactoryExtensions
{
}
