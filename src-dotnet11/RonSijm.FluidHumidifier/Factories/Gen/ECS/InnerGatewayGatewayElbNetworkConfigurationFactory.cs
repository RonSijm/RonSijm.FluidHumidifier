// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerGatewayGatewayElbNetworkConfigurationFactory(Action<Humidifier.ECS.GatewayTypes.GatewayElbNetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.GatewayTypes.GatewayElbNetworkConfiguration>
{

    protected override Humidifier.ECS.GatewayTypes.GatewayElbNetworkConfiguration Create()
    {
        var gatewayElbNetworkConfigurationResult = CreateGatewayElbNetworkConfiguration();
        factoryAction?.Invoke(gatewayElbNetworkConfigurationResult);

        return gatewayElbNetworkConfigurationResult;
    }

    private Humidifier.ECS.GatewayTypes.GatewayElbNetworkConfiguration CreateGatewayElbNetworkConfiguration()
    {
        var gatewayElbNetworkConfigurationResult = new Humidifier.ECS.GatewayTypes.GatewayElbNetworkConfiguration();

        return gatewayElbNetworkConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayGatewayElbNetworkConfigurationFactoryExtensions
{
}
