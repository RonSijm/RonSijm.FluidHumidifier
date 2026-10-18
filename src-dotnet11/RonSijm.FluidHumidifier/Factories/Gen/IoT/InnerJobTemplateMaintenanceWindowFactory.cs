// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobTemplateMaintenanceWindowFactory(Action<Humidifier.IoT.JobTemplateTypes.MaintenanceWindow> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTemplateTypes.MaintenanceWindow>
{

    protected override Humidifier.IoT.JobTemplateTypes.MaintenanceWindow Create()
    {
        var maintenanceWindowResult = CreateMaintenanceWindow();
        factoryAction?.Invoke(maintenanceWindowResult);

        return maintenanceWindowResult;
    }

    private Humidifier.IoT.JobTemplateTypes.MaintenanceWindow CreateMaintenanceWindow()
    {
        var maintenanceWindowResult = new Humidifier.IoT.JobTemplateTypes.MaintenanceWindow();

        return maintenanceWindowResult;
    }

} // End Of Class

public static class InnerJobTemplateMaintenanceWindowFactoryExtensions
{
}
