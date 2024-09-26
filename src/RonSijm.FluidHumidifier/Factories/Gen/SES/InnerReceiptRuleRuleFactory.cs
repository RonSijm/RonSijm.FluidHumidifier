// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerReceiptRuleRuleFactory(Action<Humidifier.SES.ReceiptRuleTypes.Rule> factoryAction = null) : SubResourceFactory<Humidifier.SES.ReceiptRuleTypes.Rule>
{

    protected override Humidifier.SES.ReceiptRuleTypes.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.SES.ReceiptRuleTypes.Rule CreateRule()
    {
        var ruleResult = new Humidifier.SES.ReceiptRuleTypes.Rule();

        return ruleResult;
    }

} // End Of Class

public static class InnerReceiptRuleRuleFactoryExtensions
{
}
