// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupSingleQueryArgumentFactory(Action<Humidifier.WAFv2.RuleGroupTypes.SingleQueryArgument> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.SingleQueryArgument>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.SingleQueryArgument Create()
    {
        var singleQueryArgumentResult = CreateSingleQueryArgument();
        factoryAction?.Invoke(singleQueryArgumentResult);

        return singleQueryArgumentResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.SingleQueryArgument CreateSingleQueryArgument()
    {
        var singleQueryArgumentResult = new Humidifier.WAFv2.RuleGroupTypes.SingleQueryArgument();

        return singleQueryArgumentResult;
    }

} // End Of Class

public static class InnerRuleGroupSingleQueryArgumentFactoryExtensions
{
}
