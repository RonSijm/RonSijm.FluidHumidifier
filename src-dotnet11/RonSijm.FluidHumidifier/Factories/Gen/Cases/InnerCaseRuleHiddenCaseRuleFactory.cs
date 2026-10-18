// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerCaseRuleHiddenCaseRuleFactory(Action<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule> factoryAction = null) : SubResourceFactory<Humidifier.Cases.CaseRuleTypes.HiddenCaseRule>
{

    protected override Humidifier.Cases.CaseRuleTypes.HiddenCaseRule Create()
    {
        var hiddenCaseRuleResult = CreateHiddenCaseRule();
        factoryAction?.Invoke(hiddenCaseRuleResult);

        return hiddenCaseRuleResult;
    }

    private Humidifier.Cases.CaseRuleTypes.HiddenCaseRule CreateHiddenCaseRule()
    {
        var hiddenCaseRuleResult = new Humidifier.Cases.CaseRuleTypes.HiddenCaseRule();

        return hiddenCaseRuleResult;
    }

} // End Of Class

public static class InnerCaseRuleHiddenCaseRuleFactoryExtensions
{
}
