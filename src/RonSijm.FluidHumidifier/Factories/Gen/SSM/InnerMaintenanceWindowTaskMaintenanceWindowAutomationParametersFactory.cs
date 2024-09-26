// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerMaintenanceWindowTaskMaintenanceWindowAutomationParametersFactory(Action<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowAutomationParameters> factoryAction = null) : SubResourceFactory<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowAutomationParameters>
{

    protected override Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowAutomationParameters Create()
    {
        var maintenanceWindowAutomationParametersResult = CreateMaintenanceWindowAutomationParameters();
        factoryAction?.Invoke(maintenanceWindowAutomationParametersResult);

        return maintenanceWindowAutomationParametersResult;
    }

    private Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowAutomationParameters CreateMaintenanceWindowAutomationParameters()
    {
        var maintenanceWindowAutomationParametersResult = new Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowAutomationParameters();

        return maintenanceWindowAutomationParametersResult;
    }

} // End Of Class

public static class InnerMaintenanceWindowTaskMaintenanceWindowAutomationParametersFactoryExtensions
{
}
