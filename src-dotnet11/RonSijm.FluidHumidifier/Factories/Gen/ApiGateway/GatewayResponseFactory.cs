// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class GatewayResponseFactory(string resourceName = null, Action<Humidifier.ApiGateway.GatewayResponse> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.GatewayResponse>(resourceName)
{

    protected override Humidifier.ApiGateway.GatewayResponse Create()
    {
        var gatewayResponseResult = CreateGatewayResponse();
        factoryAction?.Invoke(gatewayResponseResult);

        return gatewayResponseResult;
    }

    private Humidifier.ApiGateway.GatewayResponse CreateGatewayResponse()
    {
        var gatewayResponseResult = new Humidifier.ApiGateway.GatewayResponse
        {
            GivenName = InputResourceName,
        };

        return gatewayResponseResult;
    }

} // End Of Class

public static class GatewayResponseFactoryExtensions
{
}
