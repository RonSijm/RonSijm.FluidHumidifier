// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerServicePermissionModelFactory(Action<Humidifier.ResilienceHubV2.ServiceTypes.PermissionModel> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.ServiceTypes.PermissionModel>
{

    protected override Humidifier.ResilienceHubV2.ServiceTypes.PermissionModel Create()
    {
        var permissionModelResult = CreatePermissionModel();
        factoryAction?.Invoke(permissionModelResult);

        return permissionModelResult;
    }

    private Humidifier.ResilienceHubV2.ServiceTypes.PermissionModel CreatePermissionModel()
    {
        var permissionModelResult = new Humidifier.ResilienceHubV2.ServiceTypes.PermissionModel();

        return permissionModelResult;
    }

} // End Of Class

public static class InnerServicePermissionModelFactoryExtensions
{
}
