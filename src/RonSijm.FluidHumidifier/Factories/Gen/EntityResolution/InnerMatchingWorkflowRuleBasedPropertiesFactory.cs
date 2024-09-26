// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowRuleBasedPropertiesFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.RuleBasedProperties> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.RuleBasedProperties>
{

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.RuleBasedProperties Create()
    {
        var ruleBasedPropertiesResult = CreateRuleBasedProperties();
        factoryAction?.Invoke(ruleBasedPropertiesResult);

        return ruleBasedPropertiesResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.RuleBasedProperties CreateRuleBasedProperties()
    {
        var ruleBasedPropertiesResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.RuleBasedProperties();

        return ruleBasedPropertiesResult;
    }

} // End Of Class

public static class InnerMatchingWorkflowRuleBasedPropertiesFactoryExtensions
{
}
