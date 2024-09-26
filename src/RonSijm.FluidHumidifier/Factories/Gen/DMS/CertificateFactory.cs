// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class CertificateFactory(string resourceName = null, Action<Humidifier.DMS.Certificate> factoryAction = null) : ResourceFactory<Humidifier.DMS.Certificate>(resourceName)
{

    protected override Humidifier.DMS.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.DMS.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.DMS.Certificate
        {
            GivenName = InputResourceName,
        };

        return certificateResult;
    }

} // End Of Class

public static class CertificateFactoryExtensions
{
}
