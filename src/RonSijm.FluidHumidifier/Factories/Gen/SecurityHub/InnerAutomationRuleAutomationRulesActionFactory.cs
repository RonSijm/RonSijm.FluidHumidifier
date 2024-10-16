// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerAutomationRuleAutomationRulesActionFactory(Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction>
{

    internal InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory FindingFieldsUpdateFactory { get; set; }

    protected override Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction Create()
    {
        var automationRulesActionResult = CreateAutomationRulesAction();
        factoryAction?.Invoke(automationRulesActionResult);

        return automationRulesActionResult;
    }

    private Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction CreateAutomationRulesAction()
    {
        var automationRulesActionResult = new Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction();

        return automationRulesActionResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction result)
    {
        base.CreateChildren(result);

        result.FindingFieldsUpdate ??= FindingFieldsUpdateFactory?.Build();
    }

} // End Of Class

public static class InnerAutomationRuleAutomationRulesActionFactoryExtensions
{
    public static CombinedResult<InnerAutomationRuleAutomationRulesActionFactory, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate(this InnerAutomationRuleAutomationRulesActionFactory parentFactory, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null)
    {
        parentFactory.FindingFieldsUpdateFactory = new InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FindingFieldsUpdateFactory);
    }

    public static CombinedResult<InnerAutomationRuleAutomationRulesActionFactory, T1, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1>(this CombinedResult<InnerAutomationRuleAutomationRulesActionFactory, T1> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutomationRuleAutomationRulesActionFactory, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1>(this CombinedResult<T1, InnerAutomationRuleAutomationRulesActionFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAutomationRuleAutomationRulesActionFactory, T1, T2, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2>(this CombinedResult<InnerAutomationRuleAutomationRulesActionFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutomationRuleAutomationRulesActionFactory, T2, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2>(this CombinedResult<T1, InnerAutomationRuleAutomationRulesActionFactory, T2> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAutomationRuleAutomationRulesActionFactory, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2>(this CombinedResult<T1, T2, InnerAutomationRuleAutomationRulesActionFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAutomationRuleAutomationRulesActionFactory, T1, T2, T3, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2, T3>(this CombinedResult<InnerAutomationRuleAutomationRulesActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutomationRuleAutomationRulesActionFactory, T2, T3, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2, T3>(this CombinedResult<T1, InnerAutomationRuleAutomationRulesActionFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAutomationRuleAutomationRulesActionFactory, T3, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutomationRuleAutomationRulesActionFactory, T3> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAutomationRuleAutomationRulesActionFactory, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutomationRuleAutomationRulesActionFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAutomationRuleAutomationRulesActionFactory, T1, T2, T3, T4, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2, T3, T4>(this CombinedResult<InnerAutomationRuleAutomationRulesActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutomationRuleAutomationRulesActionFactory, T2, T3, T4, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutomationRuleAutomationRulesActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAutomationRuleAutomationRulesActionFactory, T3, T4, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutomationRuleAutomationRulesActionFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAutomationRuleAutomationRulesActionFactory, T4, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutomationRuleAutomationRulesActionFactory, T4> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAutomationRuleAutomationRulesActionFactory, InnerAutomationRuleAutomationRulesFindingFieldsUpdateFactory> WithFindingFieldsUpdate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutomationRuleAutomationRulesActionFactory> combinedResult, Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingFieldsUpdate(combinedResult.T5, subFactoryAction));
}
