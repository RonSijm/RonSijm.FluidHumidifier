// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerCaseRuleRequiredCaseRuleFactory(Action<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule> factoryAction = null) : SubResourceFactory<Humidifier.Cases.CaseRuleTypes.RequiredCaseRule>
{

    protected override Humidifier.Cases.CaseRuleTypes.RequiredCaseRule Create()
    {
        var requiredCaseRuleResult = CreateRequiredCaseRule();
        factoryAction?.Invoke(requiredCaseRuleResult);

        return requiredCaseRuleResult;
    }

    private Humidifier.Cases.CaseRuleTypes.RequiredCaseRule CreateRequiredCaseRule()
    {
        var requiredCaseRuleResult = new Humidifier.Cases.CaseRuleTypes.RequiredCaseRule();

        return requiredCaseRuleResult;
    }

} // End Of Class

public static class InnerCaseRuleRequiredCaseRuleFactoryExtensions
{
}
