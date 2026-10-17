// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class TemplateFactory(string resourceName = null, Action<Humidifier.Cases.Template> factoryAction = null) : ResourceFactory<Humidifier.Cases.Template>(resourceName)
{

    internal List<InnerTemplateRequiredFieldFactory> RequiredFieldsFactories { get; set; } = [];

    internal List<InnerTemplateTemplateRuleFactory> RulesFactories { get; set; } = [];

    internal InnerTemplateLayoutConfigurationFactory LayoutConfigurationFactory { get; set; }

    protected override Humidifier.Cases.Template Create()
    {
        var templateResult = CreateTemplate();
        factoryAction?.Invoke(templateResult);

        return templateResult;
    }

    private Humidifier.Cases.Template CreateTemplate()
    {
        var templateResult = new Humidifier.Cases.Template
        {
            GivenName = InputResourceName,
        };

        return templateResult;
    }
    public override void CreateChildren(Humidifier.Cases.Template result)
    {
        base.CreateChildren(result);

        result.RequiredFields = RequiredFieldsFactories.Any() ? RequiredFieldsFactories.Select(x => x.Build()).ToList() : null;
        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
        result.LayoutConfiguration ??= LayoutConfigurationFactory?.Build();
    }

} // End Of Class

public static class TemplateFactoryExtensions
{
    public static CombinedResult<TemplateFactory, InnerTemplateRequiredFieldFactory> WithRequiredFields(this TemplateFactory parentFactory, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null)
    {
        var factory = new InnerTemplateRequiredFieldFactory(subFactoryAction);
        parentFactory.RequiredFieldsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TemplateFactory, InnerTemplateTemplateRuleFactory> WithRules(this TemplateFactory parentFactory, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null)
    {
        var factory = new InnerTemplateTemplateRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TemplateFactory, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration(this TemplateFactory parentFactory, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null)
    {
        parentFactory.LayoutConfigurationFactory = new InnerTemplateLayoutConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LayoutConfigurationFactory);
    }

    public static CombinedResult<TemplateFactory, T1, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1>(this CombinedResult<TemplateFactory, T1> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, WithRequiredFields(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1>(this CombinedResult<T1, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, WithRequiredFields(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2>(this CombinedResult<TemplateFactory, T1, T2> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2>(this CombinedResult<T1, TemplateFactory, T2> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2>(this CombinedResult<T1, T2, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, T3, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2, T3>(this CombinedResult<TemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, T3, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2, T3>(this CombinedResult<T1, TemplateFactory, T2, T3> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, T3, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2, T3>(this CombinedResult<T1, T2, TemplateFactory, T3> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TemplateFactory, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2, T3>(this CombinedResult<T1, T2, T3, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, T3, T4, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2, T3, T4>(this CombinedResult<TemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, T3, T4, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2, T3, T4>(this CombinedResult<T1, TemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, T3, T4, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, TemplateFactory, T3, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TemplateFactory, T4, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TemplateFactory, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TemplateFactory, InnerTemplateRequiredFieldFactory> WithRequiredFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.RequiredField> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequiredFields(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, InnerTemplateTemplateRuleFactory> WithRules<T1>(this CombinedResult<TemplateFactory, T1> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, InnerTemplateTemplateRuleFactory> WithRules<T1>(this CombinedResult<T1, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, InnerTemplateTemplateRuleFactory> WithRules<T1, T2>(this CombinedResult<TemplateFactory, T1, T2> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, InnerTemplateTemplateRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, TemplateFactory, T2> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, InnerTemplateTemplateRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, T3, InnerTemplateTemplateRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<TemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, T3, InnerTemplateTemplateRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, TemplateFactory, T2, T3> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, T3, InnerTemplateTemplateRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, TemplateFactory, T3> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TemplateFactory, InnerTemplateTemplateRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, T3, T4, InnerTemplateTemplateRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<TemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, T3, T4, InnerTemplateTemplateRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, TemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, T3, T4, InnerTemplateTemplateRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, TemplateFactory, T3, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TemplateFactory, T4, InnerTemplateTemplateRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TemplateFactory, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TemplateFactory, InnerTemplateTemplateRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.TemplateRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1>(this CombinedResult<TemplateFactory, T1> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1>(this CombinedResult<T1, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2>(this CombinedResult<TemplateFactory, T1, T2> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2>(this CombinedResult<T1, TemplateFactory, T2> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2>(this CombinedResult<T1, T2, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, T3, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2, T3>(this CombinedResult<TemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, T3, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2, T3>(this CombinedResult<T1, TemplateFactory, T2, T3> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, T3, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, TemplateFactory, T3> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TemplateFactory, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TemplateFactory, T1, T2, T3, T4, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2, T3, T4>(this CombinedResult<TemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TemplateFactory, T2, T3, T4, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, TemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TemplateFactory, T3, T4, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, TemplateFactory, T3, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TemplateFactory, T4, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TemplateFactory, T4> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TemplateFactory, InnerTemplateLayoutConfigurationFactory> WithLayoutConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TemplateFactory> combinedResult, Action<Humidifier.Cases.TemplateTypes.LayoutConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLayoutConfiguration(combinedResult.T5, subFactoryAction).T2);
}
