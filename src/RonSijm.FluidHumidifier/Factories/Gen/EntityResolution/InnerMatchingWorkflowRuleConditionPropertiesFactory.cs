// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowRuleConditionPropertiesFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.RuleConditionProperties> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.RuleConditionProperties>
{

    internal InnerMatchingWorkflowMatchingConfigFactory MatchingConfigFactory { get; set; }

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.RuleConditionProperties Create()
    {
        var ruleConditionPropertiesResult = CreateRuleConditionProperties();
        factoryAction?.Invoke(ruleConditionPropertiesResult);

        return ruleConditionPropertiesResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.RuleConditionProperties CreateRuleConditionProperties()
    {
        var ruleConditionPropertiesResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.RuleConditionProperties();

        return ruleConditionPropertiesResult;
    }
    public override void CreateChildren(Humidifier.EntityResolution.MatchingWorkflowTypes.RuleConditionProperties result)
    {
        base.CreateChildren(result);

        result.MatchingConfig ??= MatchingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerMatchingWorkflowRuleConditionPropertiesFactoryExtensions
{
    public static CombinedResult<InnerMatchingWorkflowRuleConditionPropertiesFactory, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig(this InnerMatchingWorkflowRuleConditionPropertiesFactory parentFactory, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null)
    {
        parentFactory.MatchingConfigFactory = new InnerMatchingWorkflowMatchingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchingConfigFactory);
    }

    public static CombinedResult<InnerMatchingWorkflowRuleConditionPropertiesFactory, T1, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1>(this CombinedResult<InnerMatchingWorkflowRuleConditionPropertiesFactory, T1> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMatchingWorkflowRuleConditionPropertiesFactory, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1>(this CombinedResult<T1, InnerMatchingWorkflowRuleConditionPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMatchingWorkflowRuleConditionPropertiesFactory, T1, T2, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2>(this CombinedResult<InnerMatchingWorkflowRuleConditionPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMatchingWorkflowRuleConditionPropertiesFactory, T2, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2>(this CombinedResult<T1, InnerMatchingWorkflowRuleConditionPropertiesFactory, T2> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMatchingWorkflowRuleConditionPropertiesFactory, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2>(this CombinedResult<T1, T2, InnerMatchingWorkflowRuleConditionPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMatchingWorkflowRuleConditionPropertiesFactory, T1, T2, T3, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2, T3>(this CombinedResult<InnerMatchingWorkflowRuleConditionPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMatchingWorkflowRuleConditionPropertiesFactory, T2, T3, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2, T3>(this CombinedResult<T1, InnerMatchingWorkflowRuleConditionPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMatchingWorkflowRuleConditionPropertiesFactory, T3, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerMatchingWorkflowRuleConditionPropertiesFactory, T3> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMatchingWorkflowRuleConditionPropertiesFactory, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMatchingWorkflowRuleConditionPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMatchingWorkflowRuleConditionPropertiesFactory, T1, T2, T3, T4, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2, T3, T4>(this CombinedResult<InnerMatchingWorkflowRuleConditionPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMatchingWorkflowRuleConditionPropertiesFactory, T2, T3, T4, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerMatchingWorkflowRuleConditionPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMatchingWorkflowRuleConditionPropertiesFactory, T3, T4, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMatchingWorkflowRuleConditionPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMatchingWorkflowRuleConditionPropertiesFactory, T4, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMatchingWorkflowRuleConditionPropertiesFactory, T4> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMatchingWorkflowRuleConditionPropertiesFactory, InnerMatchingWorkflowMatchingConfigFactory> WithMatchingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMatchingWorkflowRuleConditionPropertiesFactory> combinedResult, Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchingConfig(combinedResult.T5, subFactoryAction).T2);
}
