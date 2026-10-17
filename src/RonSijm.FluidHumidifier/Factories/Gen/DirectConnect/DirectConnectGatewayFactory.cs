// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class DirectConnectGatewayFactory(string resourceName = null, Action<Humidifier.DirectConnect.DirectConnectGateway> factoryAction = null) : ResourceFactory<Humidifier.DirectConnect.DirectConnectGateway>(resourceName)
{

    protected override Humidifier.DirectConnect.DirectConnectGateway Create()
    {
        var directConnectGatewayResult = CreateDirectConnectGateway();
        factoryAction?.Invoke(directConnectGatewayResult);

        return directConnectGatewayResult;
    }

    private Humidifier.DirectConnect.DirectConnectGateway CreateDirectConnectGateway()
    {
        var directConnectGatewayResult = new Humidifier.DirectConnect.DirectConnectGateway
        {
            GivenName = InputResourceName,
        };

        return directConnectGatewayResult;
    }

} // End Of Class

public static class DirectConnectGatewayFactoryExtensions
{
}
