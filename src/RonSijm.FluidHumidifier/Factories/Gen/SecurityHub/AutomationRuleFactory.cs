// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class AutomationRuleFactory(string resourceName = null, Action<Humidifier.SecurityHub.AutomationRule> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.AutomationRule>(resourceName)
{

    internal List<InnerAutomationRuleAutomationRulesActionFactory> ActionsFactories { get; set; } = [];

    internal InnerAutomationRuleAutomationRulesFindingFiltersFactory CriteriaFactory { get; set; }

    protected override Humidifier.SecurityHub.AutomationRule Create()
    {
        var automationRuleResult = CreateAutomationRule();
        factoryAction?.Invoke(automationRuleResult);

        return automationRuleResult;
    }

    private Humidifier.SecurityHub.AutomationRule CreateAutomationRule()
    {
        var automationRuleResult = new Humidifier.SecurityHub.AutomationRule
        {
            GivenName = InputResourceName,
        };

        return automationRuleResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.AutomationRule result)
    {
        base.CreateChildren(result);

        result.Actions = ActionsFactories.Any() ? ActionsFactories.Select(x => x.Build()).ToList() : null;
        result.Criteria ??= CriteriaFactory?.Build();
    }

} // End Of Class

public static class AutomationRuleFactoryExtensions
{
    public static CombinedResult<AutomationRuleFactory, InnerAutomationRuleAutomationRulesActionFactory> WithActions(this AutomationRuleFactory parentFactory, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null)
    {
        var factory = new InnerAutomationRuleAutomationRulesActionFactory(subFactoryAction);
        parentFactory.ActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AutomationRuleFactory, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria(this AutomationRuleFactory parentFactory, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null)
    {
        parentFactory.CriteriaFactory = new InnerAutomationRuleAutomationRulesFindingFiltersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CriteriaFactory);
    }

    public static CombinedResult<AutomationRuleFactory, T1, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1>(this CombinedResult<AutomationRuleFactory, T1> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AutomationRuleFactory, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1>(this CombinedResult<T1, AutomationRuleFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AutomationRuleFactory, T1, T2, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2>(this CombinedResult<AutomationRuleFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AutomationRuleFactory, T2, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2>(this CombinedResult<T1, AutomationRuleFactory, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AutomationRuleFactory, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2>(this CombinedResult<T1, T2, AutomationRuleFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AutomationRuleFactory, T1, T2, T3, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2, T3>(this CombinedResult<AutomationRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AutomationRuleFactory, T2, T3, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, AutomationRuleFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AutomationRuleFactory, T3, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, AutomationRuleFactory, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AutomationRuleFactory, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, AutomationRuleFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AutomationRuleFactory, T1, T2, T3, T4, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<AutomationRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AutomationRuleFactory, T2, T3, T4, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, AutomationRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AutomationRuleFactory, T3, T4, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, AutomationRuleFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AutomationRuleFactory, T4, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AutomationRuleFactory, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AutomationRuleFactory, InnerAutomationRuleAutomationRulesActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AutomationRuleFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AutomationRuleFactory, T1, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1>(this CombinedResult<AutomationRuleFactory, T1> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AutomationRuleFactory, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1>(this CombinedResult<T1, AutomationRuleFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AutomationRuleFactory, T1, T2, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2>(this CombinedResult<AutomationRuleFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AutomationRuleFactory, T2, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2>(this CombinedResult<T1, AutomationRuleFactory, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AutomationRuleFactory, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2>(this CombinedResult<T1, T2, AutomationRuleFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AutomationRuleFactory, T1, T2, T3, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2, T3>(this CombinedResult<AutomationRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AutomationRuleFactory, T2, T3, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, AutomationRuleFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AutomationRuleFactory, T3, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, T2, AutomationRuleFactory, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AutomationRuleFactory, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, AutomationRuleFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AutomationRuleFactory, T1, T2, T3, T4, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<AutomationRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AutomationRuleFactory, T2, T3, T4, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, AutomationRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AutomationRuleFactory, T3, T4, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, AutomationRuleFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AutomationRuleFactory, T4, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AutomationRuleFactory, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AutomationRuleFactory, InnerAutomationRuleAutomationRulesFindingFiltersFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AutomationRuleFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T5, subFactoryAction));
}
