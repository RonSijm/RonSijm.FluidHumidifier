// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerSpaceResourcePermissionFactory(Action<Humidifier.QuickSight.SpaceTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.SpaceTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.SpaceTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.SpaceTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.SpaceTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerSpaceResourcePermissionFactoryExtensions
{
}
