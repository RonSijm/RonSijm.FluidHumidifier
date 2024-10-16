// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetLateDataRuleConfigurationFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration>
{

    internal InnerDatasetDeltaTimeSessionWindowConfigurationFactory DeltaTimeSessionWindowConfigurationFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration Create()
    {
        var lateDataRuleConfigurationResult = CreateLateDataRuleConfiguration();
        factoryAction?.Invoke(lateDataRuleConfigurationResult);

        return lateDataRuleConfigurationResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration CreateLateDataRuleConfiguration()
    {
        var lateDataRuleConfigurationResult = new Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration();

        return lateDataRuleConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatasetTypes.LateDataRuleConfiguration result)
    {
        base.CreateChildren(result);

        result.DeltaTimeSessionWindowConfiguration ??= DeltaTimeSessionWindowConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetLateDataRuleConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDatasetLateDataRuleConfigurationFactory, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration(this InnerDatasetLateDataRuleConfigurationFactory parentFactory, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null)
    {
        parentFactory.DeltaTimeSessionWindowConfigurationFactory = new InnerDatasetDeltaTimeSessionWindowConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeltaTimeSessionWindowConfigurationFactory);
    }

    public static CombinedResult<InnerDatasetLateDataRuleConfigurationFactory, T1, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1>(this CombinedResult<InnerDatasetLateDataRuleConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetLateDataRuleConfigurationFactory, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1>(this CombinedResult<T1, InnerDatasetLateDataRuleConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetLateDataRuleConfigurationFactory, T1, T2, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2>(this CombinedResult<InnerDatasetLateDataRuleConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetLateDataRuleConfigurationFactory, T2, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2>(this CombinedResult<T1, InnerDatasetLateDataRuleConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetLateDataRuleConfigurationFactory, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDatasetLateDataRuleConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetLateDataRuleConfigurationFactory, T1, T2, T3, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2, T3>(this CombinedResult<InnerDatasetLateDataRuleConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetLateDataRuleConfigurationFactory, T2, T3, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDatasetLateDataRuleConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetLateDataRuleConfigurationFactory, T3, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetLateDataRuleConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetLateDataRuleConfigurationFactory, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetLateDataRuleConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetLateDataRuleConfigurationFactory, T1, T2, T3, T4, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDatasetLateDataRuleConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetLateDataRuleConfigurationFactory, T2, T3, T4, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetLateDataRuleConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetLateDataRuleConfigurationFactory, T3, T4, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetLateDataRuleConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetLateDataRuleConfigurationFactory, T4, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetLateDataRuleConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetLateDataRuleConfigurationFactory, InnerDatasetDeltaTimeSessionWindowConfigurationFactory> WithDeltaTimeSessionWindowConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetLateDataRuleConfigurationFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.DeltaTimeSessionWindowConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeltaTimeSessionWindowConfiguration(combinedResult.T5, subFactoryAction));
}
