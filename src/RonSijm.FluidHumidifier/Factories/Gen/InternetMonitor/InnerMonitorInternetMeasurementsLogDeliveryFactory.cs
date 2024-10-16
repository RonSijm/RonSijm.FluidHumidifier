// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InternetMonitor;

public class InnerMonitorInternetMeasurementsLogDeliveryFactory(Action<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery> factoryAction = null) : SubResourceFactory<Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery>
{

    internal InnerMonitorS3ConfigFactory S3ConfigFactory { get; set; }

    protected override Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery Create()
    {
        var internetMeasurementsLogDeliveryResult = CreateInternetMeasurementsLogDelivery();
        factoryAction?.Invoke(internetMeasurementsLogDeliveryResult);

        return internetMeasurementsLogDeliveryResult;
    }

    private Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery CreateInternetMeasurementsLogDelivery()
    {
        var internetMeasurementsLogDeliveryResult = new Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery();

        return internetMeasurementsLogDeliveryResult;
    }
    public override void CreateChildren(Humidifier.InternetMonitor.MonitorTypes.InternetMeasurementsLogDelivery result)
    {
        base.CreateChildren(result);

        result.S3Config ??= S3ConfigFactory?.Build();
    }

} // End Of Class

public static class InnerMonitorInternetMeasurementsLogDeliveryFactoryExtensions
{
    public static CombinedResult<InnerMonitorInternetMeasurementsLogDeliveryFactory, InnerMonitorS3ConfigFactory> WithS3Config(this InnerMonitorInternetMeasurementsLogDeliveryFactory parentFactory, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null)
    {
        parentFactory.S3ConfigFactory = new InnerMonitorS3ConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ConfigFactory);
    }

    public static CombinedResult<InnerMonitorInternetMeasurementsLogDeliveryFactory, T1, InnerMonitorS3ConfigFactory> WithS3Config<T1>(this CombinedResult<InnerMonitorInternetMeasurementsLogDeliveryFactory, T1> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitorInternetMeasurementsLogDeliveryFactory, InnerMonitorS3ConfigFactory> WithS3Config<T1>(this CombinedResult<T1, InnerMonitorInternetMeasurementsLogDeliveryFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMonitorInternetMeasurementsLogDeliveryFactory, T1, T2, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2>(this CombinedResult<InnerMonitorInternetMeasurementsLogDeliveryFactory, T1, T2> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitorInternetMeasurementsLogDeliveryFactory, T2, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2>(this CombinedResult<T1, InnerMonitorInternetMeasurementsLogDeliveryFactory, T2> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitorInternetMeasurementsLogDeliveryFactory, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2>(this CombinedResult<T1, T2, InnerMonitorInternetMeasurementsLogDeliveryFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMonitorInternetMeasurementsLogDeliveryFactory, T1, T2, T3, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2, T3>(this CombinedResult<InnerMonitorInternetMeasurementsLogDeliveryFactory, T1, T2, T3> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitorInternetMeasurementsLogDeliveryFactory, T2, T3, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2, T3>(this CombinedResult<T1, InnerMonitorInternetMeasurementsLogDeliveryFactory, T2, T3> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitorInternetMeasurementsLogDeliveryFactory, T3, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2, T3>(this CombinedResult<T1, T2, InnerMonitorInternetMeasurementsLogDeliveryFactory, T3> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMonitorInternetMeasurementsLogDeliveryFactory, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMonitorInternetMeasurementsLogDeliveryFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMonitorInternetMeasurementsLogDeliveryFactory, T1, T2, T3, T4, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<InnerMonitorInternetMeasurementsLogDeliveryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitorInternetMeasurementsLogDeliveryFactory, T2, T3, T4, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<T1, InnerMonitorInternetMeasurementsLogDeliveryFactory, T2, T3, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitorInternetMeasurementsLogDeliveryFactory, T3, T4, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMonitorInternetMeasurementsLogDeliveryFactory, T3, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMonitorInternetMeasurementsLogDeliveryFactory, T4, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMonitorInternetMeasurementsLogDeliveryFactory, T4> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMonitorInternetMeasurementsLogDeliveryFactory, InnerMonitorS3ConfigFactory> WithS3Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMonitorInternetMeasurementsLogDeliveryFactory> combinedResult, Action<Humidifier.InternetMonitor.MonitorTypes.S3Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Config(combinedResult.T5, subFactoryAction));
}
