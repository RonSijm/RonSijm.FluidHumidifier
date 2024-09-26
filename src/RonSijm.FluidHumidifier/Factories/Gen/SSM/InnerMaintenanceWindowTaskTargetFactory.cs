// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerMaintenanceWindowTaskTargetFactory(Action<Humidifier.SSM.MaintenanceWindowTaskTypes.Target> factoryAction = null) : SubResourceFactory<Humidifier.SSM.MaintenanceWindowTaskTypes.Target>
{

    protected override Humidifier.SSM.MaintenanceWindowTaskTypes.Target Create()
    {
        var targetResult = CreateTarget();
        factoryAction?.Invoke(targetResult);

        return targetResult;
    }

    private Humidifier.SSM.MaintenanceWindowTaskTypes.Target CreateTarget()
    {
        var targetResult = new Humidifier.SSM.MaintenanceWindowTaskTypes.Target();

        return targetResult;
    }

} // End Of Class

public static class InnerMaintenanceWindowTaskTargetFactoryExtensions
{
}
