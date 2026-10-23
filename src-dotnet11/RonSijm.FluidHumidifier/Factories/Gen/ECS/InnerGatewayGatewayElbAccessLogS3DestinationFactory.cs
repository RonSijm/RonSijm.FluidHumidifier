// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerGatewayGatewayElbAccessLogS3DestinationFactory(Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> factoryAction = null) : SubResourceFactory<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination>
{

    protected override Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination Create()
    {
        var gatewayElbAccessLogS3DestinationResult = CreateGatewayElbAccessLogS3Destination();
        factoryAction?.Invoke(gatewayElbAccessLogS3DestinationResult);

        return gatewayElbAccessLogS3DestinationResult;
    }

    private Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination CreateGatewayElbAccessLogS3Destination()
    {
        var gatewayElbAccessLogS3DestinationResult = new Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination();

        return gatewayElbAccessLogS3DestinationResult;
    }

} // End Of Class

public static class InnerGatewayGatewayElbAccessLogS3DestinationFactoryExtensions
{
}
