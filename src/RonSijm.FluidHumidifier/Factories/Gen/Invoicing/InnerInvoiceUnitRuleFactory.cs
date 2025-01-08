// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Invoicing;

public class InnerInvoiceUnitRuleFactory(Action<Humidifier.Invoicing.InvoiceUnitTypes.Rule> factoryAction = null) : SubResourceFactory<Humidifier.Invoicing.InvoiceUnitTypes.Rule>
{

    protected override Humidifier.Invoicing.InvoiceUnitTypes.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.Invoicing.InvoiceUnitTypes.Rule CreateRule()
    {
        var ruleResult = new Humidifier.Invoicing.InvoiceUnitTypes.Rule();

        return ruleResult;
    }

} // End Of Class

public static class InnerInvoiceUnitRuleFactoryExtensions
{
}
