// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupUriFragmentFactory(Action<Humidifier.WAFv2.RuleGroupTypes.UriFragment> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.UriFragment>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.UriFragment Create()
    {
        var uriFragmentResult = CreateUriFragment();
        factoryAction?.Invoke(uriFragmentResult);

        return uriFragmentResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.UriFragment CreateUriFragment()
    {
        var uriFragmentResult = new Humidifier.WAFv2.RuleGroupTypes.UriFragment();

        return uriFragmentResult;
    }

} // End Of Class

public static class InnerRuleGroupUriFragmentFactoryExtensions
{
}
