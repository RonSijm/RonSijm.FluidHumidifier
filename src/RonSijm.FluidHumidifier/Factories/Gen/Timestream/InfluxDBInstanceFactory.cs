// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InfluxDBInstanceFactory(string resourceName = null, Action<Humidifier.Timestream.InfluxDBInstance> factoryAction = null) : ResourceFactory<Humidifier.Timestream.InfluxDBInstance>(resourceName)
{

    internal InnerInfluxDBInstanceLogDeliveryConfigurationFactory LogDeliveryConfigurationFactory { get; set; }

    internal InnerInfluxDBInstanceMaintenanceScheduleFactory MaintenanceScheduleFactory { get; set; }

    protected override Humidifier.Timestream.InfluxDBInstance Create()
    {
        var influxDBInstanceResult = CreateInfluxDBInstance();
        factoryAction?.Invoke(influxDBInstanceResult);

        return influxDBInstanceResult;
    }

    private Humidifier.Timestream.InfluxDBInstance CreateInfluxDBInstance()
    {
        var influxDBInstanceResult = new Humidifier.Timestream.InfluxDBInstance
        {
            GivenName = InputResourceName,
        };

        return influxDBInstanceResult;
    }
    public override void CreateChildren(Humidifier.Timestream.InfluxDBInstance result)
    {
        base.CreateChildren(result);

        result.LogDeliveryConfiguration ??= LogDeliveryConfigurationFactory?.Build();
        result.MaintenanceSchedule ??= MaintenanceScheduleFactory?.Build();
    }

} // End Of Class

public static class InfluxDBInstanceFactoryExtensions
{
    public static CombinedResult<InfluxDBInstanceFactory, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration(this InfluxDBInstanceFactory parentFactory, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null)
    {
        parentFactory.LogDeliveryConfigurationFactory = new InnerInfluxDBInstanceLogDeliveryConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogDeliveryConfigurationFactory);
    }

    public static CombinedResult<InfluxDBInstanceFactory, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule(this InfluxDBInstanceFactory parentFactory, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null)
    {
        parentFactory.MaintenanceScheduleFactory = new InnerInfluxDBInstanceMaintenanceScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaintenanceScheduleFactory);
    }

    public static CombinedResult<InfluxDBInstanceFactory, T1, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1>(this CombinedResult<InfluxDBInstanceFactory, T1> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBInstanceFactory, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1>(this CombinedResult<T1, InfluxDBInstanceFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InfluxDBInstanceFactory, T1, T2, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2>(this CombinedResult<InfluxDBInstanceFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBInstanceFactory, T2, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2>(this CombinedResult<T1, InfluxDBInstanceFactory, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBInstanceFactory, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2>(this CombinedResult<T1, T2, InfluxDBInstanceFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InfluxDBInstanceFactory, T1, T2, T3, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3>(this CombinedResult<InfluxDBInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBInstanceFactory, T2, T3, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3>(this CombinedResult<T1, InfluxDBInstanceFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBInstanceFactory, T3, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InfluxDBInstanceFactory, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBInstanceFactory, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InfluxDBInstanceFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InfluxDBInstanceFactory, T1, T2, T3, T4, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<InfluxDBInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBInstanceFactory, T2, T3, T4, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InfluxDBInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBInstanceFactory, T3, T4, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InfluxDBInstanceFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBInstanceFactory, T4, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InfluxDBInstanceFactory, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InfluxDBInstanceFactory, InnerInfluxDBInstanceLogDeliveryConfigurationFactory> WithLogDeliveryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InfluxDBInstanceFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDeliveryConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InfluxDBInstanceFactory, T1, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1>(this CombinedResult<InfluxDBInstanceFactory, T1> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBInstanceFactory, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1>(this CombinedResult<T1, InfluxDBInstanceFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InfluxDBInstanceFactory, T1, T2, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2>(this CombinedResult<InfluxDBInstanceFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBInstanceFactory, T2, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2>(this CombinedResult<T1, InfluxDBInstanceFactory, T2> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBInstanceFactory, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2>(this CombinedResult<T1, T2, InfluxDBInstanceFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InfluxDBInstanceFactory, T1, T2, T3, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3>(this CombinedResult<InfluxDBInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBInstanceFactory, T2, T3, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3>(this CombinedResult<T1, InfluxDBInstanceFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBInstanceFactory, T3, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3>(this CombinedResult<T1, T2, InfluxDBInstanceFactory, T3> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBInstanceFactory, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InfluxDBInstanceFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InfluxDBInstanceFactory, T1, T2, T3, T4, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<InfluxDBInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InfluxDBInstanceFactory, T2, T3, T4, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<T1, InfluxDBInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InfluxDBInstanceFactory, T3, T4, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InfluxDBInstanceFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InfluxDBInstanceFactory, T4, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InfluxDBInstanceFactory, T4> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InfluxDBInstanceFactory, InnerInfluxDBInstanceMaintenanceScheduleFactory> WithMaintenanceSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InfluxDBInstanceFactory> combinedResult, Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceSchedule(combinedResult.T5, subFactoryAction).T2);
}
