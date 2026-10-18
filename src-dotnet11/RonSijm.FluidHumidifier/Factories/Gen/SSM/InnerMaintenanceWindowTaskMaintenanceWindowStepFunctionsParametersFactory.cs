// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerMaintenanceWindowTaskMaintenanceWindowStepFunctionsParametersFactory(Action<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowStepFunctionsParameters> factoryAction = null) : SubResourceFactory<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowStepFunctionsParameters>
{

    protected override Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowStepFunctionsParameters Create()
    {
        var maintenanceWindowStepFunctionsParametersResult = CreateMaintenanceWindowStepFunctionsParameters();
        factoryAction?.Invoke(maintenanceWindowStepFunctionsParametersResult);

        return maintenanceWindowStepFunctionsParametersResult;
    }

    private Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowStepFunctionsParameters CreateMaintenanceWindowStepFunctionsParameters()
    {
        var maintenanceWindowStepFunctionsParametersResult = new Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowStepFunctionsParameters();

        return maintenanceWindowStepFunctionsParametersResult;
    }

} // End Of Class

public static class InnerMaintenanceWindowTaskMaintenanceWindowStepFunctionsParametersFactoryExtensions
{
}
