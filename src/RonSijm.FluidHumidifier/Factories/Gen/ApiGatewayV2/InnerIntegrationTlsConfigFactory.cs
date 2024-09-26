// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerIntegrationTlsConfigFactory(Action<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig>
{

    protected override Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig Create()
    {
        var tlsConfigResult = CreateTlsConfig();
        factoryAction?.Invoke(tlsConfigResult);

        return tlsConfigResult;
    }

    private Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig CreateTlsConfig()
    {
        var tlsConfigResult = new Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig();

        return tlsConfigResult;
    }

} // End Of Class

public static class InnerIntegrationTlsConfigFactoryExtensions
{
}
