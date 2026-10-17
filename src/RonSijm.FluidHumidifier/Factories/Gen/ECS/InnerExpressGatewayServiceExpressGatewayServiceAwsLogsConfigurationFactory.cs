// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerExpressGatewayServiceExpressGatewayServiceAwsLogsConfigurationFactory(Action<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceAwsLogsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceAwsLogsConfiguration>
{

    protected override Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceAwsLogsConfiguration Create()
    {
        var expressGatewayServiceAwsLogsConfigurationResult = CreateExpressGatewayServiceAwsLogsConfiguration();
        factoryAction?.Invoke(expressGatewayServiceAwsLogsConfigurationResult);

        return expressGatewayServiceAwsLogsConfigurationResult;
    }

    private Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceAwsLogsConfiguration CreateExpressGatewayServiceAwsLogsConfiguration()
    {
        var expressGatewayServiceAwsLogsConfigurationResult = new Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceAwsLogsConfiguration();

        return expressGatewayServiceAwsLogsConfigurationResult;
    }

} // End Of Class

public static class InnerExpressGatewayServiceExpressGatewayServiceAwsLogsConfigurationFactoryExtensions
{
}
