// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayMeteringPolicyFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayMeteringPolicy> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayMeteringPolicy>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayMeteringPolicy Create()
    {
        var transitGatewayMeteringPolicyResult = CreateTransitGatewayMeteringPolicy();
        factoryAction?.Invoke(transitGatewayMeteringPolicyResult);

        return transitGatewayMeteringPolicyResult;
    }

    private Humidifier.EC2.TransitGatewayMeteringPolicy CreateTransitGatewayMeteringPolicy()
    {
        var transitGatewayMeteringPolicyResult = new Humidifier.EC2.TransitGatewayMeteringPolicy
        {
            GivenName = InputResourceName,
        };

        return transitGatewayMeteringPolicyResult;
    }

} // End Of Class

public static class TransitGatewayMeteringPolicyFactoryExtensions
{
}
