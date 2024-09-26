// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerPatchBaselineRuleGroupFactory(Action<Humidifier.SSM.PatchBaselineTypes.RuleGroup> factoryAction = null) : SubResourceFactory<Humidifier.SSM.PatchBaselineTypes.RuleGroup>
{

    protected override Humidifier.SSM.PatchBaselineTypes.RuleGroup Create()
    {
        var ruleGroupResult = CreateRuleGroup();
        factoryAction?.Invoke(ruleGroupResult);

        return ruleGroupResult;
    }

    private Humidifier.SSM.PatchBaselineTypes.RuleGroup CreateRuleGroup()
    {
        var ruleGroupResult = new Humidifier.SSM.PatchBaselineTypes.RuleGroup();

        return ruleGroupResult;
    }

} // End Of Class

public static class InnerPatchBaselineRuleGroupFactoryExtensions
{
}
