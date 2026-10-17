// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class InnerReplicationConfigurationTemplatePITPolicyRuleFactory(Action<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> factoryAction = null) : SubResourceFactory<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule>
{

    protected override Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule Create()
    {
        var pITPolicyRuleResult = CreatePITPolicyRule();
        factoryAction?.Invoke(pITPolicyRuleResult);

        return pITPolicyRuleResult;
    }

    private Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule CreatePITPolicyRule()
    {
        var pITPolicyRuleResult = new Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule();

        return pITPolicyRuleResult;
    }

} // End Of Class

public static class InnerReplicationConfigurationTemplatePITPolicyRuleFactoryExtensions
{
}
