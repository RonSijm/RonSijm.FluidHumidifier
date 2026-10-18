// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ComputeOptimizer;

public class InnerAutomationRuleCriteriaFactory(Action<Humidifier.ComputeOptimizer.AutomationRuleTypes.Criteria> factoryAction = null) : SubResourceFactory<Humidifier.ComputeOptimizer.AutomationRuleTypes.Criteria>
{

    protected override Humidifier.ComputeOptimizer.AutomationRuleTypes.Criteria Create()
    {
        var criteriaResult = CreateCriteria();
        factoryAction?.Invoke(criteriaResult);

        return criteriaResult;
    }

    private Humidifier.ComputeOptimizer.AutomationRuleTypes.Criteria CreateCriteria()
    {
        var criteriaResult = new Humidifier.ComputeOptimizer.AutomationRuleTypes.Criteria();

        return criteriaResult;
    }

} // End Of Class

public static class InnerAutomationRuleCriteriaFactoryExtensions
{
}
