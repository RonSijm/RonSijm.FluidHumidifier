// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class SecurityKeyFactory(string resourceName = null, Action<Humidifier.Connect.SecurityKey> factoryAction = null) : ResourceFactory<Humidifier.Connect.SecurityKey>(resourceName)
{

    protected override Humidifier.Connect.SecurityKey Create()
    {
        var securityKeyResult = CreateSecurityKey();
        factoryAction?.Invoke(securityKeyResult);

        return securityKeyResult;
    }

    private Humidifier.Connect.SecurityKey CreateSecurityKey()
    {
        var securityKeyResult = new Humidifier.Connect.SecurityKey
        {
            GivenName = InputResourceName,
        };

        return securityKeyResult;
    }

} // End Of Class

public static class SecurityKeyFactoryExtensions
{
}
