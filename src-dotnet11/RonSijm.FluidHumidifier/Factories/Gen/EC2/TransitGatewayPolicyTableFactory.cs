// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayPolicyTableFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayPolicyTable> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayPolicyTable>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayPolicyTable Create()
    {
        var transitGatewayPolicyTableResult = CreateTransitGatewayPolicyTable();
        factoryAction?.Invoke(transitGatewayPolicyTableResult);

        return transitGatewayPolicyTableResult;
    }

    private Humidifier.EC2.TransitGatewayPolicyTable CreateTransitGatewayPolicyTable()
    {
        var transitGatewayPolicyTableResult = new Humidifier.EC2.TransitGatewayPolicyTable
        {
            GivenName = InputResourceName,
        };

        return transitGatewayPolicyTableResult;
    }

} // End Of Class

public static class TransitGatewayPolicyTableFactoryExtensions
{
}
