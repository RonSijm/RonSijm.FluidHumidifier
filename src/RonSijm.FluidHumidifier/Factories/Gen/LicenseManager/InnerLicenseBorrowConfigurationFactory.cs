// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseBorrowConfigurationFactory(Action<Humidifier.LicenseManager.LicenseTypes.BorrowConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseTypes.BorrowConfiguration>
{

    protected override Humidifier.LicenseManager.LicenseTypes.BorrowConfiguration Create()
    {
        var borrowConfigurationResult = CreateBorrowConfiguration();
        factoryAction?.Invoke(borrowConfigurationResult);

        return borrowConfigurationResult;
    }

    private Humidifier.LicenseManager.LicenseTypes.BorrowConfiguration CreateBorrowConfiguration()
    {
        var borrowConfigurationResult = new Humidifier.LicenseManager.LicenseTypes.BorrowConfiguration();

        return borrowConfigurationResult;
    }

} // End Of Class

public static class InnerLicenseBorrowConfigurationFactoryExtensions
{
}
