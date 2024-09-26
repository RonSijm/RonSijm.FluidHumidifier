// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupVisibilityConfigFactory(Action<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig Create()
    {
        var visibilityConfigResult = CreateVisibilityConfig();
        factoryAction?.Invoke(visibilityConfigResult);

        return visibilityConfigResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig CreateVisibilityConfig()
    {
        var visibilityConfigResult = new Humidifier.WAFv2.RuleGroupTypes.VisibilityConfig();

        return visibilityConfigResult;
    }

} // End Of Class

public static class InnerRuleGroupVisibilityConfigFactoryExtensions
{
}
