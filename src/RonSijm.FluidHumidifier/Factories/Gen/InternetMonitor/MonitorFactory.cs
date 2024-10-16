// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InternetMonitor;

public class MonitorFactory(string resourceName = null, Action<Humidifier.InternetMonitor.Monitor> factoryAction = null) : ResourceFactory<Humidifier.InternetMonitor.Monitor>(resourceName)
{

    internal InnerMonitorHealthEventsConfigFactory HealthEventsConfigFactory { get; set; }

    internal InnerMonitorInternetMeasurementsLogDeliveryFactory InternetMeasurementsLogDeliveryFactory { get; set; }

    protected override Humidifier.InternetMonitor.Monitor Create()
    {
        var monitorResult = CreateMonitor();
        factoryAction?.Invoke(monitorResult);

        return monitorResult;
    }

    private Humidifier.InternetMonitor.Monitor CreateMonitor()
    {
        var monitorResult = new Humidifier.InternetMonitor.Monitor
        {
            GivenName = InputResourceName,
        };

        return monitorResult;
    }
    public override void CreateChildren(Humidifier.InternetMonitor.Monitor result)
    {
        base.CreateChildren(result);

        result.HealthEventsConfig ??= HealthEventsConfigFactory?.Build();
        result.InternetMeasurementsLogDelivery ??= InternetMeasurementsLogDeliveryFactory?.Build();
    }

} // End Of Class

public static class MonitorFactoryExtensions
{
    public static CombinedResult<MonitorFactory, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig(this MonitorFactory parentFactory, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null)
    {
        parentFactory.HealthEventsConfigFactory = new InnerMonitorHealthEventsConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HealthEventsConfigFactory);
    }

    public static CombinedResult<MonitorFactory, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery(this MonitorFactory parentFactory, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null)
    {
        parentFactory.InternetMeasurementsLogDeliveryFactory = new InnerMonitorInternetMeasurementsLogDeliveryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InternetMeasurementsLogDeliveryFactory);
    }

    public static CombinedResult<MonitorFactory, T1, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1>(this CombinedResult<MonitorFactory, T1> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitorFactory, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1>(this CombinedResult<T1, MonitorFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MonitorFactory, T1, T2, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2>(this CombinedResult<MonitorFactory, T1, T2> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitorFactory, T2, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2>(this CombinedResult<T1, MonitorFactory, T2> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitorFactory, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2>(this CombinedResult<T1, T2, MonitorFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MonitorFactory, T1, T2, T3, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2, T3>(this CombinedResult<MonitorFactory, T1, T2, T3> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitorFactory, T2, T3, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2, T3>(this CombinedResult<T1, MonitorFactory, T2, T3> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitorFactory, T3, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2, T3>(this CombinedResult<T1, T2, MonitorFactory, T3> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitorFactory, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, MonitorFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MonitorFactory, T1, T2, T3, T4, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2, T3, T4>(this CombinedResult<MonitorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitorFactory, T2, T3, T4, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2, T3, T4>(this CombinedResult<T1, MonitorFactory, T2, T3, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitorFactory, T3, T4, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, MonitorFactory, T3, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitorFactory, T4, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MonitorFactory, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MonitorFactory, InnerMonitorHealthEventsConfigFactory> WithHealthEventsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MonitorFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.HealthEventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthEventsConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MonitorFactory, T1, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1>(this CombinedResult<MonitorFactory, T1> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitorFactory, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1>(this CombinedResult<T1, MonitorFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MonitorFactory, T1, T2, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2>(this CombinedResult<MonitorFactory, T1, T2> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitorFactory, T2, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2>(this CombinedResult<T1, MonitorFactory, T2> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitorFactory, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2>(this CombinedResult<T1, T2, MonitorFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MonitorFactory, T1, T2, T3, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2, T3>(this CombinedResult<MonitorFactory, T1, T2, T3> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitorFactory, T2, T3, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2, T3>(this CombinedResult<T1, MonitorFactory, T2, T3> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitorFactory, T3, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2, T3>(this CombinedResult<T1, T2, MonitorFactory, T3> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitorFactory, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2, T3>(this CombinedResult<T1, T2, T3, MonitorFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MonitorFactory, T1, T2, T3, T4, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2, T3, T4>(this CombinedResult<MonitorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitorFactory, T2, T3, T4, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, MonitorFactory, T2, T3, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitorFactory, T3, T4, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, MonitorFactory, T3, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitorFactory, T4, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MonitorFactory, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MonitorFactory, InnerMonitorInternetMeasurementsLogDeliveryFactory> WithInternetMeasurementsLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MonitorFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternetMeasurementsLogDelivery(combinedResult.T5, subFactoryAction));
}
