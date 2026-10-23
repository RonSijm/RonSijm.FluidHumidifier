// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceGatewayConnectorHealthCheckMatcherFactory(Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher>
{

    protected override Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher Create()
    {
        var gatewayConnectorHealthCheckMatcherResult = CreateGatewayConnectorHealthCheckMatcher();
        factoryAction?.Invoke(gatewayConnectorHealthCheckMatcherResult);

        return gatewayConnectorHealthCheckMatcherResult;
    }

    private Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher CreateGatewayConnectorHealthCheckMatcher()
    {
        var gatewayConnectorHealthCheckMatcherResult = new Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher();

        return gatewayConnectorHealthCheckMatcherResult;
    }

} // End Of Class

public static class InnerServiceGatewayConnectorHealthCheckMatcherFactoryExtensions
{
}
