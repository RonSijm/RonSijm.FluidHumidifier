// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobTemplateParametricConfigurationOverridesFactory(Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides>
{

    internal InnerJobTemplateParametricMonitoringConfigurationFactory MonitoringConfigurationFactory { get; set; }

    protected override Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides Create()
    {
        var parametricConfigurationOverridesResult = CreateParametricConfigurationOverrides();
        factoryAction?.Invoke(parametricConfigurationOverridesResult);

        return parametricConfigurationOverridesResult;
    }

    private Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides CreateParametricConfigurationOverrides()
    {
        var parametricConfigurationOverridesResult = new Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides();

        return parametricConfigurationOverridesResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides result)
    {
        base.CreateChildren(result);

        result.MonitoringConfiguration ??= MonitoringConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerJobTemplateParametricConfigurationOverridesFactoryExtensions
{
    public static CombinedResult<InnerJobTemplateParametricConfigurationOverridesFactory, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration(this InnerJobTemplateParametricConfigurationOverridesFactory parentFactory, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null)
    {
        parentFactory.MonitoringConfigurationFactory = new InnerJobTemplateParametricMonitoringConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MonitoringConfigurationFactory);
    }

    public static CombinedResult<InnerJobTemplateParametricConfigurationOverridesFactory, T1, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1>(this CombinedResult<InnerJobTemplateParametricConfigurationOverridesFactory, T1> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateParametricConfigurationOverridesFactory, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1>(this CombinedResult<T1, InnerJobTemplateParametricConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateParametricConfigurationOverridesFactory, T1, T2, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<InnerJobTemplateParametricConfigurationOverridesFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateParametricConfigurationOverridesFactory, T2, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<T1, InnerJobTemplateParametricConfigurationOverridesFactory, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateParametricConfigurationOverridesFactory, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerJobTemplateParametricConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateParametricConfigurationOverridesFactory, T1, T2, T3, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<InnerJobTemplateParametricConfigurationOverridesFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateParametricConfigurationOverridesFactory, T2, T3, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerJobTemplateParametricConfigurationOverridesFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateParametricConfigurationOverridesFactory, T3, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobTemplateParametricConfigurationOverridesFactory, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateParametricConfigurationOverridesFactory, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobTemplateParametricConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateParametricConfigurationOverridesFactory, T1, T2, T3, T4, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerJobTemplateParametricConfigurationOverridesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateParametricConfigurationOverridesFactory, T2, T3, T4, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobTemplateParametricConfigurationOverridesFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateParametricConfigurationOverridesFactory, T3, T4, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobTemplateParametricConfigurationOverridesFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateParametricConfigurationOverridesFactory, T4, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobTemplateParametricConfigurationOverridesFactory, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobTemplateParametricConfigurationOverridesFactory, InnerJobTemplateParametricMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobTemplateParametricConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T5, subFactoryAction).T2);
}
