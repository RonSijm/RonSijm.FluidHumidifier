// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerApiGatewayManagedOverridesIntegrationOverridesFactory(Action<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.IntegrationOverrides> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.IntegrationOverrides>
{

    protected override Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.IntegrationOverrides Create()
    {
        var integrationOverridesResult = CreateIntegrationOverrides();
        factoryAction?.Invoke(integrationOverridesResult);

        return integrationOverridesResult;
    }

    private Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.IntegrationOverrides CreateIntegrationOverrides()
    {
        var integrationOverridesResult = new Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.IntegrationOverrides();

        return integrationOverridesResult;
    }

} // End Of Class

public static class InnerApiGatewayManagedOverridesIntegrationOverridesFactoryExtensions
{
}
