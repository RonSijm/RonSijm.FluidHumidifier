// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Signer;

public class ProfilePermissionFactory(string resourceName = null, Action<Humidifier.Signer.ProfilePermission> factoryAction = null) : ResourceFactory<Humidifier.Signer.ProfilePermission>(resourceName)
{

    protected override Humidifier.Signer.ProfilePermission Create()
    {
        var profilePermissionResult = CreateProfilePermission();
        factoryAction?.Invoke(profilePermissionResult);

        return profilePermissionResult;
    }

    private Humidifier.Signer.ProfilePermission CreateProfilePermission()
    {
        var profilePermissionResult = new Humidifier.Signer.ProfilePermission
        {
            GivenName = InputResourceName,
        };

        return profilePermissionResult;
    }

} // End Of Class

public static class ProfilePermissionFactoryExtensions
{
}
