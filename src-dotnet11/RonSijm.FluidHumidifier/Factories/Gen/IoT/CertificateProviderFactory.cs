// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class CertificateProviderFactory(string resourceName = null, Action<Humidifier.IoT.CertificateProvider> factoryAction = null) : ResourceFactory<Humidifier.IoT.CertificateProvider>(resourceName)
{

    protected override Humidifier.IoT.CertificateProvider Create()
    {
        var certificateProviderResult = CreateCertificateProvider();
        factoryAction?.Invoke(certificateProviderResult);

        return certificateProviderResult;
    }

    private Humidifier.IoT.CertificateProvider CreateCertificateProvider()
    {
        var certificateProviderResult = new Humidifier.IoT.CertificateProvider
        {
            GivenName = InputResourceName,
        };

        return certificateProviderResult;
    }

} // End Of Class

public static class CertificateProviderFactoryExtensions
{
}
