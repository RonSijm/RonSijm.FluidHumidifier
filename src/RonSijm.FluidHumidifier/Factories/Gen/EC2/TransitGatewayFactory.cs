// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayFactory(string resourceName = null, Action<Humidifier.EC2.TransitGateway> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGateway>(resourceName)
{

    protected override Humidifier.EC2.TransitGateway Create()
    {
        var transitGatewayResult = CreateTransitGateway();
        factoryAction?.Invoke(transitGatewayResult);

        return transitGatewayResult;
    }

    private Humidifier.EC2.TransitGateway CreateTransitGateway()
    {
        var transitGatewayResult = new Humidifier.EC2.TransitGateway
        {
            GivenName = InputResourceName,
        };

        return transitGatewayResult;
    }

} // End Of Class

public static class TransitGatewayFactoryExtensions
{
}
