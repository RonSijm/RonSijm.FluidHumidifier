// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class InnerTemplateAssociatedRuleFactory(Action<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule> factoryAction = null) : SubResourceFactory<Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule>
{

    protected override Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule Create()
    {
        var associatedRuleResult = CreateAssociatedRule();
        factoryAction?.Invoke(associatedRuleResult);

        return associatedRuleResult;
    }

    private Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule CreateAssociatedRule()
    {
        var associatedRuleResult = new Humidifier.NetworkSecurityManager.TemplateTypes.AssociatedRule();

        return associatedRuleResult;
    }

} // End Of Class

public static class InnerTemplateAssociatedRuleFactoryExtensions
{
}
