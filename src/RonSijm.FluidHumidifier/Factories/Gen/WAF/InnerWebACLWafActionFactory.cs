// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class InnerWebACLWafActionFactory(Action<Humidifier.WAF.WebACLTypes.WafAction> factoryAction = null) : SubResourceFactory<Humidifier.WAF.WebACLTypes.WafAction>
{

    protected override Humidifier.WAF.WebACLTypes.WafAction Create()
    {
        var wafActionResult = CreateWafAction();
        factoryAction?.Invoke(wafActionResult);

        return wafActionResult;
    }

    private Humidifier.WAF.WebACLTypes.WafAction CreateWafAction()
    {
        var wafActionResult = new Humidifier.WAF.WebACLTypes.WafAction();

        return wafActionResult;
    }

} // End Of Class

public static class InnerWebACLWafActionFactoryExtensions
{
}
