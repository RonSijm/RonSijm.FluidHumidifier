// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetResourcePermissionFactory(Action<Humidifier.QuickSight.DataSetTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.DataSetTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.DataSetTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.DataSetTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerDataSetResourcePermissionFactoryExtensions
{
}
