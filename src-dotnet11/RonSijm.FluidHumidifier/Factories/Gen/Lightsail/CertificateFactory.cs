// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class CertificateFactory(string resourceName = null, Action<Humidifier.Lightsail.Certificate> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.Certificate>(resourceName)
{

    protected override Humidifier.Lightsail.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.Lightsail.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.Lightsail.Certificate
        {
            GivenName = InputResourceName,
        };

        return certificateResult;
    }

} // End Of Class

public static class CertificateFactoryExtensions
{
}
