// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class PermissionFactory(string resourceName = null, Action<Humidifier.ACMPCA.Permission> factoryAction = null) : ResourceFactory<Humidifier.ACMPCA.Permission>(resourceName)
{

    protected override Humidifier.ACMPCA.Permission Create()
    {
        var permissionResult = CreatePermission();
        factoryAction?.Invoke(permissionResult);

        return permissionResult;
    }

    private Humidifier.ACMPCA.Permission CreatePermission()
    {
        var permissionResult = new Humidifier.ACMPCA.Permission
        {
            GivenName = InputResourceName,
        };

        return permissionResult;
    }

} // End Of Class

public static class PermissionFactoryExtensions
{
}
