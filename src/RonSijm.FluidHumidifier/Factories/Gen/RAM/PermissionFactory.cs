// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RAM;

public class PermissionFactory(string resourceName = null, Action<Humidifier.RAM.Permission> factoryAction = null) : ResourceFactory<Humidifier.RAM.Permission>(resourceName)
{

    protected override Humidifier.RAM.Permission Create()
    {
        var permissionResult = CreatePermission();
        factoryAction?.Invoke(permissionResult);

        return permissionResult;
    }

    private Humidifier.RAM.Permission CreatePermission()
    {
        var permissionResult = new Humidifier.RAM.Permission
        {
            GivenName = InputResourceName,
        };

        return permissionResult;
    }

} // End Of Class

public static class PermissionFactoryExtensions
{
}
