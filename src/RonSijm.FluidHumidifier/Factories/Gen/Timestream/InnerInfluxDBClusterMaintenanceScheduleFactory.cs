// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerInfluxDBClusterMaintenanceScheduleFactory(Action<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule>
{

    protected override Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule Create()
    {
        var maintenanceScheduleResult = CreateMaintenanceSchedule();
        factoryAction?.Invoke(maintenanceScheduleResult);

        return maintenanceScheduleResult;
    }

    private Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule CreateMaintenanceSchedule()
    {
        var maintenanceScheduleResult = new Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule();

        return maintenanceScheduleResult;
    }

} // End Of Class

public static class InnerInfluxDBClusterMaintenanceScheduleFactoryExtensions
{
}
