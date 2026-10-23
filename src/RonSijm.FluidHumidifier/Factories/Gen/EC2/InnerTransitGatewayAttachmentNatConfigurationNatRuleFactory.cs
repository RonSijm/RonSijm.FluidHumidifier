// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerTransitGatewayAttachmentNatConfigurationNatRuleFactory(Action<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule> factoryAction = null) : SubResourceFactory<Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule>
{

    protected override Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule Create()
    {
        var natRuleResult = CreateNatRule();
        factoryAction?.Invoke(natRuleResult);

        return natRuleResult;
    }

    private Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule CreateNatRule()
    {
        var natRuleResult = new Humidifier.EC2.TransitGatewayAttachmentNatConfigurationTypes.NatRule();

        return natRuleResult;
    }

} // End Of Class

public static class InnerTransitGatewayAttachmentNatConfigurationNatRuleFactoryExtensions
{
}
