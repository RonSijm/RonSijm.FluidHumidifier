// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerRuleSetRuleFactory(Action<Humidifier.SES.MailManagerRuleSetTypes.Rule> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerRuleSetTypes.Rule>
{

    protected override Humidifier.SES.MailManagerRuleSetTypes.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.SES.MailManagerRuleSetTypes.Rule CreateRule()
    {
        var ruleResult = new Humidifier.SES.MailManagerRuleSetTypes.Rule();

        return ruleResult;
    }

} // End Of Class

public static class InnerMailManagerRuleSetRuleFactoryExtensions
{
}
