// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class PermissionFactory(string resourceName = null, Action<Humidifier.Lambda.Permission> factoryAction = null) : ResourceFactory<Humidifier.Lambda.Permission>(resourceName)
{

    protected override Humidifier.Lambda.Permission Create()
    {
        var permissionResult = CreatePermission();
        factoryAction?.Invoke(permissionResult);

        return permissionResult;
    }

    private Humidifier.Lambda.Permission CreatePermission()
    {
        var permissionResult = new Humidifier.Lambda.Permission
        {
            GivenName = InputResourceName,
        };

        return permissionResult;
    }

} // End Of Class

public static class PermissionFactoryExtensions
{
}
