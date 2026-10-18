// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class GrantFactory(string resourceName = null, Action<Humidifier.LicenseManager.Grant> factoryAction = null) : ResourceFactory<Humidifier.LicenseManager.Grant>(resourceName)
{

    protected override Humidifier.LicenseManager.Grant Create()
    {
        var grantResult = CreateGrant();
        factoryAction?.Invoke(grantResult);

        return grantResult;
    }

    private Humidifier.LicenseManager.Grant CreateGrant()
    {
        var grantResult = new Humidifier.LicenseManager.Grant
        {
            GivenName = InputResourceName,
        };

        return grantResult;
    }

} // End Of Class

public static class GrantFactoryExtensions
{
}
