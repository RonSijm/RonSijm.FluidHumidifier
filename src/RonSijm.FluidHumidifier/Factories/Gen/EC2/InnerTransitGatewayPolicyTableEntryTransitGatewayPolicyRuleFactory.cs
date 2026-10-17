// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactory(Action<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule> factoryAction = null) : SubResourceFactory<Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule>
{

    protected override Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule Create()
    {
        var transitGatewayPolicyRuleResult = CreateTransitGatewayPolicyRule();
        factoryAction?.Invoke(transitGatewayPolicyRuleResult);

        return transitGatewayPolicyRuleResult;
    }

    private Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule CreateTransitGatewayPolicyRule()
    {
        var transitGatewayPolicyRuleResult = new Humidifier.EC2.TransitGatewayPolicyTableEntryTypes.TransitGatewayPolicyRule();

        return transitGatewayPolicyRuleResult;
    }

} // End Of Class

public static class InnerTransitGatewayPolicyTableEntryTransitGatewayPolicyRuleFactoryExtensions
{
}
