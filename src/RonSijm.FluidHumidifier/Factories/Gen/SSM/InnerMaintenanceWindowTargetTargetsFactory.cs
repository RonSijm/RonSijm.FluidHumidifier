// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerMaintenanceWindowTargetTargetsFactory(Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> factoryAction = null) : SubResourceFactory<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets>
{

    protected override Humidifier.SSM.MaintenanceWindowTargetTypes.Targets Create()
    {
        var targetsResult = CreateTargets();
        factoryAction?.Invoke(targetsResult);

        return targetsResult;
    }

    private Humidifier.SSM.MaintenanceWindowTargetTypes.Targets CreateTargets()
    {
        var targetsResult = new Humidifier.SSM.MaintenanceWindowTargetTypes.Targets();

        return targetsResult;
    }

} // End Of Class

public static class InnerMaintenanceWindowTargetTargetsFactoryExtensions
{
}
