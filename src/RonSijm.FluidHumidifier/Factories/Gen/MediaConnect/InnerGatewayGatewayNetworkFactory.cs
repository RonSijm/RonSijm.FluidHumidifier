// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerGatewayGatewayNetworkFactory(Action<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork>
{

    protected override Humidifier.MediaConnect.GatewayTypes.GatewayNetwork Create()
    {
        var gatewayNetworkResult = CreateGatewayNetwork();
        factoryAction?.Invoke(gatewayNetworkResult);

        return gatewayNetworkResult;
    }

    private Humidifier.MediaConnect.GatewayTypes.GatewayNetwork CreateGatewayNetwork()
    {
        var gatewayNetworkResult = new Humidifier.MediaConnect.GatewayTypes.GatewayNetwork();

        return gatewayNetworkResult;
    }

} // End Of Class

public static class InnerGatewayGatewayNetworkFactoryExtensions
{
}
