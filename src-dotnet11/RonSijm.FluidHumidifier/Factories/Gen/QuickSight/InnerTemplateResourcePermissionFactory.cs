// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateResourcePermissionFactory(Action<Humidifier.QuickSight.TemplateTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.TemplateTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.TemplateTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.TemplateTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerTemplateResourcePermissionFactoryExtensions
{
}
