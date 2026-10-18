// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupSingleHeaderFactory(Action<Humidifier.WAFv2.RuleGroupTypes.SingleHeader> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.SingleHeader>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.SingleHeader Create()
    {
        var singleHeaderResult = CreateSingleHeader();
        factoryAction?.Invoke(singleHeaderResult);

        return singleHeaderResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.SingleHeader CreateSingleHeader()
    {
        var singleHeaderResult = new Humidifier.WAFv2.RuleGroupTypes.SingleHeader();

        return singleHeaderResult;
    }

} // End Of Class

public static class InnerRuleGroupSingleHeaderFactoryExtensions
{
}
