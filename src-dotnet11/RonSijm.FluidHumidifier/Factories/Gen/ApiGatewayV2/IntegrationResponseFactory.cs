// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class IntegrationResponseFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.IntegrationResponse> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.IntegrationResponse>(resourceName)
{

    protected override Humidifier.ApiGatewayV2.IntegrationResponse Create()
    {
        var integrationResponseResult = CreateIntegrationResponse();
        factoryAction?.Invoke(integrationResponseResult);

        return integrationResponseResult;
    }

    private Humidifier.ApiGatewayV2.IntegrationResponse CreateIntegrationResponse()
    {
        var integrationResponseResult = new Humidifier.ApiGatewayV2.IntegrationResponse
        {
            GivenName = InputResourceName,
        };

        return integrationResponseResult;
    }

} // End Of Class

public static class IntegrationResponseFactoryExtensions
{
}
