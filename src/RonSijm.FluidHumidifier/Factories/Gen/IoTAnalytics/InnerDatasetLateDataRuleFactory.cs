// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetLateDataRuleFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRule> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.LateDataRule>
{

    internal InnerDatasetLateDataRuleConfigurationFactory RuleConfigurationFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatasetTypes.LateDataRule Create()
    {
        var lateDataRuleResult = CreateLateDataRule();
        factoryAction?.Invoke(lateDataRuleResult);

        return lateDataRuleResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.LateDataRule CreateLateDataRule()
    {
        var lateDataRuleResult = new Humidifier.IoTAnalytics.DatasetTypes.LateDataRule();

        return lateDataRuleResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatasetTypes.LateDataRule result)
    {
        base.CreateChildren(result);

        result.RuleConfiguration ??= RuleConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetLateDataRuleFactoryExtensions
{
    public static CombinedResult<InnerDatasetLateDataRuleFactory, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration(this InnerDatasetLateDataRuleFactory parentFactory, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null)
    {
        parentFactory.RuleConfigurationFactory = new InnerDatasetLateDataRuleConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleConfigurationFactory);
    }

    public static CombinedResult<InnerDatasetLateDataRuleFactory, T1, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1>(this CombinedResult<InnerDatasetLateDataRuleFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetLateDataRuleFactory, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1>(this CombinedResult<T1, InnerDatasetLateDataRuleFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetLateDataRuleFactory, T1, T2, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2>(this CombinedResult<InnerDatasetLateDataRuleFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetLateDataRuleFactory, T2, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2>(this CombinedResult<T1, InnerDatasetLateDataRuleFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetLateDataRuleFactory, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDatasetLateDataRuleFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetLateDataRuleFactory, T1, T2, T3, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2, T3>(this CombinedResult<InnerDatasetLateDataRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetLateDataRuleFactory, T2, T3, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDatasetLateDataRuleFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetLateDataRuleFactory, T3, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetLateDataRuleFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetLateDataRuleFactory, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetLateDataRuleFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetLateDataRuleFactory, T1, T2, T3, T4, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDatasetLateDataRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetLateDataRuleFactory, T2, T3, T4, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetLateDataRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetLateDataRuleFactory, T3, T4, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetLateDataRuleFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetLateDataRuleFactory, T4, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetLateDataRuleFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetLateDataRuleFactory, InnerDatasetLateDataRuleConfigurationFactory> WithRuleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetLateDataRuleFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfiguration(combinedResult.T5, subFactoryAction));
}
