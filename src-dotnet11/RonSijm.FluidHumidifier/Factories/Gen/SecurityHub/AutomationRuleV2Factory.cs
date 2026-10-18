// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class AutomationRuleV2Factory(string resourceName = null, Action<Humidifier.SecurityHub.AutomationRuleV2> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.AutomationRuleV2>(resourceName)
{

    internal List<InnerAutomationRuleV2AutomationRulesActionV2Factory> ActionsFactories { get; set; } = [];

    internal InnerAutomationRuleV2CriteriaFactory CriteriaFactory { get; set; }

    protected override Humidifier.SecurityHub.AutomationRuleV2 Create()
    {
        var automationRuleV2Result = CreateAutomationRuleV2();
        factoryAction?.Invoke(automationRuleV2Result);

        return automationRuleV2Result;
    }

    private Humidifier.SecurityHub.AutomationRuleV2 CreateAutomationRuleV2()
    {
        var automationRuleV2Result = new Humidifier.SecurityHub.AutomationRuleV2
        {
            GivenName = InputResourceName,
        };

        return automationRuleV2Result;
    }
    public override void CreateChildren(Humidifier.SecurityHub.AutomationRuleV2 result)
    {
        base.CreateChildren(result);

        result.Actions = ActionsFactories.Any() ? ActionsFactories.Select(x => x.Build()).ToList() : null;
        result.Criteria ??= CriteriaFactory?.Build();
    }

} // End Of Class

public static class AutomationRuleV2FactoryExtensions
{
    public static CombinedResult<AutomationRuleV2Factory, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions(this AutomationRuleV2Factory parentFactory, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null)
    {
        var factory = new InnerAutomationRuleV2AutomationRulesActionV2Factory(subFactoryAction);
        parentFactory.ActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AutomationRuleV2Factory, InnerAutomationRuleV2CriteriaFactory> WithCriteria(this AutomationRuleV2Factory parentFactory, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null)
    {
        parentFactory.CriteriaFactory = new InnerAutomationRuleV2CriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CriteriaFactory);
    }

    public static CombinedResult<AutomationRuleV2Factory, T1, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1>(this CombinedResult<AutomationRuleV2Factory, T1> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomationRuleV2Factory, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1>(this CombinedResult<T1, AutomationRuleV2Factory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AutomationRuleV2Factory, T1, T2, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2>(this CombinedResult<AutomationRuleV2Factory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomationRuleV2Factory, T2, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2>(this CombinedResult<T1, AutomationRuleV2Factory, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AutomationRuleV2Factory, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2>(this CombinedResult<T1, T2, AutomationRuleV2Factory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AutomationRuleV2Factory, T1, T2, T3, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2, T3>(this CombinedResult<AutomationRuleV2Factory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomationRuleV2Factory, T2, T3, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2, T3>(this CombinedResult<T1, AutomationRuleV2Factory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AutomationRuleV2Factory, T3, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, AutomationRuleV2Factory, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AutomationRuleV2Factory, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, AutomationRuleV2Factory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AutomationRuleV2Factory, T1, T2, T3, T4, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2, T3, T4>(this CombinedResult<AutomationRuleV2Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomationRuleV2Factory, T2, T3, T4, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, AutomationRuleV2Factory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AutomationRuleV2Factory, T3, T4, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, AutomationRuleV2Factory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AutomationRuleV2Factory, T4, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AutomationRuleV2Factory, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AutomationRuleV2Factory, InnerAutomationRuleV2AutomationRulesActionV2Factory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AutomationRuleV2Factory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AutomationRuleV2Factory, T1, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1>(this CombinedResult<AutomationRuleV2Factory, T1> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomationRuleV2Factory, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1>(this CombinedResult<T1, AutomationRuleV2Factory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AutomationRuleV2Factory, T1, T2, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2>(this CombinedResult<AutomationRuleV2Factory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomationRuleV2Factory, T2, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2>(this CombinedResult<T1, AutomationRuleV2Factory, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AutomationRuleV2Factory, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2>(this CombinedResult<T1, T2, AutomationRuleV2Factory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AutomationRuleV2Factory, T1, T2, T3, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<AutomationRuleV2Factory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomationRuleV2Factory, T2, T3, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, AutomationRuleV2Factory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AutomationRuleV2Factory, T3, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, T2, AutomationRuleV2Factory, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AutomationRuleV2Factory, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, AutomationRuleV2Factory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AutomationRuleV2Factory, T1, T2, T3, T4, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<AutomationRuleV2Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AutomationRuleV2Factory, T2, T3, T4, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, AutomationRuleV2Factory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AutomationRuleV2Factory, T3, T4, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, AutomationRuleV2Factory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AutomationRuleV2Factory, T4, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AutomationRuleV2Factory, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AutomationRuleV2Factory, InnerAutomationRuleV2CriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AutomationRuleV2Factory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T5, subFactoryAction).T2);
}
