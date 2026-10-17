// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class InnerCloudExadataInfrastructureMaintenanceWindowFactory(Action<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow> factoryAction = null) : SubResourceFactory<Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow>
{

    protected override Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow Create()
    {
        var maintenanceWindowResult = CreateMaintenanceWindow();
        factoryAction?.Invoke(maintenanceWindowResult);

        return maintenanceWindowResult;
    }

    private Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow CreateMaintenanceWindow()
    {
        var maintenanceWindowResult = new Humidifier.ODB.CloudExadataInfrastructureTypes.MaintenanceWindow();

        return maintenanceWindowResult;
    }

} // End Of Class

public static class InnerCloudExadataInfrastructureMaintenanceWindowFactoryExtensions
{
}
