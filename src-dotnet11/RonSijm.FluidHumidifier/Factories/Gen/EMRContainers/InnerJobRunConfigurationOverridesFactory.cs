// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobRunConfigurationOverridesFactory(Action<Humidifier.EMRContainers.JobRunTypes.ConfigurationOverrides> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobRunTypes.ConfigurationOverrides>
{

    internal InnerJobRunMonitoringConfigurationFactory MonitoringConfigurationFactory { get; set; }

    protected override Humidifier.EMRContainers.JobRunTypes.ConfigurationOverrides Create()
    {
        var configurationOverridesResult = CreateConfigurationOverrides();
        factoryAction?.Invoke(configurationOverridesResult);

        return configurationOverridesResult;
    }

    private Humidifier.EMRContainers.JobRunTypes.ConfigurationOverrides CreateConfigurationOverrides()
    {
        var configurationOverridesResult = new Humidifier.EMRContainers.JobRunTypes.ConfigurationOverrides();

        return configurationOverridesResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.JobRunTypes.ConfigurationOverrides result)
    {
        base.CreateChildren(result);

        result.MonitoringConfiguration ??= MonitoringConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerJobRunConfigurationOverridesFactoryExtensions
{
    public static CombinedResult<InnerJobRunConfigurationOverridesFactory, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration(this InnerJobRunConfigurationOverridesFactory parentFactory, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null)
    {
        parentFactory.MonitoringConfigurationFactory = new InnerJobRunMonitoringConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MonitoringConfigurationFactory);
    }

    public static CombinedResult<InnerJobRunConfigurationOverridesFactory, T1, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1>(this CombinedResult<InnerJobRunConfigurationOverridesFactory, T1> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunConfigurationOverridesFactory, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1>(this CombinedResult<T1, InnerJobRunConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunConfigurationOverridesFactory, T1, T2, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<InnerJobRunConfigurationOverridesFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunConfigurationOverridesFactory, T2, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<T1, InnerJobRunConfigurationOverridesFactory, T2> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunConfigurationOverridesFactory, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerJobRunConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunConfigurationOverridesFactory, T1, T2, T3, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<InnerJobRunConfigurationOverridesFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunConfigurationOverridesFactory, T2, T3, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerJobRunConfigurationOverridesFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunConfigurationOverridesFactory, T3, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobRunConfigurationOverridesFactory, T3> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunConfigurationOverridesFactory, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobRunConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunConfigurationOverridesFactory, T1, T2, T3, T4, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerJobRunConfigurationOverridesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunConfigurationOverridesFactory, T2, T3, T4, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobRunConfigurationOverridesFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunConfigurationOverridesFactory, T3, T4, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobRunConfigurationOverridesFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunConfigurationOverridesFactory, T4, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobRunConfigurationOverridesFactory, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobRunConfigurationOverridesFactory, InnerJobRunMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobRunConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T5, subFactoryAction).T2);
}
