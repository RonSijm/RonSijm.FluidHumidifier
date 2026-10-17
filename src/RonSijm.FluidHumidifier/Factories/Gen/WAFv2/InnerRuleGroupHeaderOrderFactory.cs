// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupHeaderOrderFactory(Action<Humidifier.WAFv2.RuleGroupTypes.HeaderOrder> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.HeaderOrder>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.HeaderOrder Create()
    {
        var headerOrderResult = CreateHeaderOrder();
        factoryAction?.Invoke(headerOrderResult);

        return headerOrderResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.HeaderOrder CreateHeaderOrder()
    {
        var headerOrderResult = new Humidifier.WAFv2.RuleGroupTypes.HeaderOrder();

        return headerOrderResult;
    }

} // End Of Class

public static class InnerRuleGroupHeaderOrderFactoryExtensions
{
}
