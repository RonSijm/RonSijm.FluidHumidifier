// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerMaintenanceWindowTaskMaintenanceWindowLambdaParametersFactory(Action<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowLambdaParameters> factoryAction = null) : SubResourceFactory<Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowLambdaParameters>
{

    protected override Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowLambdaParameters Create()
    {
        var maintenanceWindowLambdaParametersResult = CreateMaintenanceWindowLambdaParameters();
        factoryAction?.Invoke(maintenanceWindowLambdaParametersResult);

        return maintenanceWindowLambdaParametersResult;
    }

    private Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowLambdaParameters CreateMaintenanceWindowLambdaParameters()
    {
        var maintenanceWindowLambdaParametersResult = new Humidifier.SSM.MaintenanceWindowTaskTypes.MaintenanceWindowLambdaParameters();

        return maintenanceWindowLambdaParametersResult;
    }

} // End Of Class

public static class InnerMaintenanceWindowTaskMaintenanceWindowLambdaParametersFactoryExtensions
{
}
