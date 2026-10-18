// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InfluxDBClusterFactory(string resourceName = null, Action<Humidifier.Timestream.InfluxDBCluster> factoryAction = null) : ResourceFactory<Humidifier.Timestream.InfluxDBCluster>(resourceName)
{

    internal InnerInfluxDBClusterLogDeliveryConfigurationFactory LogDeliveryConfigurationFactory { get; set; }

    internal InnerInfluxDBClusterMaintenanceScheduleFactory MaintenanceScheduleFactory { get; set; }

    protected override Humidifier.Timestream.InfluxDBCluster Create()
    {
        var influxDBClusterResult = CreateInfluxDBCluster();
        factoryAction?.Invoke(influxDBClusterResult);

        return influxDBClusterResult;
    }

    private Humidifier.Timestream.InfluxDBCluster CreateInfluxDBCluster()
    {
        var influxDBClusterResult = new Humidifier.Timestream.InfluxDBCluster
        {
            GivenName = InputResourceName,
        };

        return influxDBClusterResult;
    }
    public override void CreateChildren(Humidifier.Timestream.InfluxDBCluster result)
    {
        base.CreateChildren(result);

        result.LogDeliveryConfiguration ??= LogDeliveryConfigurationFactory?.Build();
        result.MaintenanceSchedule ??= MaintenanceScheduleFactory?.Build();
    }

} // End Of Class

public static class InfluxDBClusterFactoryExtensions
{
    public static CombinedResult<InfluxDBClusterFactory, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration(this InfluxDBClusterFactory parentFactory, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null)
    {
        parentFactory.LogDeliveryConfigurationFactory = new InnerInfluxDBClusterLogDeliveryConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogDeliveryConfigurationFactory);
    }

    public static CombinedResult<InfluxDBClusterFactory, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule(this InfluxDBClusterFactory parentFactory, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null)
    {
        parentFactory.MaintenanceScheduleFactory = new InnerInfluxDBClusterMaintenanceScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaintenanceScheduleFactory);
    }

    public static CombinedResult<InfluxDBClusterFactory, T1, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1>(this CombinedResult<InfluxDBClusterFactory, T1> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBClusterFactory, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1>(this CombinedResult<T1, InfluxDBClusterFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InfluxDBClusterFactory, T1, T2, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2>(this CombinedResult<InfluxDBClusterFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBClusterFactory, T2, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2>(this CombinedResult<T1, InfluxDBClusterFactory, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBClusterFactory, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2>(this CombinedResult<T1, T2, InfluxDBClusterFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InfluxDBClusterFactory, T1, T2, T3, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3>(this CombinedResult<InfluxDBClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBClusterFactory, T2, T3, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3>(this CombinedResult<T1, InfluxDBClusterFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBClusterFactory, T3, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InfluxDBClusterFactory, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBClusterFactory, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InfluxDBClusterFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InfluxDBClusterFactory, T1, T2, T3, T4, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<InfluxDBClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBClusterFactory, T2, T3, T4, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InfluxDBClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBClusterFactory, T3, T4, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InfluxDBClusterFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBClusterFactory, T4, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InfluxDBClusterFactory, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InfluxDBClusterFactory, InnerInfluxDBClusterLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InfluxDBClusterFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InfluxDBClusterFactory, T1, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1>(this CombinedResult<InfluxDBClusterFactory, T1> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBClusterFactory, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1>(this CombinedResult<T1, InfluxDBClusterFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InfluxDBClusterFactory, T1, T2, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2>(this CombinedResult<InfluxDBClusterFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBClusterFactory, T2, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2>(this CombinedResult<T1, InfluxDBClusterFactory, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBClusterFactory, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2>(this CombinedResult<T1, T2, InfluxDBClusterFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InfluxDBClusterFactory, T1, T2, T3, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3>(this CombinedResult<InfluxDBClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBClusterFactory, T2, T3, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3>(this CombinedResult<T1, InfluxDBClusterFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBClusterFactory, T3, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3>(this CombinedResult<T1, T2, InfluxDBClusterFactory, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBClusterFactory, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InfluxDBClusterFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InfluxDBClusterFactory, T1, T2, T3, T4, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<InfluxDBClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBClusterFactory, T2, T3, T4, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<T1, InfluxDBClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBClusterFactory, T3, T4, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InfluxDBClusterFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBClusterFactory, T4, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InfluxDBClusterFactory, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InfluxDBClusterFactory, InnerInfluxDBClusterMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InfluxDBClusterFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T5, subFactoryAction).T2);
}
