// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseIssuerDataFactory(Action<Humidifier.LicenseManager.LicenseTypes.IssuerData> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseTypes.IssuerData>
{

    protected override Humidifier.LicenseManager.LicenseTypes.IssuerData Create()
    {
        var issuerDataResult = CreateIssuerData();
        factoryAction?.Invoke(issuerDataResult);

        return issuerDataResult;
    }

    private Humidifier.LicenseManager.LicenseTypes.IssuerData CreateIssuerData()
    {
        var issuerDataResult = new Humidifier.LicenseManager.LicenseTypes.IssuerData();

        return issuerDataResult;
    }

} // End Of Class

public static class InnerLicenseIssuerDataFactoryExtensions
{
}
