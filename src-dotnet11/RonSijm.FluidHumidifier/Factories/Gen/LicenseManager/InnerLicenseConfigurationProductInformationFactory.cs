// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseConfigurationProductInformationFactory(Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation>
{

    protected override Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation Create()
    {
        var productInformationResult = CreateProductInformation();
        factoryAction?.Invoke(productInformationResult);

        return productInformationResult;
    }

    private Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation CreateProductInformation()
    {
        var productInformationResult = new Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation();

        return productInformationResult;
    }

} // End Of Class

public static class InnerLicenseConfigurationProductInformationFactoryExtensions
{
}
