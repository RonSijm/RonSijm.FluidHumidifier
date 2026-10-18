// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerAutomationRuleV2CriteriaFactory(Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria>
{

    internal InnerAutomationRuleV2OcsfFindingFiltersFactory OcsfFindingCriteriaFactory { get; set; }

    protected override Humidifier.SecurityHub.AutomationRuleV2Types.Criteria Create()
    {
        var criteriaResult = CreateCriteria();
        factoryAction?.Invoke(criteriaResult);

        return criteriaResult;
    }

    private Humidifier.SecurityHub.AutomationRuleV2Types.Criteria CreateCriteria()
    {
        var criteriaResult = new Humidifier.SecurityHub.AutomationRuleV2Types.Criteria();

        return criteriaResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.AutomationRuleV2Types.Criteria result)
    {
        base.CreateChildren(result);

        result.OcsfFindingCriteria ??= OcsfFindingCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerAutomationRuleV2CriteriaFactoryExtensions
{
    public static CombinedResult<InnerAutomationRuleV2CriteriaFactory, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria(this InnerAutomationRuleV2CriteriaFactory parentFactory, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null)
    {
        parentFactory.OcsfFindingCriteriaFactory = new InnerAutomationRuleV2OcsfFindingFiltersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OcsfFindingCriteriaFactory);
    }

    public static CombinedResult<InnerAutomationRuleV2CriteriaFactory, T1, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1>(this CombinedResult<InnerAutomationRuleV2CriteriaFactory, T1> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutomationRuleV2CriteriaFactory, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1>(this CombinedResult<T1, InnerAutomationRuleV2CriteriaFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAutomationRuleV2CriteriaFactory, T1, T2, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2>(this CombinedResult<InnerAutomationRuleV2CriteriaFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutomationRuleV2CriteriaFactory, T2, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2>(this CombinedResult<T1, InnerAutomationRuleV2CriteriaFactory, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutomationRuleV2CriteriaFactory, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2>(this CombinedResult<T1, T2, InnerAutomationRuleV2CriteriaFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAutomationRuleV2CriteriaFactory, T1, T2, T3, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2, T3>(this CombinedResult<InnerAutomationRuleV2CriteriaFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutomationRuleV2CriteriaFactory, T2, T3, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2, T3>(this CombinedResult<T1, InnerAutomationRuleV2CriteriaFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutomationRuleV2CriteriaFactory, T3, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutomationRuleV2CriteriaFactory, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutomationRuleV2CriteriaFactory, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutomationRuleV2CriteriaFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAutomationRuleV2CriteriaFactory, T1, T2, T3, T4, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2, T3, T4>(this CombinedResult<InnerAutomationRuleV2CriteriaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutomationRuleV2CriteriaFactory, T2, T3, T4, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutomationRuleV2CriteriaFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutomationRuleV2CriteriaFactory, T3, T4, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutomationRuleV2CriteriaFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutomationRuleV2CriteriaFactory, T4, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutomationRuleV2CriteriaFactory, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAutomationRuleV2CriteriaFactory, InnerAutomationRuleV2OcsfFindingFiltersFactory> WithOcsfFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutomationRuleV2CriteriaFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOcsfFindingCriteria(combinedResult.T5, subFactoryAction).T2);
}
