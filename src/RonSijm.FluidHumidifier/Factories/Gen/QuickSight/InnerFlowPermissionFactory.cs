// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerFlowPermissionFactory(Action<Humidifier.QuickSight.FlowTypes.Permission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.FlowTypes.Permission>
{

    protected override Humidifier.QuickSight.FlowTypes.Permission Create()
    {
        var permissionResult = CreatePermission();
        factoryAction?.Invoke(permissionResult);

        return permissionResult;
    }

    private Humidifier.QuickSight.FlowTypes.Permission CreatePermission()
    {
        var permissionResult = new Humidifier.QuickSight.FlowTypes.Permission();

        return permissionResult;
    }

} // End Of Class

public static class InnerFlowPermissionFactoryExtensions
{
}
