// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerExpressGatewayServiceExpressGatewayScalingTargetFactory(Action<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayScalingTarget> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayScalingTarget>
{

    protected override Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayScalingTarget Create()
    {
        var expressGatewayScalingTargetResult = CreateExpressGatewayScalingTarget();
        factoryAction?.Invoke(expressGatewayScalingTargetResult);

        return expressGatewayScalingTargetResult;
    }

    private Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayScalingTarget CreateExpressGatewayScalingTarget()
    {
        var expressGatewayScalingTargetResult = new Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayScalingTarget();

        return expressGatewayScalingTargetResult;
    }

} // End Of Class

public static class InnerExpressGatewayServiceExpressGatewayScalingTargetFactoryExtensions
{
}
