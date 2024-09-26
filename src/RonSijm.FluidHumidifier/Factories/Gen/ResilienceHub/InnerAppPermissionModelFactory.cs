// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHub;

public class InnerAppPermissionModelFactory(Action<Humidifier.ResilienceHub.AppTypes.PermissionModel> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHub.AppTypes.PermissionModel>
{

    protected override Humidifier.ResilienceHub.AppTypes.PermissionModel Create()
    {
        var permissionModelResult = CreatePermissionModel();
        factoryAction?.Invoke(permissionModelResult);

        return permissionModelResult;
    }

    private Humidifier.ResilienceHub.AppTypes.PermissionModel CreatePermissionModel()
    {
        var permissionModelResult = new Humidifier.ResilienceHub.AppTypes.PermissionModel();

        return permissionModelResult;
    }

} // End Of Class

public static class InnerAppPermissionModelFactoryExtensions
{
}
