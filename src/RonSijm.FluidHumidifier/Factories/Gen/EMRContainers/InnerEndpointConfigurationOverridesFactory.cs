// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerEndpointConfigurationOverridesFactory(Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides>
{

    internal InnerEndpointMonitoringConfigurationFactory MonitoringConfigurationFactory { get; set; }

    protected override Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides Create()
    {
        var configurationOverridesResult = CreateConfigurationOverrides();
        factoryAction?.Invoke(configurationOverridesResult);

        return configurationOverridesResult;
    }

    private Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides CreateConfigurationOverrides()
    {
        var configurationOverridesResult = new Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides();

        return configurationOverridesResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides result)
    {
        base.CreateChildren(result);

        result.MonitoringConfiguration ??= MonitoringConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointConfigurationOverridesFactoryExtensions
{
    public static CombinedResult<InnerEndpointConfigurationOverridesFactory, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration(this InnerEndpointConfigurationOverridesFactory parentFactory, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null)
    {
        parentFactory.MonitoringConfigurationFactory = new InnerEndpointMonitoringConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MonitoringConfigurationFactory);
    }

    public static CombinedResult<InnerEndpointConfigurationOverridesFactory, T1, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1>(this CombinedResult<InnerEndpointConfigurationOverridesFactory, T1> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigurationOverridesFactory, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1>(this CombinedResult<T1, InnerEndpointConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEndpointConfigurationOverridesFactory, T1, T2, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<InnerEndpointConfigurationOverridesFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigurationOverridesFactory, T2, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<T1, InnerEndpointConfigurationOverridesFactory, T2> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEndpointConfigurationOverridesFactory, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerEndpointConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEndpointConfigurationOverridesFactory, T1, T2, T3, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<InnerEndpointConfigurationOverridesFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigurationOverridesFactory, T2, T3, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerEndpointConfigurationOverridesFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEndpointConfigurationOverridesFactory, T3, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointConfigurationOverridesFactory, T3> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigurationOverridesFactory, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEndpointConfigurationOverridesFactory, T1, T2, T3, T4, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerEndpointConfigurationOverridesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigurationOverridesFactory, T2, T3, T4, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointConfigurationOverridesFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEndpointConfigurationOverridesFactory, T3, T4, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointConfigurationOverridesFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigurationOverridesFactory, T4, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointConfigurationOverridesFactory, T4> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointConfigurationOverridesFactory, InnerEndpointMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointConfigurationOverridesFactory> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T5, subFactoryAction).T2);
}
