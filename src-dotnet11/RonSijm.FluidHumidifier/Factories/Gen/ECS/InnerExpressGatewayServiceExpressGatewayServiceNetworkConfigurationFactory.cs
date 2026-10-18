// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerExpressGatewayServiceExpressGatewayServiceNetworkConfigurationFactory(Action<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceNetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceNetworkConfiguration>
{

    protected override Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceNetworkConfiguration Create()
    {
        var expressGatewayServiceNetworkConfigurationResult = CreateExpressGatewayServiceNetworkConfiguration();
        factoryAction?.Invoke(expressGatewayServiceNetworkConfigurationResult);

        return expressGatewayServiceNetworkConfigurationResult;
    }

    private Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceNetworkConfiguration CreateExpressGatewayServiceNetworkConfiguration()
    {
        var expressGatewayServiceNetworkConfigurationResult = new Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceNetworkConfiguration();

        return expressGatewayServiceNetworkConfigurationResult;
    }

} // End Of Class

public static class InnerExpressGatewayServiceExpressGatewayServiceNetworkConfigurationFactoryExtensions
{
}
