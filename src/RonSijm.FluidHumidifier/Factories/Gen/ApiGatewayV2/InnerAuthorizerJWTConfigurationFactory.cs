// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerAuthorizerJWTConfigurationFactory(Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration>
{

    protected override Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration Create()
    {
        var jWTConfigurationResult = CreateJWTConfiguration();
        factoryAction?.Invoke(jWTConfigurationResult);

        return jWTConfigurationResult;
    }

    private Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration CreateJWTConfiguration()
    {
        var jWTConfigurationResult = new Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration();

        return jWTConfigurationResult;
    }

} // End Of Class

public static class InnerAuthorizerJWTConfigurationFactoryExtensions
{
}
