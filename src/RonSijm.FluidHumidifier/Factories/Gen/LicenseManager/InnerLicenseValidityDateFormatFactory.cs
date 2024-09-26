// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseValidityDateFormatFactory(Action<Humidifier.LicenseManager.LicenseTypes.ValidityDateFormat> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseTypes.ValidityDateFormat>
{

    protected override Humidifier.LicenseManager.LicenseTypes.ValidityDateFormat Create()
    {
        var validityDateFormatResult = CreateValidityDateFormat();
        factoryAction?.Invoke(validityDateFormatResult);

        return validityDateFormatResult;
    }

    private Humidifier.LicenseManager.LicenseTypes.ValidityDateFormat CreateValidityDateFormat()
    {
        var validityDateFormatResult = new Humidifier.LicenseManager.LicenseTypes.ValidityDateFormat();

        return validityDateFormatResult;
    }

} // End Of Class

public static class InnerLicenseValidityDateFormatFactoryExtensions
{
}
