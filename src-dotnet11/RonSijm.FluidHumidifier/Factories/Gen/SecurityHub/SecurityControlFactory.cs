// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class SecurityControlFactory(string resourceName = null, Action<Humidifier.SecurityHub.SecurityControl> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.SecurityControl>(resourceName)
{

    protected override Humidifier.SecurityHub.SecurityControl Create()
    {
        var securityControlResult = CreateSecurityControl();
        factoryAction?.Invoke(securityControlResult);

        return securityControlResult;
    }

    private Humidifier.SecurityHub.SecurityControl CreateSecurityControl()
    {
        var securityControlResult = new Humidifier.SecurityHub.SecurityControl
        {
            GivenName = InputResourceName,
        };

        return securityControlResult;
    }

} // End Of Class

public static class SecurityControlFactoryExtensions
{
}
