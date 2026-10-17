// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerInfluxDBInstanceMaintenanceScheduleFactory(Action<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule>
{

    protected override Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule Create()
    {
        var maintenanceScheduleResult = CreateMaintenanceSchedule();
        factoryAction?.Invoke(maintenanceScheduleResult);

        return maintenanceScheduleResult;
    }

    private Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule CreateMaintenanceSchedule()
    {
        var maintenanceScheduleResult = new Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule();

        return maintenanceScheduleResult;
    }

} // End Of Class

public static class InnerInfluxDBInstanceMaintenanceScheduleFactoryExtensions
{
}
