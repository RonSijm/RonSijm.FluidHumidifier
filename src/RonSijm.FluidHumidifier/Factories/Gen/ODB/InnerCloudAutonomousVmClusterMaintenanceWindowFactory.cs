// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class InnerCloudAutonomousVmClusterMaintenanceWindowFactory(Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow> factoryAction = null) : SubResourceFactory<Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow>
{

    protected override Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow Create()
    {
        var maintenanceWindowResult = CreateMaintenanceWindow();
        factoryAction?.Invoke(maintenanceWindowResult);

        return maintenanceWindowResult;
    }

    private Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow CreateMaintenanceWindow()
    {
        var maintenanceWindowResult = new Humidifier.ODB.CloudAutonomousVmClusterTypes.MaintenanceWindow();

        return maintenanceWindowResult;
    }

} // End Of Class

public static class InnerCloudAutonomousVmClusterMaintenanceWindowFactoryExtensions
{
}
