// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesThinClient;

public class InnerEnvironmentMaintenanceWindowFactory(Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow>
{

    protected override Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow Create()
    {
        var maintenanceWindowResult = CreateMaintenanceWindow();
        factoryAction?.Invoke(maintenanceWindowResult);

        return maintenanceWindowResult;
    }

    private Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow CreateMaintenanceWindow()
    {
        var maintenanceWindowResult = new Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow();

        return maintenanceWindowResult;
    }

} // End Of Class

public static class InnerEnvironmentMaintenanceWindowFactoryExtensions
{
}
