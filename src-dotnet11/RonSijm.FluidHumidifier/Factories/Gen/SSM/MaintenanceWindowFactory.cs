// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class MaintenanceWindowFactory(string resourceName = null, Action<Humidifier.SSM.MaintenanceWindow> factoryAction = null) : ResourceFactory<Humidifier.SSM.MaintenanceWindow>(resourceName)
{

    protected override Humidifier.SSM.MaintenanceWindow Create()
    {
        var maintenanceWindowResult = CreateMaintenanceWindow();
        factoryAction?.Invoke(maintenanceWindowResult);

        return maintenanceWindowResult;
    }

    private Humidifier.SSM.MaintenanceWindow CreateMaintenanceWindow()
    {
        var maintenanceWindowResult = new Humidifier.SSM.MaintenanceWindow
        {
            GivenName = InputResourceName,
        };

        return maintenanceWindowResult;
    }

} // End Of Class

public static class MaintenanceWindowFactoryExtensions
{
}
