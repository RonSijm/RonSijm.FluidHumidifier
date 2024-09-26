// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseEntitlementFactory(Action<Humidifier.LicenseManager.LicenseTypes.Entitlement> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseTypes.Entitlement>
{

    protected override Humidifier.LicenseManager.LicenseTypes.Entitlement Create()
    {
        var entitlementResult = CreateEntitlement();
        factoryAction?.Invoke(entitlementResult);

        return entitlementResult;
    }

    private Humidifier.LicenseManager.LicenseTypes.Entitlement CreateEntitlement()
    {
        var entitlementResult = new Humidifier.LicenseManager.LicenseTypes.Entitlement();

        return entitlementResult;
    }

} // End Of Class

public static class InnerLicenseEntitlementFactoryExtensions
{
}
