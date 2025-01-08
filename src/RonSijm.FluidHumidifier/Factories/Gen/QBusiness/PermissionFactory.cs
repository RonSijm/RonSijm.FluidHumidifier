// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class PermissionFactory(string resourceName = null, Action<Humidifier.QBusiness.Permission> factoryAction = null) : ResourceFactory<Humidifier.QBusiness.Permission>(resourceName)
{

    protected override Humidifier.QBusiness.Permission Create()
    {
        var permissionResult = CreatePermission();
        factoryAction?.Invoke(permissionResult);

        return permissionResult;
    }

    private Humidifier.QBusiness.Permission CreatePermission()
    {
        var permissionResult = new Humidifier.QBusiness.Permission
        {
            GivenName = InputResourceName,
        };

        return permissionResult;
    }

} // End Of Class

public static class PermissionFactoryExtensions
{
}
