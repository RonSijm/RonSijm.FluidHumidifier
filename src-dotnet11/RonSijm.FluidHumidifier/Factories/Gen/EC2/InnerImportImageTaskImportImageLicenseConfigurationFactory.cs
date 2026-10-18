// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerImportImageTaskImportImageLicenseConfigurationFactory(Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration>
{

    protected override Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration Create()
    {
        var importImageLicenseConfigurationResult = CreateImportImageLicenseConfiguration();
        factoryAction?.Invoke(importImageLicenseConfigurationResult);

        return importImageLicenseConfigurationResult;
    }

    private Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration CreateImportImageLicenseConfiguration()
    {
        var importImageLicenseConfigurationResult = new Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration();

        return importImageLicenseConfigurationResult;
    }

} // End Of Class

public static class InnerImportImageTaskImportImageLicenseConfigurationFactoryExtensions
{
}
