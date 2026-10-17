// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerActionConnectorResourcePermissionFactory(Action<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerActionConnectorResourcePermissionFactoryExtensions
{
}
