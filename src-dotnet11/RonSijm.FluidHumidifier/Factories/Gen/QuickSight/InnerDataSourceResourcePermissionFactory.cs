// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceResourcePermissionFactory(Action<Humidifier.QuickSight.DataSourceTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.DataSourceTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.DataSourceTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerDataSourceResourcePermissionFactoryExtensions
{
}
