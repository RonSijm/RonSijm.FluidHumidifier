// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class ConfigRuleFactory(string resourceName = null, Action<Humidifier.Config.ConfigRule> factoryAction = null) : ResourceFactory<Humidifier.Config.ConfigRule>(resourceName)
{

    internal List<InnerConfigRuleEvaluationModeConfigurationFactory> EvaluationModesFactories { get; set; } = [];

    internal InnerConfigRuleScopeFactory ScopeFactory { get; set; }

    internal InnerConfigRuleComplianceFactory ComplianceFactory { get; set; }

    internal InnerConfigRuleSourceFactory SourceFactory { get; set; }

    protected override Humidifier.Config.ConfigRule Create()
    {
        var configRuleResult = CreateConfigRule();
        factoryAction?.Invoke(configRuleResult);

        return configRuleResult;
    }

    private Humidifier.Config.ConfigRule CreateConfigRule()
    {
        var configRuleResult = new Humidifier.Config.ConfigRule
        {
            GivenName = InputResourceName,
        };

        return configRuleResult;
    }
    public override void CreateChildren(Humidifier.Config.ConfigRule result)
    {
        base.CreateChildren(result);

        result.EvaluationModes = EvaluationModesFactories.Any() ? EvaluationModesFactories.Select(x => x.Build()).ToList() : null;
        result.Scope ??= ScopeFactory?.Build();
        result.Compliance ??= ComplianceFactory?.Build();
        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class ConfigRuleFactoryExtensions
{
    public static CombinedResult<ConfigRuleFactory, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes(this ConfigRuleFactory parentFactory, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null)
    {
        var factory = new InnerConfigRuleEvaluationModeConfigurationFactory(subFactoryAction);
        parentFactory.EvaluationModesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConfigRuleFactory, InnerConfigRuleScopeFactory> WithScope(this ConfigRuleFactory parentFactory, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null)
    {
        parentFactory.ScopeFactory = new InnerConfigRuleScopeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScopeFactory);
    }

    public static CombinedResult<ConfigRuleFactory, InnerConfigRuleComplianceFactory> WithCompliance(this ConfigRuleFactory parentFactory, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null)
    {
        parentFactory.ComplianceFactory = new InnerConfigRuleComplianceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComplianceFactory);
    }

    public static CombinedResult<ConfigRuleFactory, InnerConfigRuleSourceFactory> WithSource(this ConfigRuleFactory parentFactory, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerConfigRuleSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<ConfigRuleFactory, T1, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1>(this CombinedResult<ConfigRuleFactory, T1> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEvaluationModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1>(this CombinedResult<T1, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEvaluationModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2>(this CombinedResult<ConfigRuleFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2>(this CombinedResult<T1, ConfigRuleFactory, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2>(this CombinedResult<T1, T2, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, T3, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2, T3>(this CombinedResult<ConfigRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, T3, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2, T3>(this CombinedResult<T1, ConfigRuleFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, T3, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2, T3>(this CombinedResult<T1, T2, ConfigRuleFactory, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigRuleFactory, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, T3, T4, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2, T3, T4>(this CombinedResult<ConfigRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, T3, T4, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2, T3, T4>(this CombinedResult<T1, ConfigRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, T3, T4, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigRuleFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigRuleFactory, T4, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigRuleFactory, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigRuleFactory, InnerConfigRuleEvaluationModeConfigurationFactory> WithEvaluationModes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluationModes(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, InnerConfigRuleScopeFactory> WithScope<T1>(this CombinedResult<ConfigRuleFactory, T1> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, WithScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, InnerConfigRuleScopeFactory> WithScope<T1>(this CombinedResult<T1, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, WithScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, InnerConfigRuleScopeFactory> WithScope<T1, T2>(this CombinedResult<ConfigRuleFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, InnerConfigRuleScopeFactory> WithScope<T1, T2>(this CombinedResult<T1, ConfigRuleFactory, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, InnerConfigRuleScopeFactory> WithScope<T1, T2>(this CombinedResult<T1, T2, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, T3, InnerConfigRuleScopeFactory> WithScope<T1, T2, T3>(this CombinedResult<ConfigRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, T3, InnerConfigRuleScopeFactory> WithScope<T1, T2, T3>(this CombinedResult<T1, ConfigRuleFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, T3, InnerConfigRuleScopeFactory> WithScope<T1, T2, T3>(this CombinedResult<T1, T2, ConfigRuleFactory, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigRuleFactory, InnerConfigRuleScopeFactory> WithScope<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, T3, T4, InnerConfigRuleScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<ConfigRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, T3, T4, InnerConfigRuleScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<T1, ConfigRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, T3, T4, InnerConfigRuleScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigRuleFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigRuleFactory, T4, InnerConfigRuleScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigRuleFactory, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigRuleFactory, InnerConfigRuleScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, InnerConfigRuleComplianceFactory> WithCompliance<T1>(this CombinedResult<ConfigRuleFactory, T1> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, WithCompliance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, InnerConfigRuleComplianceFactory> WithCompliance<T1>(this CombinedResult<T1, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, WithCompliance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2>(this CombinedResult<ConfigRuleFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2>(this CombinedResult<T1, ConfigRuleFactory, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2>(this CombinedResult<T1, T2, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, T3, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2, T3>(this CombinedResult<ConfigRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, T3, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2, T3>(this CombinedResult<T1, ConfigRuleFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, T3, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2, T3>(this CombinedResult<T1, T2, ConfigRuleFactory, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigRuleFactory, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, T3, T4, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2, T3, T4>(this CombinedResult<ConfigRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, T3, T4, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2, T3, T4>(this CombinedResult<T1, ConfigRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, T3, T4, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigRuleFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigRuleFactory, T4, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigRuleFactory, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigRuleFactory, InnerConfigRuleComplianceFactory> WithCompliance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Compliance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCompliance(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, InnerConfigRuleSourceFactory> WithSource<T1>(this CombinedResult<ConfigRuleFactory, T1> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, InnerConfigRuleSourceFactory> WithSource<T1>(this CombinedResult<T1, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, InnerConfigRuleSourceFactory> WithSource<T1, T2>(this CombinedResult<ConfigRuleFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, InnerConfigRuleSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, ConfigRuleFactory, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, InnerConfigRuleSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, T3, InnerConfigRuleSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<ConfigRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, T3, InnerConfigRuleSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, ConfigRuleFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, T3, InnerConfigRuleSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, ConfigRuleFactory, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigRuleFactory, InnerConfigRuleSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigRuleFactory, T1, T2, T3, T4, InnerConfigRuleSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<ConfigRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigRuleFactory, T2, T3, T4, InnerConfigRuleSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, ConfigRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigRuleFactory, T3, T4, InnerConfigRuleSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigRuleFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigRuleFactory, T4, InnerConfigRuleSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigRuleFactory, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigRuleFactory, InnerConfigRuleSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigRuleFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction));
}
