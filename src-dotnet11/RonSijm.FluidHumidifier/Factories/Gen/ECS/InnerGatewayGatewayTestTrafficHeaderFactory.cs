// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerGatewayGatewayTestTrafficHeaderFactory(Action<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader> factoryAction = null) : SubResourceFactory<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader>
{

    protected override Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader Create()
    {
        var gatewayTestTrafficHeaderResult = CreateGatewayTestTrafficHeader();
        factoryAction?.Invoke(gatewayTestTrafficHeaderResult);

        return gatewayTestTrafficHeaderResult;
    }

    private Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader CreateGatewayTestTrafficHeader()
    {
        var gatewayTestTrafficHeaderResult = new Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader();

        return gatewayTestTrafficHeaderResult;
    }

} // End Of Class

public static class InnerGatewayGatewayTestTrafficHeaderFactoryExtensions
{
}
