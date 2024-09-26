// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupImmunityTimePropertyFactory(Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty Create()
    {
        var immunityTimePropertyResult = CreateImmunityTimeProperty();
        factoryAction?.Invoke(immunityTimePropertyResult);

        return immunityTimePropertyResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty CreateImmunityTimeProperty()
    {
        var immunityTimePropertyResult = new Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty();

        return immunityTimePropertyResult;
    }

} // End Of Class

public static class InnerRuleGroupImmunityTimePropertyFactoryExtensions
{
}
