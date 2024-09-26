// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class CertificateFactory(string resourceName = null, Action<Humidifier.IoT.Certificate> factoryAction = null) : ResourceFactory<Humidifier.IoT.Certificate>(resourceName)
{

    protected override Humidifier.IoT.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.IoT.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.IoT.Certificate
        {
            GivenName = InputResourceName,
        };

        return certificateResult;
    }

} // End Of Class

public static class CertificateFactoryExtensions
{
}
