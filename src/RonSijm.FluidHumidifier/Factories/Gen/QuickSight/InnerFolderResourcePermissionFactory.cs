// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerFolderResourcePermissionFactory(Action<Humidifier.QuickSight.FolderTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.FolderTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.FolderTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.FolderTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.FolderTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerFolderResourcePermissionFactoryExtensions
{
}
