// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayMeteringPolicyEntryFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayMeteringPolicyEntry> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayMeteringPolicyEntry>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayMeteringPolicyEntry Create()
    {
        var transitGatewayMeteringPolicyEntryResult = CreateTransitGatewayMeteringPolicyEntry();
        factoryAction?.Invoke(transitGatewayMeteringPolicyEntryResult);

        return transitGatewayMeteringPolicyEntryResult;
    }

    private Humidifier.EC2.TransitGatewayMeteringPolicyEntry CreateTransitGatewayMeteringPolicyEntry()
    {
        var transitGatewayMeteringPolicyEntryResult = new Humidifier.EC2.TransitGatewayMeteringPolicyEntry
        {
            GivenName = InputResourceName,
        };

        return transitGatewayMeteringPolicyEntryResult;
    }

} // End Of Class

public static class TransitGatewayMeteringPolicyEntryFactoryExtensions
{
}
