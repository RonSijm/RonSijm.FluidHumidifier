// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardResourcePermissionFactory(Action<Humidifier.QuickSight.DashboardTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.DashboardTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.DashboardTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerDashboardResourcePermissionFactoryExtensions
{
}
