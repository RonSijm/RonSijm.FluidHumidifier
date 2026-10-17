// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class InnerPolicyAssociatedTemplateAndRuleFactory(Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> factoryAction = null) : SubResourceFactory<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule>
{

    protected override Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule Create()
    {
        var associatedTemplateAndRuleResult = CreateAssociatedTemplateAndRule();
        factoryAction?.Invoke(associatedTemplateAndRuleResult);

        return associatedTemplateAndRuleResult;
    }

    private Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule CreateAssociatedTemplateAndRule()
    {
        var associatedTemplateAndRuleResult = new Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule();

        return associatedTemplateAndRuleResult;
    }

} // End Of Class

public static class InnerPolicyAssociatedTemplateAndRuleFactoryExtensions
{
}
