// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeResourcePermissionFactory(Action<Humidifier.QuickSight.ThemeTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.ThemeTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.ThemeTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.ThemeTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerThemeResourcePermissionFactoryExtensions
{
}
