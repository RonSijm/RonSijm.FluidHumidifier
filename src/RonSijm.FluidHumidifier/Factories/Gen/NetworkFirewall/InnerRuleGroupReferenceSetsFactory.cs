// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerRuleGroupReferenceSetsFactory(Action<Humidifier.NetworkFirewall.RuleGroupTypes.ReferenceSets> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.RuleGroupTypes.ReferenceSets>
{

    protected override Humidifier.NetworkFirewall.RuleGroupTypes.ReferenceSets Create()
    {
        var referenceSetsResult = CreateReferenceSets();
        factoryAction?.Invoke(referenceSetsResult);

        return referenceSetsResult;
    }

    private Humidifier.NetworkFirewall.RuleGroupTypes.ReferenceSets CreateReferenceSets()
    {
        var referenceSetsResult = new Humidifier.NetworkFirewall.RuleGroupTypes.ReferenceSets();

        return referenceSetsResult;
    }

} // End Of Class

public static class InnerRuleGroupReferenceSetsFactoryExtensions
{
}
